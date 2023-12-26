namespace wintest04
{
    partial class config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.comboBox_Stop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.button_BC = new System.Windows.Forms.Button();
            this.button_FC = new System.Windows.Forms.Button();
            this.button_Font = new System.Windows.Forms.Button();
            this.textBox_Fc_Blue = new System.Windows.Forms.TextBox();
            this.textBox_Fc_Green = new System.Windows.Forms.TextBox();
            this.textBox_Bc_Blue = new System.Windows.Forms.TextBox();
            this.textBox_Font = new System.Windows.Forms.TextBox();
            this.textBox_Fc_Red = new System.Windows.Forms.TextBox();
            this.textBox_Bc_Green = new System.Windows.Forms.TextBox();
            this.textBox_Bc_Red = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(250, 411);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
       
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 404);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.comboBox_Stop);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comboBox_Data);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.comboBox_Parity);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.comboBox_Baud);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.comboBox_Com);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(570, 378);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "포트설정";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // comboBox_Stop
            // 
            this.comboBox_Stop.FormattingEnabled = true;
            this.comboBox_Stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two"});
            this.comboBox_Stop.Location = new System.Drawing.Point(148, 180);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Stop.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stop bit";
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Items.AddRange(new object[] {
            "8",
            "7"});
            this.comboBox_Data.Location = new System.Drawing.Point(148, 148);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Data.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Bits";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark"});
            this.comboBox_Parity.Location = new System.Drawing.Point(148, 116);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Parity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parity";
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Items.AddRange(new object[] {
            "576000",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.comboBox_Baud.Location = new System.Drawing.Point(148, 84);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Baud.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.Location = new System.Drawing.Point(148, 52);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Com.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.button_BC);
            this.tab2.Controls.Add(this.button_FC);
            this.tab2.Controls.Add(this.button_Font);
            this.tab2.Controls.Add(this.textBox_Fc_Blue);
            this.tab2.Controls.Add(this.textBox_Fc_Green);
            this.tab2.Controls.Add(this.textBox_Bc_Blue);
            this.tab2.Controls.Add(this.textBox_Font);
            this.tab2.Controls.Add(this.textBox_Fc_Red);
            this.tab2.Controls.Add(this.textBox_Bc_Green);
            this.tab2.Controls.Add(this.textBox_Bc_Red);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(570, 378);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "환경설정";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // button_BC
            // 
            this.button_BC.Location = new System.Drawing.Point(521, 94);
            this.button_BC.Name = "button_BC";
            this.button_BC.Size = new System.Drawing.Size(32, 23);
            this.button_BC.TabIndex = 2;
            this.button_BC.Text = "...";
            this.button_BC.UseVisualStyleBackColor = true;
            // 
            // button_FC
            // 
            this.button_FC.Location = new System.Drawing.Point(521, 132);
            this.button_FC.Name = "button_FC";
            this.button_FC.Size = new System.Drawing.Size(32, 23);
            this.button_FC.TabIndex = 2;
            this.button_FC.Text = "...";
            this.button_FC.UseVisualStyleBackColor = true;
            // 
            // button_Font
            // 
            this.button_Font.Location = new System.Drawing.Point(521, 168);
            this.button_Font.Name = "button_Font";
            this.button_Font.Size = new System.Drawing.Size(32, 23);
            this.button_Font.TabIndex = 2;
            this.button_Font.Text = "...";
            this.button_Font.UseVisualStyleBackColor = true;
            // 
            // textBox_Fc_Blue
            // 
            this.textBox_Fc_Blue.Location = new System.Drawing.Point(415, 132);
            this.textBox_Fc_Blue.Name = "textBox_Fc_Blue";
            this.textBox_Fc_Blue.Size = new System.Drawing.Size(100, 21);
            this.textBox_Fc_Blue.TabIndex = 1;
            // 
            // textBox_Fc_Green
            // 
            this.textBox_Fc_Green.Location = new System.Drawing.Point(309, 132);
            this.textBox_Fc_Green.Name = "textBox_Fc_Green";
            this.textBox_Fc_Green.Size = new System.Drawing.Size(100, 21);
            this.textBox_Fc_Green.TabIndex = 1;
            // 
            // textBox_Bc_Blue
            // 
            this.textBox_Bc_Blue.Location = new System.Drawing.Point(415, 96);
            this.textBox_Bc_Blue.Name = "textBox_Bc_Blue";
            this.textBox_Bc_Blue.Size = new System.Drawing.Size(100, 21);
            this.textBox_Bc_Blue.TabIndex = 1;
            // 
            // textBox_Font
            // 
            this.textBox_Font.Location = new System.Drawing.Point(203, 168);
            this.textBox_Font.Name = "textBox_Font";
            this.textBox_Font.Size = new System.Drawing.Size(312, 21);
            this.textBox_Font.TabIndex = 1;
            // 
            // textBox_Fc_Red
            // 
            this.textBox_Fc_Red.Location = new System.Drawing.Point(203, 132);
            this.textBox_Fc_Red.Name = "textBox_Fc_Red";
            this.textBox_Fc_Red.Size = new System.Drawing.Size(100, 21);
            this.textBox_Fc_Red.TabIndex = 1;
            // 
            // textBox_Bc_Green
            // 
            this.textBox_Bc_Green.Location = new System.Drawing.Point(309, 96);
            this.textBox_Bc_Green.Name = "textBox_Bc_Green";
            this.textBox_Bc_Green.Size = new System.Drawing.Size(100, 21);
            this.textBox_Bc_Green.TabIndex = 1;
            // 
            // textBox_Bc_Red
            // 
            this.textBox_Bc_Red.Location = new System.Drawing.Point(203, 96);
            this.textBox_Bc_Red.Name = "textBox_Bc_Red";
            this.textBox_Bc_Red.Size = new System.Drawing.Size(100, 21);
            this.textBox_Bc_Red.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Font";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Font Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Blue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Green";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Red";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Back Color";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "config";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Fc_Blue;
        private System.Windows.Forms.TextBox textBox_Fc_Green;
        private System.Windows.Forms.TextBox textBox_Bc_Blue;
        private System.Windows.Forms.TextBox textBox_Font;
        private System.Windows.Forms.TextBox textBox_Fc_Red;
        private System.Windows.Forms.TextBox textBox_Bc_Green;
        private System.Windows.Forms.TextBox textBox_Bc_Red;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_BC;
        private System.Windows.Forms.Button button_FC;
        private System.Windows.Forms.Button button_Font;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.ComboBox comboBox_Stop;
        public System.Windows.Forms.ComboBox comboBox_Data;
        public System.Windows.Forms.ComboBox comboBox_Parity;
        public System.Windows.Forms.ComboBox comboBox_Baud;
        public System.Windows.Forms.ComboBox comboBox_Com;
    }
}