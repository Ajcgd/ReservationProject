namespace Rezervace.AdminControls
{
    partial class AdminControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeUserPasswordBttn = new Rezervace.CustomControls.CustomButton();
            this.ListAllReservationsBttn = new Rezervace.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Control Panel";
            // 
            // ChangeUserPasswordBttn
            // 
            this.ChangeUserPasswordBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ChangeUserPasswordBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ChangeUserPasswordBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChangeUserPasswordBttn.BorderRadius = 30;
            this.ChangeUserPasswordBttn.BorderSize = 4;
            this.ChangeUserPasswordBttn.FlatAppearance.BorderSize = 0;
            this.ChangeUserPasswordBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUserPasswordBttn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeUserPasswordBttn.ForeColor = System.Drawing.Color.White;
            this.ChangeUserPasswordBttn.Location = new System.Drawing.Point(61, 92);
            this.ChangeUserPasswordBttn.Name = "ChangeUserPasswordBttn";
            this.ChangeUserPasswordBttn.Size = new System.Drawing.Size(239, 123);
            this.ChangeUserPasswordBttn.TabIndex = 13;
            this.ChangeUserPasswordBttn.Text = "Change User Password";
            this.ChangeUserPasswordBttn.TextColor = System.Drawing.Color.White;
            this.ChangeUserPasswordBttn.UseVisualStyleBackColor = false;
            this.ChangeUserPasswordBttn.Click += new System.EventHandler(this.ChangeUserPasswordBttn_Click);
            // 
            // ListAllReservationsBttn
            // 
            this.ListAllReservationsBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ListAllReservationsBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ListAllReservationsBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ListAllReservationsBttn.BorderRadius = 30;
            this.ListAllReservationsBttn.BorderSize = 4;
            this.ListAllReservationsBttn.FlatAppearance.BorderSize = 0;
            this.ListAllReservationsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAllReservationsBttn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListAllReservationsBttn.ForeColor = System.Drawing.Color.White;
            this.ListAllReservationsBttn.Location = new System.Drawing.Point(367, 92);
            this.ListAllReservationsBttn.Name = "ListAllReservationsBttn";
            this.ListAllReservationsBttn.Size = new System.Drawing.Size(239, 123);
            this.ListAllReservationsBttn.TabIndex = 14;
            this.ListAllReservationsBttn.Text = "Manage Reservations";
            this.ListAllReservationsBttn.TextColor = System.Drawing.Color.White;
            this.ListAllReservationsBttn.UseVisualStyleBackColor = false;
            this.ListAllReservationsBttn.Click += new System.EventHandler(this.ListAllReservationsBttn_Click);
            // 
            // AdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(686, 442);
            this.Controls.Add(this.ListAllReservationsBttn);
            this.Controls.Add(this.ChangeUserPasswordBttn);
            this.Controls.Add(this.label1);
            this.Name = "AdminControlPanel";
            this.Text = "AdminControlPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CustomControls.CustomButton ChangeUserPasswordBttn;
        private CustomControls.CustomButton ListAllReservationsBttn;
    }
}