namespace Rezervace
{
    partial class ModifyVehicleDialog
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
            this.ConfitmBttn = new Rezervace.CustomControls.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.FuelComboBox = new Rezervace.CustomControls.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeatsNum = new Rezervace.CustomControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Model = new Rezervace.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new Rezervace.CustomControls.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassComboBox = new Rezervace.CustomControls.CustomComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PricePerDay = new Rezervace.CustomControls.CustomTextBox();
            this.DeleteBttn = new Rezervace.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // CancelBttn
            // 
            this.CancelBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBttn.BackColor = System.Drawing.Color.Orange;
            this.CancelBttn.BackgroundColor = System.Drawing.Color.Orange;
            this.CancelBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBttn.BorderRadius = 20;
            this.CancelBttn.BorderSize = 0;
            this.CancelBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBttn.FlatAppearance.BorderSize = 0;
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBttn.ForeColor = System.Drawing.Color.White;
            this.CancelBttn.Location = new System.Drawing.Point(84, 426);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(150, 40);
            this.CancelBttn.TabIndex = 25;
            this.CancelBttn.Text = "Discard changes";
            this.CancelBttn.TextColor = System.Drawing.Color.White;
            this.CancelBttn.UseVisualStyleBackColor = false;
            // 
            // ConfitmBttn
            // 
            this.ConfitmBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfitmBttn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ConfitmBttn.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.ConfitmBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ConfitmBttn.BorderRadius = 20;
            this.ConfitmBttn.BorderSize = 0;
            this.ConfitmBttn.FlatAppearance.BorderSize = 0;
            this.ConfitmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfitmBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfitmBttn.ForeColor = System.Drawing.Color.White;
            this.ConfitmBttn.Location = new System.Drawing.Point(562, 426);
            this.ConfitmBttn.Name = "ConfitmBttn";
            this.ConfitmBttn.Size = new System.Drawing.Size(150, 40);
            this.ConfitmBttn.TabIndex = 24;
            this.ConfitmBttn.Text = "Confirm";
            this.ConfitmBttn.TextColor = System.Drawing.Color.White;
            this.ConfitmBttn.UseVisualStyleBackColor = false;
            this.ConfitmBttn.Click += new System.EventHandler(this.ConfirmBttnC_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(430, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fule Type";
            // 
            // FuelComboBox
            // 
            this.FuelComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FuelComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Electric",
            "Diesel",
            "Benzin",
            "Gas"});
            this.FuelComboBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.FuelComboBox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FuelComboBox.BorderSize = 2;
            this.FuelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FuelComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FuelComboBox.ForeColor = System.Drawing.Color.White;
            this.FuelComboBox.IconColor = System.Drawing.Color.PaleVioletRed;
            this.FuelComboBox.Items.AddRange(new object[] {
            "Diesel",
            "Benzin",
            "Electric",
            "Gas"});
            this.FuelComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.FuelComboBox.ListTextColor = System.Drawing.Color.White;
            this.FuelComboBox.Location = new System.Drawing.Point(562, 204);
            this.FuelComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.FuelComboBox.Name = "FuelComboBox";
            this.FuelComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.FuelComboBox.Size = new System.Drawing.Size(200, 30);
            this.FuelComboBox.TabIndex = 22;
            this.FuelComboBox.Texts = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seats number";
            // 
            // SeatsNum
            // 
            this.SeatsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SeatsNum.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SeatsNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.SeatsNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.SeatsNum.BorderSize = 5;
            this.SeatsNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeatsNum.ForeColor = System.Drawing.Color.White;
            this.SeatsNum.Location = new System.Drawing.Point(182, 258);
            this.SeatsNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeatsNum.Multiline = false;
            this.SeatsNum.Name = "SeatsNum";
            this.SeatsNum.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.SeatsNum.Password = false;
            this.SeatsNum.Placeholder = "";
            this.SeatsNum.Size = new System.Drawing.Size(224, 38);
            this.SeatsNum.TabIndex = 17;
            this.SeatsNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SeatsNum.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Model";
            // 
            // Model
            // 
            this.Model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Model.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Model.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Model.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Model.BorderSize = 5;
            this.Model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Model.ForeColor = System.Drawing.Color.White;
            this.Model.Location = new System.Drawing.Point(182, 183);
            this.Model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Model.Multiline = false;
            this.Model.Name = "Model";
            this.Model.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Model.Password = false;
            this.Model.Placeholder = "";
            this.Model.Size = new System.Drawing.Size(224, 38);
            this.Model.TabIndex = 15;
            this.Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Model.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Brand";
            // 
            // Brand
            // 
            this.Brand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Brand.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Brand.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Brand.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Brand.BorderSize = 5;
            this.Brand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Brand.ForeColor = System.Drawing.Color.White;
            this.Brand.Location = new System.Drawing.Point(182, 112);
            this.Brand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brand.Multiline = false;
            this.Brand.Name = "Brand";
            this.Brand.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Brand.Password = false;
            this.Brand.Placeholder = "";
            this.Brand.Size = new System.Drawing.Size(224, 38);
            this.Brand.TabIndex = 13;
            this.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Brand.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(288, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vehicle details";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(449, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Class";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Economy",
            "Business",
            "Premium"});
            this.ClassComboBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClassComboBox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClassComboBox.BorderSize = 2;
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ClassComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassComboBox.ForeColor = System.Drawing.Color.White;
            this.ClassComboBox.IconColor = System.Drawing.Color.PaleVioletRed;
            this.ClassComboBox.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "Premium"});
            this.ClassComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClassComboBox.ListTextColor = System.Drawing.Color.White;
            this.ClassComboBox.Location = new System.Drawing.Point(562, 275);
            this.ClassComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.ClassComboBox.Size = new System.Drawing.Size(200, 30);
            this.ClassComboBox.TabIndex = 27;
            this.ClassComboBox.Texts = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Price per day";
            // 
            // PricePerDay
            // 
            this.PricePerDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PricePerDay.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.PricePerDay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.PricePerDay.BorderFocusColor = System.Drawing.Color.HotPink;
            this.PricePerDay.BorderSize = 5;
            this.PricePerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PricePerDay.ForeColor = System.Drawing.Color.White;
            this.PricePerDay.Location = new System.Drawing.Point(182, 336);
            this.PricePerDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PricePerDay.Multiline = false;
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.PricePerDay.Password = false;
            this.PricePerDay.Placeholder = "";
            this.PricePerDay.Size = new System.Drawing.Size(224, 38);
            this.PricePerDay.TabIndex = 29;
            this.PricePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PricePerDay.UnderlinedStyle = true;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBttn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBttn.BackgroundColor = System.Drawing.Color.Crimson;
            this.DeleteBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteBttn.BorderRadius = 20;
            this.DeleteBttn.BorderSize = 0;
            this.DeleteBttn.FlatAppearance.BorderSize = 0;
            this.DeleteBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBttn.ForeColor = System.Drawing.Color.White;
            this.DeleteBttn.Location = new System.Drawing.Point(324, 426);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(150, 40);
            this.DeleteBttn.TabIndex = 31;
            this.DeleteBttn.Text = "Delete";
            this.DeleteBttn.TextColor = System.Drawing.Color.White;
            this.DeleteBttn.UseVisualStyleBackColor = false;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifyVehicleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(787, 498);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PricePerDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.ConfitmBttn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FuelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SeatsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Name = "ModifyVehicleDialog";
            this.Text = "ModifyVehicleDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton CancelBttn;
        private CustomControls.CustomButton ConfitmBttn;
        private Label label6;
        private CustomControls.CustomComboBox FuelComboBox;
        private Label label3;
        private CustomControls.CustomTextBox SeatsNum;
        private Label label2;
        private CustomControls.CustomTextBox Model;
        private Label label1;
        private CustomControls.CustomTextBox Brand;
        private Label label7;
        private Label label5;
        private CustomControls.CustomComboBox ClassComboBox;
        private Label label8;
        private CustomControls.CustomTextBox PricePerDay;
        private CustomControls.CustomButton DeleteBttn;
    }
}