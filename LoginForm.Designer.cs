namespace Rezervace
{
    partial class Login
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
            this.LoginButton = new Rezervace.CustomControls.CustomButton();
            this.LoginTextBox = new Rezervace.CustomControls.CustomTextBox();
            this.PasswordTextBox = new Rezervace.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new Rezervace.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.Color.Plum;
            this.LoginButton.BackgroundColor = System.Drawing.Color.Plum;
            this.LoginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LoginButton.BorderRadius = 20;
            this.LoginButton.BorderSize = 0;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(203, 280);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 49);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LoginTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LoginTextBox.BorderSize = 5;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.ForeColor = System.Drawing.Color.White;
            this.LoginTextBox.Location = new System.Drawing.Point(40, 131);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Multiline = false;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Padding = new System.Windows.Forms.Padding(9);
            this.LoginTextBox.Password = false;
            this.LoginTextBox.Placeholder = "Login";
            this.LoginTextBox.Size = new System.Drawing.Size(301, 44);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginTextBox.UnderlinedStyle = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.PasswordTextBox.BorderSize = 5;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(40, 202);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(9);
            this.PasswordTextBox.Password = true;
            this.PasswordTextBox.Placeholder = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(301, 44);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Reservation Login";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RegisterButton.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.RegisterButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RegisterButton.BorderRadius = 20;
            this.RegisterButton.BorderSize = 0;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(40, 280);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(137, 49);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.TextColor = System.Drawing.Color.White;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(382, 364);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton LoginButton;
        private CustomControls.CustomTextBox LoginTextBox;
        private CustomControls.CustomTextBox PasswordTextBox;
        private Label label1;
        private CustomControls.CustomButton RegisterButton;
    }
}