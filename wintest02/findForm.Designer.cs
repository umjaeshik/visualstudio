namespace wintest02
{
    partial class findForm
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
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_replace = new System.Windows.Forms.TextBox();
            this.label_replace = new System.Windows.Forms.Label();
            this.button_replace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(123, 29);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(256, 21);
            this.textBox_find.TabIndex = 0;
            // 
            // button_find
            // 
            this.button_find.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_find.Location = new System.Drawing.Point(412, 29);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(124, 23);
            this.button_find.TabIndex = 1;
            this.button_find.Text = "찾기";
            this.button_find.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "찾을 내용 : ";
            // 
            // textBox_replace
            // 
            this.textBox_replace.Location = new System.Drawing.Point(123, 68);
            this.textBox_replace.Name = "textBox_replace";
            this.textBox_replace.Size = new System.Drawing.Size(256, 21);
            this.textBox_replace.TabIndex = 0;
            // 
            // label_replace
            // 
            this.label_replace.AutoSize = true;
            this.label_replace.Location = new System.Drawing.Point(52, 71);
            this.label_replace.Name = "label_replace";
            this.label_replace.Size = new System.Drawing.Size(65, 12);
            this.label_replace.TabIndex = 2;
            this.label_replace.Text = "바꿀 내용 :";
            // 
            // button_replace
            // 
            this.button_replace.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_replace.Location = new System.Drawing.Point(412, 66);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(124, 23);
            this.button_replace.TabIndex = 1;
            this.button_replace.Text = "바꾸기";
            this.button_replace.UseVisualStyleBackColor = true;
            // 
            // findForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 132);
            this.Controls.Add(this.label_replace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.textBox_replace);
            this.Controls.Add(this.textBox_find);
            this.Name = "findForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_find;
        public System.Windows.Forms.TextBox textBox_replace;
        private System.Windows.Forms.Label label_replace;
        private System.Windows.Forms.Button button_replace;
    }
}