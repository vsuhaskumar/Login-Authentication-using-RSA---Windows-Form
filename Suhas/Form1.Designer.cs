namespace Suhas
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.UValid = new System.Windows.Forms.Label();
            this.PValid = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(259, 53);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(215, 22);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(259, 116);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(215, 22);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(95, 57);
            this.userlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(75, 17);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "UserName";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Location = new System.Drawing.Point(95, 124);
            this.Passlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(69, 17);
            this.Passlabel.TabIndex = 3;
            this.Passlabel.Text = "Password";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(259, 185);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 28);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // UValid
            // 
            this.UValid.AutoSize = true;
            this.UValid.Location = new System.Drawing.Point(512, 60);
            this.UValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UValid.Name = "UValid";
            this.UValid.Size = new System.Drawing.Size(0, 17);
            this.UValid.TabIndex = 5;
            // 
            // PValid
            // 
            this.PValid.AutoSize = true;
            this.PValid.Location = new System.Drawing.Point(516, 123);
            this.PValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PValid.Name = "PValid";
            this.PValid.Size = new System.Drawing.Size(0, 17);
            this.PValid.TabIndex = 6;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(95, 247);
            this.HelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(37, 17);
            this.HelpLabel.TabIndex = 7;
            this.HelpLabel.TabStop = true;
            this.HelpLabel.Text = "Help";
            this.HelpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.PValid);
            this.Controls.Add(this.UValid);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label UValid;
        private System.Windows.Forms.Label PValid;
        private System.Windows.Forms.LinkLabel HelpLabel;
    }
}

