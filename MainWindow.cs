using System.Globalization;
using System.IO.Ports;
using System.Media;

namespace ComTester
{
    public partial class MainWindow : Form
    {
        SerialPort port;
        String port_name;
        bool bConnected = false;

        bool bSending = false;
        int counter = 0;

        /*
         * Move window section
         */
        bool bMouseDown = false;
        Point mousePosDown = Point.Empty;
        Point currentFormLocation = Point.Empty;

        public MainWindow()
        {
            InitializeComponent();
            this.Location = new Point(Properties.Settings.Default.main_form_pos_x, Properties.Settings.Default.main_form_pos_y);
            refreshCOMlist();
        }

        private void btnListCOM_Click(object sender, EventArgs e)
        {
            refreshCOMlist();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!bConnected)
            {
                try
                {
                    port_name = lbCOMs.SelectedItem.ToString();
                    int baudrate = int.Parse(txtBaudRate.Text);
                    port = new SerialPort(port_name, baudrate, Parity.None, 8, StopBits.One);
                    port.Open();
                    bConnected = true;
                    btnConnect.Text = "Rozłącz " + port_name;
                    btnConnect.BackColor = Color.LightCoral;

                    lbCOMs.Enabled = false;
                    txtBaudRate.Enabled = false;

                    btnStart.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                port.Close();
                bConnected = false;
                btnConnect.Text = "Połącz";
                btnConnect.BackColor = Color.LightGreen;

                lbCOMs.Enabled = true;
                txtBaudRate.Enabled = true;

                btnStart.Enabled = false;
                StopSending();
            }

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bConnected)
            {
                port.Close();
                bConnected = false;
            }

            Properties.Settings.Default.main_form_pos_x = this.Location.X;
            Properties.Settings.Default.main_form_pos_y = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        void refreshCOMlist()
        {
            string[] ports = SerialPort.GetPortNames();
            lbCOMs.Items.Clear();

            foreach (string port in ports)
            {
                lbCOMs.Items.Add(port);
            }

            if (ports.Length > 0)
                lbCOMs.SelectedIndex = 0;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * 
         * Move window section
         * 
         */
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mousePosDown = Control.MousePosition;
            currentFormLocation = Location;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            mousePosDown = Point.Empty;
            currentFormLocation = Point.Empty;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - mousePosDown.X;
                var distY = currentPos.Y - mousePosDown.Y;
                Location = new Point(currentFormLocation.X + distX, currentFormLocation.Y + distY);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * 
         * Sending section
         * 
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bSending)
            {
                bSending = true;
                btnStart.Text = "Stop";
                btnStart.BackColor = Color.LightCoral;
                timer1.Start();
                counter = 0;
            }
            else
            {
                StopSending();
            }
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            float value = 0.1f * tbValue.Value;
            lblValue.Text = value.ToString("0.0");
        }

        private void tbTimer_Scroll(object sender, EventArgs e)
        {
            lblTimer.Text = tbTimer.Value.ToString();
            timer1.Stop();
            timer1.Interval = 1000 / tbTimer.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bConnected && bSending)
            {
                string endline = "";
                if (rbSpace.Checked)
                    endline = " ";
                else if (rbLF.Checked)
                    endline = "\n";
                else if (rbCR.Checked)
                    endline = "\r";
                else if (rbCRLF.Checked)
                    endline = "\r\n";

                float value = 0.1f * tbValue.Value;
                string msg = cbLabels.Text + value.ToString("0.0") + endline;
                port.Write(msg);
                counter++;
                lblCounter.Text = counter.ToString();

                lblOutput.Text = msg;
            }
        }

        void StopSending()
        {
            bSending = false;
            btnStart.Text = "Start";
            btnStart.BackColor = Color.LightGreen;
            timer1.Stop();
        }
    }
}
