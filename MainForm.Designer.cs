namespace Rezervace
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserIcon = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.UserDetailsBttn = new Rezervace.CustomControls.CustomButton();
            this.DisplayReservationsBttn = new Rezervace.CustomControls.CustomButton();
            this.DisplayVehiclesBttn = new Rezervace.CustomControls.CustomButton();
            this.CreateReservationBttn = new Rezervace.CustomControls.CustomButton();
            this.SystemControl = new Rezervace.CustomControls.CustomButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIcon
            // 
            this.UserIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIcon.AutoSize = true;
            this.UserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserIcon.ForeColor = System.Drawing.Color.White;
            this.UserIcon.Location = new System.Drawing.Point(695, 9);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(47, 32);
            this.UserIcon.TabIndex = 6;
            this.UserIcon.Text = "👤";
            this.UserIcon.Click += new System.EventHandler(this.ModifyUserData);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.UsernameLabel, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(371, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 31);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(222, 3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(97, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.ModifyUserData);
            // 
            // ExitIcon
            // 
            this.ExitIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitIcon.BackgroundImage")));
            this.ExitIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.ImageLocation = "";
            this.ExitIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("ExitIcon.InitialImage")));
            this.ExitIcon.Location = new System.Drawing.Point(748, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(31, 31);
            this.ExitIcon.TabIndex = 8;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // UserDetailsBttn
            // 
            this.UserDetailsBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserDetailsBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.UserDetailsBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.UserDetailsBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UserDetailsBttn.BorderRadius = 30;
            this.UserDetailsBttn.BorderSize = 4;
            this.UserDetailsBttn.FlatAppearance.BorderSize = 0;
            this.UserDetailsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDetailsBttn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserDetailsBttn.ForeColor = System.Drawing.Color.White;
            this.UserDetailsBttn.Location = new System.Drawing.Point(454, 71);
            this.UserDetailsBttn.Name = "UserDetailsBttn";
            this.UserDetailsBttn.Size = new System.Drawing.Size(239, 123);
            this.UserDetailsBttn.TabIndex = 10;
            this.UserDetailsBttn.Text = "User Details";
            this.UserDetailsBttn.TextColor = System.Drawing.Color.White;
            this.UserDetailsBttn.UseVisualStyleBackColor = false;
            this.UserDetailsBttn.Click += new System.EventHandler(this.ModifyUserData);
            // 
            // DisplayReservationsBttn
            // 
            this.DisplayReservationsBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayReservationsBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayReservationsBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayReservationsBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DisplayReservationsBttn.BorderRadius = 30;
            this.DisplayReservationsBttn.BorderSize = 4;
            this.DisplayReservationsBttn.FlatAppearance.BorderSize = 0;
            this.DisplayReservationsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayReservationsBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayReservationsBttn.ForeColor = System.Drawing.Color.White;
            this.DisplayReservationsBttn.Location = new System.Drawing.Point(454, 246);
            this.DisplayReservationsBttn.Name = "DisplayReservationsBttn";
            this.DisplayReservationsBttn.Size = new System.Drawing.Size(239, 123);
            this.DisplayReservationsBttn.TabIndex = 11;
            this.DisplayReservationsBttn.Text = "Display reservations";
            this.DisplayReservationsBttn.TextColor = System.Drawing.Color.White;
            this.DisplayReservationsBttn.UseVisualStyleBackColor = false;
            this.DisplayReservationsBttn.Click += new System.EventHandler(this.DisplayReservationsBttn_Click);
            // 
            // DisplayVehiclesBttn
            // 
            this.DisplayVehiclesBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayVehiclesBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayVehiclesBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayVehiclesBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DisplayVehiclesBttn.BorderRadius = 30;
            this.DisplayVehiclesBttn.BorderSize = 4;
            this.DisplayVehiclesBttn.FlatAppearance.BorderSize = 0;
            this.DisplayVehiclesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayVehiclesBttn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayVehiclesBttn.ForeColor = System.Drawing.Color.White;
            this.DisplayVehiclesBttn.Location = new System.Drawing.Point(91, 71);
            this.DisplayVehiclesBttn.Name = "DisplayVehiclesBttn";
            this.DisplayVehiclesBttn.Size = new System.Drawing.Size(239, 123);
            this.DisplayVehiclesBttn.TabIndex = 12;
            this.DisplayVehiclesBttn.Text = "Display Vehicles";
            this.DisplayVehiclesBttn.TextColor = System.Drawing.Color.White;
            this.DisplayVehiclesBttn.UseVisualStyleBackColor = false;
            this.DisplayVehiclesBttn.Click += new System.EventHandler(this.DisplayVehiclesBttn_Click);
            // 
            // CreateReservationBttn
            // 
            this.CreateReservationBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateReservationBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateReservationBttn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateReservationBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateReservationBttn.BorderRadius = 30;
            this.CreateReservationBttn.BorderSize = 4;
            this.CreateReservationBttn.FlatAppearance.BorderSize = 0;
            this.CreateReservationBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateReservationBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateReservationBttn.ForeColor = System.Drawing.Color.White;
            this.CreateReservationBttn.Location = new System.Drawing.Point(91, 246);
            this.CreateReservationBttn.Name = "CreateReservationBttn";
            this.CreateReservationBttn.Size = new System.Drawing.Size(239, 123);
            this.CreateReservationBttn.TabIndex = 13;
            this.CreateReservationBttn.Text = "Create Reservation";
            this.CreateReservationBttn.TextColor = System.Drawing.Color.White;
            this.CreateReservationBttn.UseVisualStyleBackColor = false;
            this.CreateReservationBttn.Click += new System.EventHandler(this.CreateReservationBttn_Click);
            // 
            // SystemControl
            // 
            this.SystemControl.BackColor = System.Drawing.Color.Crimson;
            this.SystemControl.BackgroundColor = System.Drawing.Color.Crimson;
            this.SystemControl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SystemControl.BorderRadius = 10;
            this.SystemControl.BorderSize = 0;
            this.SystemControl.FlatAppearance.BorderSize = 0;
            this.SystemControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemControl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SystemControl.ForeColor = System.Drawing.Color.White;
            this.SystemControl.Location = new System.Drawing.Point(91, 7);
            this.SystemControl.Name = "SystemControl";
            this.SystemControl.Size = new System.Drawing.Size(239, 40);
            this.SystemControl.TabIndex = 14;
            this.SystemControl.Text = "System Control";
            this.SystemControl.TextColor = System.Drawing.Color.White;
            this.SystemControl.UseVisualStyleBackColor = false;
            this.SystemControl.Click += new System.EventHandler(this.AdminControls_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SystemControl);
            this.Controls.Add(this.CreateReservationBttn);
            this.Controls.Add(this.DisplayVehiclesBttn);
            this.Controls.Add(this.DisplayReservationsBttn);
            this.Controls.Add(this.UserDetailsBttn);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UserIcon);
            this.Name = "MainForm";
            this.Text = "ReservationApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserIcon;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ExitIcon;
        private Label UsernameLabel;
        private CustomControls.CustomButton UserDetailsBttn;
        private CustomControls.CustomButton DisplayReservationsBttn;
        private CustomControls.CustomButton DisplayVehiclesBttn;
        private CustomControls.CustomButton CreateReservationBttn;
        private CustomControls.CustomButton SystemControl;
    }
}