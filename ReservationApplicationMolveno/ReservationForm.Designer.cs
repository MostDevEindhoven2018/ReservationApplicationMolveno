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
            this.labelDateReservation = new System.Windows.Forms.TextBox();
            this.labelNameGuest = new System.Windows.Forms.TextBox();
            this.labelNumberOfGuests = new System.Windows.Forms.TextBox();
            this.labelBeginTime = new System.Windows.Forms.TextBox();
            this.labelGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelGuestEmail = new System.Windows.Forms.TextBox();
            this.labelCommentsGuest = new System.Windows.Forms.TextBox();
            this.tb_guestName = new System.Windows.Forms.TextBox();
            this.tb_guestPhone = new System.Windows.Forms.TextBox();
            this.tb_guestEmail = new System.Windows.Forms.TextBox();
            this.inputCommentGuest = new System.Windows.Forms.TextBox();
            this.cb_hidePrices = new System.Windows.Forms.CheckBox();
            this.labelOptionHidePrices = new System.Windows.Forms.TextBox();
            this.dd_arrivingHour = new System.Windows.Forms.ComboBox();
            this.dd_arrivingMinute = new System.Windows.Forms.ComboBox();
            this.labelCommentOwner = new System.Windows.Forms.TextBox();
            this.dtp_arrivingDate = new System.Windows.Forms.DateTimePicker();
            this.nud_numberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.bt_reserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateReservation
            // 
            this.labelDateReservation.BackColor = System.Drawing.SystemColors.Control;
            this.labelDateReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDateReservation.Location = new System.Drawing.Point(45, 44);
            this.labelDateReservation.Margin = new System.Windows.Forms.Padding(2);
            this.labelDateReservation.Name = "labelDateReservation";
            this.labelDateReservation.Size = new System.Drawing.Size(86, 13);
            this.labelDateReservation.TabIndex = 0;
            this.labelDateReservation.Text = "Date";
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameGuest.Location = new System.Drawing.Point(45, 124);
            this.labelNameGuest.Margin = new System.Windows.Forms.Padding(2);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(86, 13);
            this.labelNameGuest.TabIndex = 1;
            this.labelNameGuest.Text = "Name";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(44, 97);
            this.labelNumberOfGuests.Margin = new System.Windows.Forms.Padding(2);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(86, 13);
            this.labelNumberOfGuests.TabIndex = 2;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelBeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBeginTime.Location = new System.Drawing.Point(44, 71);
            this.labelBeginTime.Margin = new System.Windows.Forms.Padding(2);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(86, 13);
            this.labelBeginTime.TabIndex = 3;
            this.labelBeginTime.Text = "Reservation time";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(44, 148);
            this.labelGuestPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(86, 13);
            this.labelGuestPhoneNumber.TabIndex = 4;
            this.labelGuestPhoneNumber.Text = "Phonenumber";
            // 
            // labelGuestEmail
            // 
            this.labelGuestEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestEmail.Location = new System.Drawing.Point(44, 171);
            this.labelGuestEmail.Margin = new System.Windows.Forms.Padding(2);
            this.labelGuestEmail.Name = "labelGuestEmail";
            this.labelGuestEmail.Size = new System.Drawing.Size(86, 13);
            this.labelGuestEmail.TabIndex = 5;
            this.labelGuestEmail.Text = "Email address";
            // 
            // labelCommentsGuest
            // 
            this.labelCommentsGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentsGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentsGuest.Location = new System.Drawing.Point(44, 228);
            this.labelCommentsGuest.Margin = new System.Windows.Forms.Padding(2);
            this.labelCommentsGuest.Name = "labelCommentsGuest";
            this.labelCommentsGuest.Size = new System.Drawing.Size(86, 13);
            this.labelCommentsGuest.TabIndex = 6;
            this.labelCommentsGuest.Text = "Comments";
            // 
            // tb_guestName
            // 
            this.tb_guestName.Location = new System.Drawing.Point(153, 121);
            this.tb_guestName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_guestName.Name = "tb_guestName";
            this.tb_guestName.Size = new System.Drawing.Size(88, 20);
            this.tb_guestName.TabIndex = 9;
            // 
            // tb_guestPhone
            // 
            this.tb_guestPhone.Location = new System.Drawing.Point(154, 145);
            this.tb_guestPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_guestPhone.Name = "tb_guestPhone";
            this.tb_guestPhone.Size = new System.Drawing.Size(88, 20);
            this.tb_guestPhone.TabIndex = 10;
            // 
            // tb_guestEmail
            // 
            this.tb_guestEmail.Location = new System.Drawing.Point(154, 168);
            this.tb_guestEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tb_guestEmail.Name = "tb_guestEmail";
            this.tb_guestEmail.Size = new System.Drawing.Size(88, 20);
            this.tb_guestEmail.TabIndex = 11;
            // 
            // inputCommentGuest
            // 
            this.inputCommentGuest.Location = new System.Drawing.Point(44, 251);
            this.inputCommentGuest.Margin = new System.Windows.Forms.Padding(2);
            this.inputCommentGuest.Multiline = true;
            this.inputCommentGuest.Name = "inputCommentGuest";
            this.inputCommentGuest.Size = new System.Drawing.Size(198, 41);
            this.inputCommentGuest.TabIndex = 12;
            // 
            // cb_hidePrices
            // 
            this.cb_hidePrices.AutoSize = true;
            this.cb_hidePrices.Location = new System.Drawing.Point(228, 192);
            this.cb_hidePrices.Margin = new System.Windows.Forms.Padding(2);
            this.cb_hidePrices.Name = "cb_hidePrices";
            this.cb_hidePrices.Size = new System.Drawing.Size(15, 14);
            this.cb_hidePrices.TabIndex = 14;
            this.cb_hidePrices.UseVisualStyleBackColor = true;
            // 
            // labelOptionHidePrices
            // 
            this.labelOptionHidePrices.BackColor = System.Drawing.SystemColors.Control;
            this.labelOptionHidePrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOptionHidePrices.Location = new System.Drawing.Point(44, 191);
            this.labelOptionHidePrices.Margin = new System.Windows.Forms.Padding(2);
            this.labelOptionHidePrices.Multiline = true;
            this.labelOptionHidePrices.Name = "labelOptionHidePrices";
            this.labelOptionHidePrices.Size = new System.Drawing.Size(156, 32);
            this.labelOptionHidePrices.TabIndex = 15;
            this.labelOptionHidePrices.Text = "Would you like to hide the prices from the menu?";
            // 
            // dd_arrivingHour
            // 
            this.dd_arrivingHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dd_arrivingHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dd_arrivingHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_arrivingHour.FormattingEnabled = true;
            this.dd_arrivingHour.Location = new System.Drawing.Point(154, 68);
            this.dd_arrivingHour.Margin = new System.Windows.Forms.Padding(2);
            this.dd_arrivingHour.Name = "dd_arrivingHour";
            this.dd_arrivingHour.Size = new System.Drawing.Size(38, 21);
            this.dd_arrivingHour.TabIndex = 17;
            // 
            // dd_arrivingMinute
            // 
            this.dd_arrivingMinute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dd_arrivingMinute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dd_arrivingMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_arrivingMinute.FormattingEnabled = true;
            this.dd_arrivingMinute.Location = new System.Drawing.Point(204, 68);
            this.dd_arrivingMinute.Margin = new System.Windows.Forms.Padding(2);
            this.dd_arrivingMinute.Name = "dd_arrivingMinute";
            this.dd_arrivingMinute.Size = new System.Drawing.Size(38, 21);
            this.dd_arrivingMinute.TabIndex = 18;
            // 
            // labelCommentOwner
            // 
            this.labelCommentOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentOwner.Location = new System.Drawing.Point(44, 353);
            this.labelCommentOwner.Margin = new System.Windows.Forms.Padding(2);
            this.labelCommentOwner.Multiline = true;
            this.labelCommentOwner.Name = "labelCommentOwner";
            this.labelCommentOwner.Size = new System.Drawing.Size(197, 32);
            this.labelCommentOwner.TabIndex = 19;
            this.labelCommentOwner.Text = "Feel free to contact us on 000-0000000 if you experience any problems.";
            this.labelCommentOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_arrivingDate
            // 
            this.dtp_arrivingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_arrivingDate.Location = new System.Drawing.Point(154, 38);
            this.dtp_arrivingDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_arrivingDate.Name = "dtp_arrivingDate";
            this.dtp_arrivingDate.Size = new System.Drawing.Size(88, 20);
            this.dtp_arrivingDate.TabIndex = 21;
            this.dtp_arrivingDate.Value = new System.DateTime(2018, 4, 11, 0, 0, 0, 0);
            // 
            // nud_numberOfGuests
            // 
            this.nud_numberOfGuests.Location = new System.Drawing.Point(154, 96);
            this.nud_numberOfGuests.Name = "nud_numberOfGuests";
            this.nud_numberOfGuests.Size = new System.Drawing.Size(87, 20);
            this.nud_numberOfGuests.TabIndex = 22;
            this.nud_numberOfGuests.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // bt_reserve
            // 
            this.bt_reserve.Location = new System.Drawing.Point(168, 313);
            this.bt_reserve.Name = "bt_reserve";
            this.bt_reserve.Size = new System.Drawing.Size(75, 23);
            this.bt_reserve.TabIndex = 23;
            this.bt_reserve.Text = "Reserve";
            this.bt_reserve.UseVisualStyleBackColor = true;
            this.bt_reserve.Click += new System.EventHandler(this.bt_reserve_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 392);
            this.Controls.Add(this.bt_reserve);
            this.Controls.Add(this.nud_numberOfGuests);
            this.Controls.Add(this.dtp_arrivingDate);
            this.Controls.Add(this.labelCommentOwner);
            this.Controls.Add(this.dd_arrivingMinute);
            this.Controls.Add(this.dd_arrivingHour);
            this.Controls.Add(this.labelOptionHidePrices);
            this.Controls.Add(this.cb_hidePrices);
            this.Controls.Add(this.inputCommentGuest);
            this.Controls.Add(this.tb_guestEmail);
            this.Controls.Add(this.tb_guestPhone);
            this.Controls.Add(this.tb_guestName);
            this.Controls.Add(this.labelCommentsGuest);
            this.Controls.Add(this.labelGuestEmail);
            this.Controls.Add(this.labelGuestPhoneNumber);
            this.Controls.Add(this.labelBeginTime);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelNameGuest);
            this.Controls.Add(this.labelDateReservation);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox tb_guestName;
        private System.Windows.Forms.TextBox tb_guestPhone;
        private System.Windows.Forms.TextBox tb_guestEmail;
        private System.Windows.Forms.TextBox inputCommentGuest;
        private System.Windows.Forms.CheckBox cb_hidePrices;
        private System.Windows.Forms.TextBox labelOptionHidePrices;
        private System.Windows.Forms.ComboBox dd_arrivingHour;
        private System.Windows.Forms.ComboBox dd_arrivingMinute;
        private System.Windows.Forms.TextBox labelCommentOwner;
        private System.Windows.Forms.DateTimePicker dtp_arrivingDate;
        private System.Windows.Forms.NumericUpDown nud_numberOfGuests;
        private System.Windows.Forms.Button bt_reserve;
    }
}

