namespace ReservationApplicationMolveno
{
    partial class ReservationForm
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
            this.components = new System.ComponentModel.Container();
            this.labelDateReservation = new System.Windows.Forms.TextBox();
            this.labelNameGuest = new System.Windows.Forms.TextBox();
            this.labelNumberOfGuests = new System.Windows.Forms.TextBox();
            this.labelBeginTime = new System.Windows.Forms.TextBox();
            this.labelGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelGuestEmail = new System.Windows.Forms.TextBox();
            this.labelCommentsGuest = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_NameGuest = new System.Windows.Forms.TextBox();
            this.txt_GuestPhonenumber = new System.Windows.Forms.TextBox();
            this.txt_GuestEmail = new System.Windows.Forms.TextBox();
            this.inputCommentGuest = new System.Windows.Forms.TextBox();
            this.inputOptionHidePrices = new System.Windows.Forms.CheckBox();
            this.labelOptionHidePrices = new System.Windows.Forms.TextBox();
            this.cmb_Hours = new System.Windows.Forms.ComboBox();
            this.cmb_Minutes = new System.Windows.Forms.ComboBox();
            this.labelCommentOwner = new System.Windows.Forms.TextBox();
            this.dtp_arrivingDate = new System.Windows.Forms.DateTimePicker();
            this.nud_numberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.bt_reserve = new System.Windows.Forms.Button();
            this.bt_ViewReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateReservation
            // 
            this.labelDateReservation.BackColor = System.Drawing.SystemColors.Control;
            this.labelDateReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDateReservation.Location = new System.Drawing.Point(66, 79);
            this.labelDateReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelDateReservation.Name = "labelDateReservation";
            this.labelDateReservation.Size = new System.Drawing.Size(129, 19);
            this.labelDateReservation.TabIndex = 0;
            this.labelDateReservation.Text = "Date";
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameGuest.Location = new System.Drawing.Point(66, 114);
            this.labelNameGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(129, 19);
            this.labelNameGuest.TabIndex = 1;
            this.labelNameGuest.Text = "Name";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(66, 149);
            this.labelNumberOfGuests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(129, 19);
            this.labelNumberOfGuests.TabIndex = 2;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelBeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBeginTime.Location = new System.Drawing.Point(66, 186);
            this.labelBeginTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(129, 19);
            this.labelBeginTime.TabIndex = 3;
            this.labelBeginTime.Text = "Reservation time";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(66, 222);
            this.labelGuestPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(129, 19);
            this.labelGuestPhoneNumber.TabIndex = 4;
            this.labelGuestPhoneNumber.Text = "Phonenumber";
            // 
            // labelGuestEmail
            // 
            this.labelGuestEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestEmail.Location = new System.Drawing.Point(66, 259);
            this.labelGuestEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelGuestEmail.Name = "labelGuestEmail";
            this.labelGuestEmail.Size = new System.Drawing.Size(129, 19);
            this.labelGuestEmail.TabIndex = 5;
            this.labelGuestEmail.Text = "Email address";
            // 
            // labelCommentsGuest
            // 
            this.labelCommentsGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentsGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentsGuest.Location = new System.Drawing.Point(66, 351);
            this.labelCommentsGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCommentsGuest.Name = "labelCommentsGuest";
            this.labelCommentsGuest.Size = new System.Drawing.Size(129, 19);
            this.labelCommentsGuest.TabIndex = 6;
            this.labelCommentsGuest.Text = "Comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_NameGuest
            // 
            this.txt_NameGuest.Location = new System.Drawing.Point(231, 114);
            this.txt_NameGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameGuest.MaxLength = 25;
            this.txt_NameGuest.Name = "txt_NameGuest";
            this.txt_NameGuest.Size = new System.Drawing.Size(130, 26);
            this.txt_NameGuest.TabIndex = 9;
            this.txt_NameGuest.TextChanged += new System.EventHandler(this.inputNameGuest_TextChanged);
            this.txt_NameGuest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NameGuest_KeyPress);
            // 
            // txt_GuestPhonenumber
            // 
            this.txt_GuestPhonenumber.Location = new System.Drawing.Point(231, 222);
            this.txt_GuestPhonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GuestPhonenumber.MaxLength = 12;
            this.txt_GuestPhonenumber.Name = "txt_GuestPhonenumber";
            this.txt_GuestPhonenumber.Size = new System.Drawing.Size(130, 26);
            this.txt_GuestPhonenumber.TabIndex = 10;
            this.txt_GuestPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputGuestPhoneNumber_KeyPress);
            // 
            // txt_GuestEmail
            // 
            this.txt_GuestEmail.Location = new System.Drawing.Point(231, 259);
            this.txt_GuestEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GuestEmail.MaxLength = 40;
            this.txt_GuestEmail.Name = "txt_GuestEmail";
            this.txt_GuestEmail.Size = new System.Drawing.Size(130, 26);
            this.txt_GuestEmail.TabIndex = 11;
            // 
            // inputCommentGuest
            // 
            this.inputCommentGuest.Location = new System.Drawing.Point(66, 386);
            this.inputCommentGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCommentGuest.MaxLength = 100;
            this.inputCommentGuest.Multiline = true;
            this.inputCommentGuest.Name = "inputCommentGuest";
            this.inputCommentGuest.Size = new System.Drawing.Size(295, 62);
            this.inputCommentGuest.TabIndex = 12;
            // 
            // inputOptionHidePrices
            // 
            this.inputOptionHidePrices.AutoSize = true;
            this.inputOptionHidePrices.Location = new System.Drawing.Point(342, 295);
            this.inputOptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputOptionHidePrices.Name = "inputOptionHidePrices";
            this.inputOptionHidePrices.Size = new System.Drawing.Size(22, 21);
            this.inputOptionHidePrices.TabIndex = 14;
            this.inputOptionHidePrices.UseVisualStyleBackColor = true;
            // 
            // labelOptionHidePrices
            // 
            this.labelOptionHidePrices.BackColor = System.Drawing.SystemColors.Control;
            this.labelOptionHidePrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOptionHidePrices.Location = new System.Drawing.Point(66, 294);
            this.labelOptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelOptionHidePrices.Multiline = true;
            this.labelOptionHidePrices.Name = "labelOptionHidePrices";
            this.labelOptionHidePrices.Size = new System.Drawing.Size(234, 49);
            this.labelOptionHidePrices.TabIndex = 15;
            this.labelOptionHidePrices.Text = "Would you like to hide the prices from the menu?";
            // 
            // cmb_Hours
            // 
            this.cmb_Hours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Hours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hours.FormattingEnabled = true;
            this.cmb_Hours.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmb_Hours.Location = new System.Drawing.Point(231, 186);
            this.cmb_Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Hours.Name = "cmb_Hours";
            this.cmb_Hours.Size = new System.Drawing.Size(55, 28);
            this.cmb_Hours.TabIndex = 17;
            // 
            // cmb_Minutes
            // 
            this.cmb_Minutes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Minutes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Minutes.FormattingEnabled = true;
            this.cmb_Minutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmb_Minutes.Location = new System.Drawing.Point(306, 186);
            this.cmb_Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Minutes.Name = "cmb_Minutes";
            this.cmb_Minutes.Size = new System.Drawing.Size(55, 28);
            this.cmb_Minutes.TabIndex = 18;
            // 
            // labelCommentOwner
            // 
            this.labelCommentOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentOwner.Location = new System.Drawing.Point(66, 542);
            this.labelCommentOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCommentOwner.Multiline = true;
            this.labelCommentOwner.Name = "labelCommentOwner";
            this.labelCommentOwner.Size = new System.Drawing.Size(296, 49);
            this.labelCommentOwner.TabIndex = 19;
            this.labelCommentOwner.Text = "Feel free to contact us on 000-0000000 if you experience any problems.";
            this.labelCommentOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_arrivingDate
            // 
            this.dtp_arrivingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_arrivingDate.Location = new System.Drawing.Point(231, 79);
            this.dtp_arrivingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_arrivingDate.Name = "dtp_arrivingDate";
            this.dtp_arrivingDate.Size = new System.Drawing.Size(130, 26);
            this.dtp_arrivingDate.TabIndex = 21;
            this.dtp_arrivingDate.Value = new System.DateTime(2018, 4, 11, 0, 0, 0, 0);
            this.dtp_arrivingDate.ValueChanged += new System.EventHandler(this.dtp_arrivingDate_ValueChanged);
            // 
            // nud_numberOfGuests
            // 
            this.nud_numberOfGuests.Location = new System.Drawing.Point(231, 148);
            this.nud_numberOfGuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_numberOfGuests.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_numberOfGuests.Name = "nud_numberOfGuests";
            this.nud_numberOfGuests.Size = new System.Drawing.Size(130, 26);
            this.nud_numberOfGuests.TabIndex = 22;
            // 
            // bt_reserve
            // 
            this.bt_reserve.Location = new System.Drawing.Point(252, 481);
            this.bt_reserve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_reserve.Name = "bt_reserve";
            this.bt_reserve.Size = new System.Drawing.Size(112, 35);
            this.bt_reserve.TabIndex = 23;
            this.bt_reserve.Text = "Reserve";
            this.bt_reserve.UseVisualStyleBackColor = true;
            this.bt_reserve.Click += new System.EventHandler(this.bt_reserve_Click);
            // 
            // bt_ViewReservation
            // 
            this.bt_ViewReservation.Location = new System.Drawing.Point(66, 481);
            this.bt_ViewReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_ViewReservation.Name = "bt_ViewReservation";
            this.bt_ViewReservation.Size = new System.Drawing.Size(112, 35);
            this.bt_ViewReservation.TabIndex = 24;
            this.bt_ViewReservation.Text = "View Reservations";
            this.bt_ViewReservation.UseVisualStyleBackColor = true;
            this.bt_ViewReservation.Click += new System.EventHandler(this.bt_ViewReservation_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 602);
            this.Controls.Add(this.bt_ViewReservation);
            this.Controls.Add(this.bt_reserve);
            this.Controls.Add(this.nud_numberOfGuests);
            this.Controls.Add(this.dtp_arrivingDate);
            this.Controls.Add(this.labelCommentOwner);
            this.Controls.Add(this.cmb_Minutes);
            this.Controls.Add(this.cmb_Hours);
            this.Controls.Add(this.labelOptionHidePrices);
            this.Controls.Add(this.inputOptionHidePrices);
            this.Controls.Add(this.inputCommentGuest);
            this.Controls.Add(this.txt_GuestEmail);
            this.Controls.Add(this.txt_GuestPhonenumber);
            this.Controls.Add(this.txt_NameGuest);
            this.Controls.Add(this.labelCommentsGuest);
            this.Controls.Add(this.labelGuestEmail);
            this.Controls.Add(this.labelGuestPhoneNumber);
            this.Controls.Add(this.labelBeginTime);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelNameGuest);
            this.Controls.Add(this.labelDateReservation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservationForm";
            this.Text = "Reservation Molveno Lake Resort";
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberOfGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labelDateReservation;
        private System.Windows.Forms.TextBox labelNameGuest;
        private System.Windows.Forms.TextBox labelNumberOfGuests;
        private System.Windows.Forms.TextBox labelBeginTime;
        private System.Windows.Forms.TextBox labelGuestPhoneNumber;
        private System.Windows.Forms.TextBox labelGuestEmail;
        private System.Windows.Forms.TextBox labelCommentsGuest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_NameGuest;
        private System.Windows.Forms.TextBox txt_GuestPhonenumber;
        private System.Windows.Forms.TextBox txt_GuestEmail;
        private System.Windows.Forms.TextBox inputCommentGuest;
        private System.Windows.Forms.CheckBox inputOptionHidePrices;
        private System.Windows.Forms.TextBox labelOptionHidePrices;
        private System.Windows.Forms.ComboBox cmb_Hours;
        private System.Windows.Forms.ComboBox cmb_Minutes;
        private System.Windows.Forms.TextBox labelCommentOwner;
        private System.Windows.Forms.DateTimePicker dtp_arrivingDate;
        private System.Windows.Forms.NumericUpDown nud_numberOfGuests;
        private System.Windows.Forms.Button bt_reserve;
        private System.Windows.Forms.Button bt_ViewReservation;
    }
}

