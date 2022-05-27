namespace Rezervace.UserControls
{
    partial class ChangePassword
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
            this.CancelBttn = new Rezervace.CustomControls.CustomButton();
            this.ConfirmBttn = new Rezervace.CustomControls.CustomButton();
            this.NewPasswordAgainTextbox = new Rezervace.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPasswordTextbox = new Rezervace.CustomControls.CustomTextBox();
            this.OldPassword = new Rezervace.CustomControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // CancelBttn
            // 
            this.CancelBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBttn.BackColor = System.Drawing.Color.HotPink;
            this.CancelBttn.BackgroundColor = System.Drawing.Color.HotPink;
            this.CancelBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBttn.BorderRadius = 20;
            this.CancelBttn.BorderSize = 0;
            this.CancelBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBttn.FlatAppearance.BorderSize = 0;
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBttn.ForeColor = System.Drawing.Color.White;
            this.CancelBttn.Location = new System.Drawing.Point(37, 275);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(150, 40);
            this.CancelBttn.TabIndex = 15;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.TextColor = System.Drawing.Color.White;
            this.CancelBttn.UseVisualStyleBackColor = false;
            // 
            // ConfirmBttn
            // 
            this.ConfirmBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmBttn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ConfirmBttn.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.ConfirmBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ConfirmBttn.BorderRadius = 20;
            this.ConfirmBttn.BorderSize = 0;
            this.ConfirmBttn.FlatAppearance.BorderSize = 0;
            this.ConfirmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmBttn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBttn.Location = new System.Drawing.Point(200, 275);
            this.ConfirmBttn.Name = "ConfirmBttn";
            this.ConfirmBttn.Size = new System.Drawing.Size(150, 40);
            this.ConfirmBttn.TabIndex = 14;
            this.ConfirmBttn.Text = "Confirm";
            this.ConfirmBttn.TextColor = System.Drawing.Color.White;
            this.ConfirmBttn.UseVisualStyleBackColor = false;
            this.ConfirmBttn.Click += new System.EventHandler(this.ConfirmBttn_Click);
            // 
            // NewPasswordAgainTextbox
            // 
            this.NewPasswordAgainTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPasswordAgainTextbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NewPasswordAgainTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.NewPasswordAgainTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NewPasswordAgainTextbox.BorderSize = 5;
            this.NewPasswordAgainTextbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordAgainTextbox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordAgainTextbox.Location = new System.Drawing.Point(42, 195);
            this.NewPasswordAgainTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NewPasswordAgainTextbox.Multiline = false;
            this.NewPasswordAgainTextbox.Name = "NewPasswordAgainTextbox";
            this.NewPasswordAgainTextbox.Padding = new System.Windows.Forms.Padding(9);
            this.NewPasswordAgainTextbox.Password = true;
            this.NewPasswordAgainTextbox.Placeholder = "New Password again";
            this.NewPasswordAgainTextbox.Size = new System.Drawing.Size(301, 44);
            this.NewPasswordAgainTextbox.TabIndex = 12;
            this.NewPasswordAgainTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordAgainTextbox.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Change Password";
            // 
            // NewPasswordTextbox
            // 
            this.NewPasswordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPasswordTextbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NewPasswordTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.NewPasswordTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NewPasswordTextbox.BorderSize = 5;
            this.NewPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordTextbox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordTextbox.Location = new System.Drawing.Point(42, 127);
            this.NewPasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NewPasswordTextbox.Multiline = false;
            this.NewPasswordTextbox.Name = "NewPasswordTextbox";
            this.NewPasswordTextbox.Padding = new System.Windows.Forms.Padding(9);
            this.NewPasswordTextbox.Password = true;
            this.NewPasswordTextbox.Placeholder = "New Password";
            this.NewPasswordTextbox.Size = new System.Drawing.Size(301, 44);
            this.NewPasswordTextbox.TabIndex = 11;
            this.NewPasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordTextbox.UnderlinedStyle = true;
            // 
            // OldPassword
            // 
            this.OldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OldPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.OldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.OldPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.OldPassword.BorderSize = 5;
            this.OldPassword.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OldPassword.ForeColor = System.Drawing.Color.White;
            this.OldPassword.Location = new System.Drawing.Point(42, 61);
            this.OldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.OldPassword.Multiline = false;
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Padding = new System.Windows.Forms.Padding(9);
            this.OldPassword.Password = false;
            this.OldPassword.Placeholder = "Old Password";
            this.OldPassword.Size = new System.Drawing.Size(301, 44);
            this.OldPassword.TabIndex = 10;
            this.OldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldPassword.UnderlinedStyle = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(392, 343);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.ConfirmBttn);
            this.Controls.Add(this.NewPasswordAgainTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPasswordTextbox);
            this.Controls.Add(this.OldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton CancelBttn;
        private CustomControls.CustomButton ConfirmBttn;
        private CustomControls.CustomTextBox NewPasswordAgainTextbox;
        private Label label1;
        private CustomControls.CustomTextBox NewPasswordTextbox;
        private CustomControls.CustomTextBox OldPassword;
    }
}