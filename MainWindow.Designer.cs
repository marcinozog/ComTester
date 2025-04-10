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
            button1 = new Button();
            label1 = new Label();
            btnMinimize = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            rbNull = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            tbValue = new TrackBar();
            lblOutput = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tbTimer = new TrackBar();
            label3 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTimer).BeginInit();
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
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(736, 12);
            button1.Name = "button1";
            button1.Size = new Size(51, 48);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(307, 12);
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
            label4.Text = "Wersja 0.1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 16;
            textBox1.Text = "KOMResistance:";
            // 
            // rbNull
            // 
            rbNull.AutoSize = true;
            rbNull.Checked = true;
            rbNull.Location = new Point(16, 36);
            rbNull.Name = "rbNull";
            rbNull.Size = new Size(72, 29);
            rbNull.TabIndex = 17;
            rbNull.TabStop = true;
            rbNull.Text = "brak";
            rbNull.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 29);
            radioButton2.TabIndex = 18;
            radioButton2.Text = "spacja";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 106);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 29);
            radioButton3.TabIndex = 19;
            radioButton3.Text = "LF";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(16, 143);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(59, 29);
            radioButton4.TabIndex = 20;
            radioButton4.Text = "CR";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 180);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 29);
            radioButton1.TabIndex = 21;
            radioButton1.Text = "LR+CF";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(rbNull);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(616, 77);
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
            label2.Location = new Point(239, 77);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 23;
            label2.Text = "Tekst:";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(436, 333);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(351, 69);
            tbValue.TabIndex = 24;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(11, 429);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(137, 25);
            lblOutput.TabIndex = 25;
            lblOutput.Text = "Dane wyjściowe";
            // 
            // tbTimer
            // 
            tbTimer.Location = new Point(436, 408);
            tbTimer.Maximum = 5;
            tbTimer.Minimum = 1;
            tbTimer.Name = "tbTimer";
            tbTimer.Size = new Size(351, 69);
            tbTimer.TabIndex = 26;
            tbTimer.Value = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(239, 333);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 27;
            label3.Text = "Wartość:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(239, 408);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 28;
            label5.Text = "Timer:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 525);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(tbTimer);
            Controls.Add(lblOutput);
            Controls.Add(tbValue);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(btnMinimize);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtBaudRate);
            Controls.Add(lblBaudRate);
            Controls.Add(btnConnect);
            Controls.Add(lbCOMs);
            Controls.Add(btnListCOM);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "ZOYI Terminal";
            FormClosed += MainWindow_FormClosed;
            MouseDown += MainWindow_MouseDown;
            MouseMove += MainWindow_MouseMove;
            MouseUp += MainWindow_MouseUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTimer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox lbCOMs;
        private Button btnConnect;
        private Label lblBaudRate;
        private TextBox txtBaudRate;
        private Button button1;
        private Label label1;
        private Button btnMinimize;
        private Label label4;
        private TextBox textBox1;
        private RadioButton rbNull;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private Label label2;
        private TrackBar tbValue;
        private Label lblOutput;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbTimer;
        private Label label3;
        private Label label5;
    }
}
