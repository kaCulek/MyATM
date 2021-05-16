namespace MyATM
{
    partial class Login
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
            this.pinInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.creditCardNumberInput = new System.Windows.Forms.TextBox();
            this.errorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pinInput
            // 
            this.pinInput.Location = new System.Drawing.Point(120, 52);
            this.pinInput.MaxLength = 4;
            this.pinInput.Name = "pinInput";
            this.pinInput.PasswordChar = '*';
            this.pinInput.Size = new System.Drawing.Size(202, 20);
            this.pinInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter PIN:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(120, 88);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Credit card numver:";
            // 
            // creditCardNumberInput
            // 
            this.creditCardNumberInput.Location = new System.Drawing.Point(120, 29);
            this.creditCardNumberInput.MaxLength = 19;
            this.creditCardNumberInput.Name = "creditCardNumberInput";
            this.creditCardNumberInput.Size = new System.Drawing.Size(202, 20);
            this.creditCardNumberInput.TabIndex = 4;
            // 
            // errorInfo
            // 
            this.errorInfo.AutoSize = true;
            this.errorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.errorInfo.ForeColor = System.Drawing.Color.Red;
            this.errorInfo.Location = new System.Drawing.Point(120, 118);
            this.errorInfo.Name = "errorInfo";
            this.errorInfo.Size = new System.Drawing.Size(0, 13);
            this.errorInfo.TabIndex = 5;
            this.errorInfo.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 135);
            this.Controls.Add(this.errorInfo);
            this.Controls.Add(this.creditCardNumberInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinInput);
            this.Name = "Login";
            this.Text = "Enter valid credit card and pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditCardNumberInput;
        private System.Windows.Forms.Label errorInfo;
    }
}

