namespace Rezervace
{
    partial class ReservationDetailDialog
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
            this.CarName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteBttn = new Rezervace.CustomControls.CustomButton();
            this.OkBttn = new Rezervace.CustomControls.CustomButton();
            this.Price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarName
            // 
            this.CarName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarName.AutoSize = true;
            this.CarName.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarName.ForeColor = System.Drawing.Color.White;
            this.CarName.Location = new System.Drawing.Point(249, 89);
            this.CarName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(122, 35);
            this.CarName.TabIndex = 29;
            this.CarName.Text = "car_name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 35);
            this.label8.TabIndex = 28;
            this.label8.Text = "Car";
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBttn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBttn.BackgroundColor = System.Drawing.Color.Crimson;
            this.DeleteBttn.BorderColor = System.Drawing.Color.HotPink;
            this.DeleteBttn.BorderRadius = 20;
            this.DeleteBttn.BorderSize = 0;
            this.DeleteBttn.FlatAppearance.BorderSize = 0;
            this.DeleteBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBttn.ForeColor = System.Drawing.Color.White;
            this.DeleteBttn.Location = new System.Drawing.Point(51, 338);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(141, 38);
            this.DeleteBttn.TabIndex = 27;
            this.DeleteBttn.Text = "Delete";
            this.DeleteBttn.TextColor = System.Drawing.Color.White;
            this.DeleteBttn.UseVisualStyleBackColor = false;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // OkBttn
            // 
            this.OkBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkBttn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.OkBttn.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.OkBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.OkBttn.BorderRadius = 20;
            this.OkBttn.BorderSize = 0;
            this.OkBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkBttn.FlatAppearance.BorderSize = 0;
            this.OkBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkBttn.ForeColor = System.Drawing.Color.White;
            this.OkBttn.Location = new System.Drawing.Point(226, 338);
            this.OkBttn.Name = "OkBttn";
            this.OkBttn.Size = new System.Drawing.Size(141, 38);
            this.OkBttn.TabIndex = 26;
            this.OkBttn.Text = "Confirm";
            this.OkBttn.TextColor = System.Drawing.Color.White;
            this.OkBttn.UseVisualStyleBackColor = false;
            // 
            // Price
            // 
            this.Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.Location = new System.Drawing.Point(249, 272);
            this.Price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(71, 35);
            this.Price.TabIndex = 25;
            this.Price.Text = "price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 45);
            this.label6.TabIndex = 24;
            this.label6.Text = "Summary";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 35);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price";
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndDate.ForeColor = System.Drawing.Color.White;
            this.EndDate.Location = new System.Drawing.Point(249, 211);
            this.EndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(118, 35);
            this.EndDate.TabIndex = 22;
            this.EndDate.Text = "end_date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "End date";
            // 
            // StartDate
            // 
            this.StartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartDate.ForeColor = System.Drawing.Color.White;
            this.StartDate.Location = new System.Drawing.Point(249, 146);
            this.StartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(127, 35);
            this.StartDate.TabIndex = 20;
            this.StartDate.Text = "start_date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Start date";
            // 
            // ReservationDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(425, 418);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.OkBttn);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label1);
            this.Name = "ReservationDetailDialog";
            this.Text = "ReservationDetailDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CarName;
        private Label label8;
        private CustomControls.CustomButton DeleteBttn;
        private CustomControls.CustomButton OkBttn;
        private Label Price;
        private Label label6;
        private Label label5;
        private Label EndDate;
        private Label label3;
        private Label StartDate;
        private Label label1;
    }
}