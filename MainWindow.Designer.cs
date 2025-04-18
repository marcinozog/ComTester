namespace ComTester
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnListCOM = new Button();
            lbCOMs = new ListBox();
            btnConnect = new Button();
            lblBaudRate = new Label();
            txtBaudRate = new TextBox();
            btnCloseForm = new Button();
            label1 = new Label();
            btnMinimize = new Button();
            label4 = new Label();
            rbNone = new RadioButton();
            rbSpace = new RadioButton();
            rbLF = new RadioButton();
            rbCR = new RadioButton();
            rbCRLF = new RadioButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            tbValue = new TrackBar();
            lblOutput = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tbTimer = new TrackBar();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            cbLabels = new ComboBox();
            lblCounter = new Label();
            lblTimer = new Label();
            lblValue = new Label();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTimer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.BackColor = SystemColors.Desktop;
            btnListCOM.Location = new Point(11, 68);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(194, 48);
            btnListCOM.TabIndex = 1;
            btnListCOM.Text = "Odśwież listę portów";
            btnListCOM.UseVisualStyleBackColor = false;
            btnListCOM.Click += btnListCOM_Click;
            // 
            // lbCOMs
            // 
            lbCOMs.BackColor = SystemColors.Desktop;
            lbCOMs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCOMs.ForeColor = SystemColors.HighlightText;
            lbCOMs.FormattingEnabled = true;
            lbCOMs.ItemHeight = 25;
            lbCOMs.Location = new Point(11, 122);
            lbCOMs.Name = "lbCOMs";
            lbCOMs.Size = new Size(194, 179);
            lbCOMs.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.ForeColor = SystemColors.Desktop;
            btnConnect.Location = new Point(11, 354);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 48);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(11, 317);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(96, 25);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(114, 313);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(90, 31);
            txtBaudRate.TabIndex = 8;
            txtBaudRate.Text = "115200";
            txtBaudRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCloseForm
            // 
            btnCloseForm.BackColor = Color.Brown;
            btnCloseForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCloseForm.ForeColor = SystemColors.HighlightText;
            btnCloseForm.Location = new Point(736, 12);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(51, 48);
            btnCloseForm.TabIndex = 11;
            btnCloseForm.Text = "X";
            btnCloseForm.UseVisualStyleBackColor = false;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(307, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 12;
            label1.Text = "ComTester";
            label1.MouseDown += MainWindow_MouseDown;
            label1.MouseMove += MainWindow_MouseMove;
            label1.MouseUp += MainWindow_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Brown;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimize.ForeColor = SystemColors.HighlightText;
            btnMinimize.Location = new Point(679, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(51, 48);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 485);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 15;
            label4.Text = "Wersja 0.2";
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Checked = true;
            rbNone.Location = new Point(16, 36);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(72, 29);
            rbNone.TabIndex = 17;
            rbNone.TabStop = true;
            rbNone.Text = "brak";
            rbNone.UseVisualStyleBackColor = true;
            // 
            // rbSpace
            // 
            rbSpace.AutoSize = true;
            rbSpace.Location = new Point(16, 71);
            rbSpace.Name = "rbSpace";
            rbSpace.Size = new Size(86, 29);
            rbSpace.TabIndex = 18;
            rbSpace.Text = "spacja";
            rbSpace.UseVisualStyleBackColor = true;
            // 
            // rbLF
            // 
            rbLF.AutoSize = true;
            rbLF.Location = new Point(16, 106);
            rbLF.Name = "rbLF";
            rbLF.Size = new Size(54, 29);
            rbLF.TabIndex = 19;
            rbLF.Text = "LF";
            rbLF.UseVisualStyleBackColor = true;
            // 
            // rbCR
            // 
            rbCR.AutoSize = true;
            rbCR.Location = new Point(16, 143);
            rbCR.Name = "rbCR";
            rbCR.Size = new Size(59, 29);
            rbCR.TabIndex = 20;
            rbCR.Text = "CR";
            rbCR.UseVisualStyleBackColor = true;
            // 
            // rbCRLF
            // 
            rbCRLF.AutoSize = true;
            rbCRLF.Location = new Point(16, 180);
            rbCRLF.Name = "rbCRLF";
            rbCRLF.Size = new Size(83, 29);
            rbCRLF.TabIndex = 21;
            rbCRLF.Text = "CR-LF";
            rbCRLF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(rbNone);
            groupBox1.Controls.Add(rbLF);
            groupBox1.Controls.Add(rbCRLF);
            groupBox1.Controls.Add(rbCR);
            groupBox1.Controls.Add(rbSpace);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(379, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 224);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Znak końca linii";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 23;
            label2.Text = "Tekst:";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(120, 76);
            tbValue.Maximum = 1000;
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(351, 69);
            tbValue.TabIndex = 24;
            tbValue.Value = 1;
            tbValue.Scroll += tbValue_Scroll;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOutput.Location = new Point(10, 216);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(323, 54);
            lblOutput.TabIndex = 25;
            lblOutput.Text = "Dane wyjściowe";
            lblOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // tbTimer
            // 
            tbTimer.Location = new Point(120, 127);
            tbTimer.Minimum = 1;
            tbTimer.Name = "tbTimer";
            tbTimer.Size = new Size(351, 69);
            tbTimer.TabIndex = 26;
            tbTimer.Value = 1;
            tbTimer.Scroll += tbTimer_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 27;
            label3.Text = "Wartość:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(10, 127);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 28;
            label5.Text = "Na sekundę:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbLabels);
            panel1.Controls.Add(lblCounter);
            panel1.Controls.Add(lblTimer);
            panel1.Controls.Add(lblValue);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(lblOutput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(tbTimer);
            panel1.Controls.Add(tbValue);
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.Location = new Point(223, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 442);
            panel1.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 404);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 34;
            label6.Text = "Wysłano:";
            // 
            // cbLabels
            // 
            cbLabels.FormattingEnabled = true;
            cbLabels.Items.AddRange(new object[] { "Electricity:", "AElectricity:", "mAElectricity:", "MOMResistance:", "KOMResistance:", "OMResistance:", "OMbeep:", "VDiode:", "VDiode:", "nFCap:", "uFCap:", "mFCap:", "VVoltage:" });
            cbLabels.Location = new Point(133, 17);
            cbLabels.Name = "cbLabels";
            cbLabels.Size = new Size(321, 33);
            cbLabels.TabIndex = 33;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCounter.Location = new Point(101, 404);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(70, 25);
            lblCounter.TabIndex = 32;
            lblCounter.Text = "Licznik";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimer.Location = new Point(497, 127);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(22, 25);
            lblTimer.TabIndex = 31;
            lblTimer.Text = "1";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValue.Location = new Point(497, 76);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(22, 25);
            lblValue.TabIndex = 30;
            lblValue.Text = "1";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightGreen;
            btnStart.Enabled = false;
            btnStart.ForeColor = SystemColors.Desktop;
            btnStart.Location = new Point(10, 344);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 44);
            btnStart.TabIndex = 29;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 525);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btnMinimize);
            Controls.Add(label1);
            Controls.Add(btnCloseForm);
            Controls.Add(txtBaudRate);
            Controls.Add(lblBaudRate);
            Controls.Add(btnConnect);
            Controls.Add(lbCOMs);
            Controls.Add(btnListCOM);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.Manual;
            Text = "ZOYI Terminal";
            FormClosed += MainWindow_FormClosed;
            MouseDown += MainWindow_MouseDown;
            MouseMove += MainWindow_MouseMove;
            MouseUp += MainWindow_MouseUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTimer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox lbCOMs;
        private Button btnConnect;
        private Label lblBaudRate;
        private TextBox txtBaudRate;
        private Button btnCloseForm;
        private Label label1;
        private Button btnMinimize;
        private Label label4;
        private RadioButton rbNone;
        private RadioButton rbSpace;
        private RadioButton rbLF;
        private RadioButton rbCR;
        private RadioButton rbCRLF;
        private GroupBox groupBox1;
        private Label label2;
        private TrackBar tbValue;
        private Label lblOutput;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbTimer;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Button btnStart;
        private Label lblTimer;
        private Label lblValue;
        private Label lblCounter;
        private ComboBox cbLabels;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
