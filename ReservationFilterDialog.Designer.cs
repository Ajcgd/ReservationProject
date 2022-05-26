namespace Rezervace
{
    partial class ReservationFilterDialog
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
            this.BackBttn = new Rezervace.CustomControls.CustomButton();
            this.ConfirmBttn = new Rezervace.CustomControls.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.FuelComboBox = new Rezervace.CustomControls.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinSeats = new Rezervace.CustomControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Model = new Rezervace.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new Rezervace.CustomControls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassComboBox = new Rezervace.CustomControls.CustomComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxSeats = new Rezervace.CustomControls.CustomTextBox();
            this.MinPrice = new Rezervace.CustomControls.CustomTextBox();
            this.MaxPrice = new Rezervace.CustomControls.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FromDatePicker = new Rezervace.CustomControls.CustomDatePicker();
            this.ToDatePicker = new Rezervace.CustomControls.CustomDatePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBttn
            // 
            this.BackBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBttn.BackColor = System.Drawing.Color.HotPink;
            this.BackBttn.BackgroundColor = System.Drawing.Color.HotPink;
            this.BackBttn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackBttn.BorderRadius = 20;
            this.BackBttn.BorderSize = 0;
            this.BackBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBttn.FlatAppearance.BorderSize = 0;
            this.BackBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBttn.ForeColor = System.Drawing.Color.White;
            this.BackBttn.Location = new System.Drawing.Point(205, 453);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(164, 53);
            this.BackBttn.TabIndex = 14;
            this.BackBttn.Text = "Back";
            this.BackBttn.TextColor = System.Drawing.Color.White;
            this.BackBttn.UseVisualStyleBackColor = false;
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
            this.ConfirmBttn.Location = new System.Drawing.Point(557, 453);
            this.ConfirmBttn.Name = "ConfirmBttn";
            this.ConfirmBttn.Size = new System.Drawing.Size(164, 53);
            this.ConfirmBttn.TabIndex = 13;
            this.ConfirmBttn.Text = "Confirm";
            this.ConfirmBttn.TextColor = System.Drawing.Color.White;
            this.ConfirmBttn.UseVisualStyleBackColor = false;
            this.ConfirmBttn.Click += new System.EventHandler(this.ConfirmBttn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(532, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fuel Type";
            // 
            // FuelComboBox
            // 
            this.FuelComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            "Gas",
            "Electric"});
            this.FuelComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.FuelComboBox.ListTextColor = System.Drawing.Color.White;
            this.FuelComboBox.Location = new System.Drawing.Point(694, 71);
            this.FuelComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.FuelComboBox.Name = "FuelComboBox";
            this.FuelComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.FuelComboBox.Size = new System.Drawing.Size(200, 30);
            this.FuelComboBox.TabIndex = 24;
            this.FuelComboBox.Texts = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(375, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "Filter Vehicles";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of seats";
            // 
            // MinSeats
            // 
            this.MinSeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinSeats.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MinSeats.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MinSeats.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MinSeats.BorderSize = 5;
            this.MinSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinSeats.ForeColor = System.Drawing.Color.White;
            this.MinSeats.Location = new System.Drawing.Point(132, 272);
            this.MinSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinSeats.Multiline = false;
            this.MinSeats.Name = "MinSeats";
            this.MinSeats.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinSeats.Password = false;
            this.MinSeats.Placeholder = "";
            this.MinSeats.Size = new System.Drawing.Size(139, 38);
            this.MinSeats.TabIndex = 19;
            this.MinSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinSeats.UnderlinedStyle = true;
            this.MinSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeatsNum_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 18;
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
            this.Model.Location = new System.Drawing.Point(177, 146);
            this.Model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Model.Multiline = false;
            this.Model.Name = "Model";
            this.Model.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Model.Password = false;
            this.Model.Placeholder = "";
            this.Model.Size = new System.Drawing.Size(316, 38);
            this.Model.TabIndex = 17;
            this.Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Model.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 16;
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
            this.Brand.Location = new System.Drawing.Point(177, 63);
            this.Brand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brand.Multiline = false;
            this.Brand.Name = "Brand";
            this.Brand.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Brand.Password = false;
            this.Brand.Placeholder = "";
            this.Brand.Size = new System.Drawing.Size(316, 38);
            this.Brand.TabIndex = 15;
            this.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Brand.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(557, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Class";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassComboBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClassComboBox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClassComboBox.BorderSize = 2;
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ClassComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassComboBox.ForeColor = System.Drawing.Color.White;
            this.ClassComboBox.IconColor = System.Drawing.Color.PaleVioletRed;
            this.ClassComboBox.Items.AddRange(new object[] {
            "Premium",
            "Business",
            "Economy"});
            this.ClassComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClassComboBox.ListTextColor = System.Drawing.Color.White;
            this.ClassComboBox.Location = new System.Drawing.Point(694, 154);
            this.ClassComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.ClassComboBox.Size = new System.Drawing.Size(200, 30);
            this.ClassComboBox.TabIndex = 26;
            this.ClassComboBox.Texts = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(222, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price per day";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(310, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "Max";
            // 
            // MaxSeats
            // 
            this.MaxSeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxSeats.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MaxSeats.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MaxSeats.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MaxSeats.BorderSize = 5;
            this.MaxSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxSeats.ForeColor = System.Drawing.Color.White;
            this.MaxSeats.Location = new System.Drawing.Point(375, 272);
            this.MaxSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxSeats.Multiline = false;
            this.MaxSeats.Name = "MaxSeats";
            this.MaxSeats.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaxSeats.Password = false;
            this.MaxSeats.Placeholder = "";
            this.MaxSeats.Size = new System.Drawing.Size(139, 38);
            this.MaxSeats.TabIndex = 32;
            this.MaxSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxSeats.UnderlinedStyle = true;
            // 
            // MinPrice
            // 
            this.MinPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinPrice.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MinPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MinPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MinPrice.BorderSize = 5;
            this.MinPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinPrice.ForeColor = System.Drawing.Color.White;
            this.MinPrice.Location = new System.Drawing.Point(132, 380);
            this.MinPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinPrice.Multiline = false;
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinPrice.Password = false;
            this.MinPrice.Placeholder = "";
            this.MinPrice.Size = new System.Drawing.Size(139, 38);
            this.MinPrice.TabIndex = 33;
            this.MinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinPrice.UnderlinedStyle = true;
            // 
            // MaxPrice
            // 
            this.MaxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxPrice.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MaxPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MaxPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MaxPrice.BorderSize = 5;
            this.MaxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxPrice.ForeColor = System.Drawing.Color.White;
            this.MaxPrice.Location = new System.Drawing.Point(375, 380);
            this.MaxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxPrice.Multiline = false;
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaxPrice.Password = false;
            this.MaxPrice.Placeholder = "";
            this.MaxPrice.Size = new System.Drawing.Size(139, 38);
            this.MaxPrice.TabIndex = 34;
            this.MaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxPrice.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(57, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "Min";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(310, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 32);
            this.label11.TabIndex = 36;
            this.label11.Text = "Max";
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FromDatePicker.BorderSize = 0;
            this.FromDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromDatePicker.Location = new System.Drawing.Point(694, 272);
            this.FromDatePicker.MinimumSize = new System.Drawing.Size(0, 35);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(200, 35);
            this.FromDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.FromDatePicker.TabIndex = 37;
            this.FromDatePicker.TextColor = System.Drawing.Color.White;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ToDatePicker.BorderSize = 0;
            this.ToDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDatePicker.Location = new System.Drawing.Point(694, 380);
            this.ToDatePicker.MinimumSize = new System.Drawing.Size(0, 35);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(200, 35);
            this.ToDatePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.ToDatePicker.TabIndex = 38;
            this.ToDatePicker.TextColor = System.Drawing.Color.White;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(557, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 32);
            this.label12.TabIndex = 39;
            this.label12.Text = "From";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(557, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 32);
            this.label13.TabIndex = 40;
            this.label13.Text = "To";
            // 
            // ReservationFilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(921, 527);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.MaxSeats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FuelComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.BackBttn);
            this.Controls.Add(this.ConfirmBttn);
            this.Name = "ReservationFilterDialog";
            this.Text = "CreateReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton BackBttn;
        private CustomControls.CustomButton ConfirmBttn;
        private Label label6;
        private CustomControls.CustomComboBox FuelComboBox;
        private Label label4;
        private Label label3;
        private CustomControls.CustomTextBox MinSeats;
        private Label label2;
        private CustomControls.CustomTextBox Model;
        private Label label1;
        private CustomControls.CustomTextBox Brand;
        private Label label5;
        private CustomControls.CustomComboBox ClassComboBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private CustomControls.CustomTextBox MaxSeats;
        private CustomControls.CustomTextBox MinPrice;
        private CustomControls.CustomTextBox MaxPrice;
        private Label label10;
        private Label label11;
        private CustomControls.CustomDatePicker FromDatePicker;
        private CustomControls.CustomDatePicker ToDatePicker;
        private Label label12;
        private Label label13;
    }
}