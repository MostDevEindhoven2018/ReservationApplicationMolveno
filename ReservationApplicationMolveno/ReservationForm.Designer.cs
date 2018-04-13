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
            this.lbl_guestName = new System.Windows.Forms.TextBox();
            this.lbl_guestPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_guestEmail = new System.Windows.Forms.TextBox();
            this.lbl_CommentGuest = new System.Windows.Forms.TextBox();
            this.cb_OptionHidePrices = new System.Windows.Forms.CheckBox();
            this.labelOptionHidePrices = new System.Windows.Forms.TextBox();
            this.cb_beginTimeHour = new System.Windows.Forms.ComboBox();
            this.cb_beginTimeMinute = new System.Windows.Forms.ComboBox();
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
            this.labelDateReservation.Location = new System.Drawing.Point(59, 63);
            this.labelDateReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelDateReservation.Name = "labelDateReservation";
            this.labelDateReservation.Size = new System.Drawing.Size(115, 15);
            this.labelDateReservation.TabIndex = 0;
            this.labelDateReservation.Text = "Date";
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameGuest.Location = new System.Drawing.Point(59, 91);
            this.labelNameGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(115, 15);
            this.labelNameGuest.TabIndex = 1;
            this.labelNameGuest.Text = "Name";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(59, 119);
            this.labelNumberOfGuests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(115, 15);
            this.labelNumberOfGuests.TabIndex = 2;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelBeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBeginTime.Location = new System.Drawing.Point(59, 149);
            this.labelBeginTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(115, 15);
            this.labelBeginTime.TabIndex = 3;
            this.labelBeginTime.Text = "Reservation time";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(59, 178);
            this.labelGuestPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(115, 15);
            this.labelGuestPhoneNumber.TabIndex = 4;
            this.labelGuestPhoneNumber.Text = "Phonenumber";
            // 
            // labelGuestEmail
            // 
            this.labelGuestEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestEmail.Location = new System.Drawing.Point(59, 207);
            this.labelGuestEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelGuestEmail.Name = "labelGuestEmail";
            this.labelGuestEmail.Size = new System.Drawing.Size(115, 15);
            this.labelGuestEmail.TabIndex = 5;
            this.labelGuestEmail.Text = "Email address";
            // 
            // labelCommentsGuest
            // 
            this.labelCommentsGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentsGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentsGuest.Location = new System.Drawing.Point(59, 281);
            this.labelCommentsGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCommentsGuest.Name = "labelCommentsGuest";
            this.labelCommentsGuest.Size = new System.Drawing.Size(115, 15);
            this.labelCommentsGuest.TabIndex = 6;
            this.labelCommentsGuest.Text = "Comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_guestName
            // 
            this.lbl_guestName.Location = new System.Drawing.Point(205, 91);
            this.lbl_guestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_guestName.Name = "lbl_guestName";
            this.lbl_guestName.Size = new System.Drawing.Size(116, 22);
            this.lbl_guestName.TabIndex = 9;
            // 
            // lbl_guestPhoneNumber
            // 
            this.lbl_guestPhoneNumber.Location = new System.Drawing.Point(205, 178);
            this.lbl_guestPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_guestPhoneNumber.Name = "lbl_guestPhoneNumber";
            this.lbl_guestPhoneNumber.Size = new System.Drawing.Size(116, 22);
            this.lbl_guestPhoneNumber.TabIndex = 10;
            // 
            // lbl_guestEmail
            // 
            this.lbl_guestEmail.Location = new System.Drawing.Point(205, 207);
            this.lbl_guestEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_guestEmail.Name = "lbl_guestEmail";
            this.lbl_guestEmail.Size = new System.Drawing.Size(116, 22);
            this.lbl_guestEmail.TabIndex = 11;
            // 
            // lbl_CommentGuest
            // 
            this.lbl_CommentGuest.Location = new System.Drawing.Point(59, 309);
            this.lbl_CommentGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_CommentGuest.Multiline = true;
            this.lbl_CommentGuest.Name = "lbl_CommentGuest";
            this.lbl_CommentGuest.Size = new System.Drawing.Size(263, 50);
            this.lbl_CommentGuest.TabIndex = 12;
            // 
            // cb_OptionHidePrices
            // 
            this.cb_OptionHidePrices.AutoSize = true;
            this.cb_OptionHidePrices.Location = new System.Drawing.Point(304, 236);
            this.cb_OptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_OptionHidePrices.Name = "cb_OptionHidePrices";
            this.cb_OptionHidePrices.Size = new System.Drawing.Size(18, 17);
            this.cb_OptionHidePrices.TabIndex = 14;
            this.cb_OptionHidePrices.UseVisualStyleBackColor = true;
            // 
            // labelOptionHidePrices
            // 
            this.labelOptionHidePrices.BackColor = System.Drawing.SystemColors.Control;
            this.labelOptionHidePrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOptionHidePrices.Location = new System.Drawing.Point(59, 235);
            this.labelOptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelOptionHidePrices.Multiline = true;
            this.labelOptionHidePrices.Name = "labelOptionHidePrices";
            this.labelOptionHidePrices.Size = new System.Drawing.Size(208, 39);
            this.labelOptionHidePrices.TabIndex = 15;
            this.labelOptionHidePrices.Text = "Would you like to hide the prices from the menu?";
            // 
            // cb_beginTimeHour
            // 
            this.cb_beginTimeHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_beginTimeHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_beginTimeHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_beginTimeHour.FormattingEnabled = true;
            this.cb_beginTimeHour.Location = new System.Drawing.Point(205, 149);
            this.cb_beginTimeHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_beginTimeHour.Name = "cb_beginTimeHour";
            this.cb_beginTimeHour.Size = new System.Drawing.Size(49, 24);
            this.cb_beginTimeHour.TabIndex = 17;
            // 
            // cb_beginTimeMinute
            // 
            this.cb_beginTimeMinute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_beginTimeMinute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_beginTimeMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_beginTimeMinute.FormattingEnabled = true;
            this.cb_beginTimeMinute.Location = new System.Drawing.Point(272, 149);
            this.cb_beginTimeMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_beginTimeMinute.Name = "cb_beginTimeMinute";
            this.cb_beginTimeMinute.Size = new System.Drawing.Size(49, 24);
            this.cb_beginTimeMinute.TabIndex = 18;
            // 
            // labelCommentOwner
            // 
            this.labelCommentOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentOwner.Location = new System.Drawing.Point(59, 434);
            this.labelCommentOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCommentOwner.Multiline = true;
            this.labelCommentOwner.Name = "labelCommentOwner";
            this.labelCommentOwner.Size = new System.Drawing.Size(263, 39);
            this.labelCommentOwner.TabIndex = 19;
            this.labelCommentOwner.Text = "Feel free to contact us on 000-0000000 if you experience any problems.";
            this.labelCommentOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_arrivingDate
            // 
            this.dtp_arrivingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_arrivingDate.Location = new System.Drawing.Point(205, 63);
            this.dtp_arrivingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_arrivingDate.Name = "dtp_arrivingDate";
            this.dtp_arrivingDate.Size = new System.Drawing.Size(116, 22);
            this.dtp_arrivingDate.TabIndex = 21;
            this.dtp_arrivingDate.Value = new System.DateTime(2018, 4, 11, 0, 0, 0, 0);
            // 
            // nud_numberOfGuests
            // 
            this.nud_numberOfGuests.Location = new System.Drawing.Point(205, 118);
            this.nud_numberOfGuests.Margin = new System.Windows.Forms.Padding(4);
            this.nud_numberOfGuests.Name = "nud_numberOfGuests";
            this.nud_numberOfGuests.Size = new System.Drawing.Size(116, 22);
            this.nud_numberOfGuests.TabIndex = 22;
            this.nud_numberOfGuests.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // bt_reserve
            // 
            this.bt_reserve.Location = new System.Drawing.Point(224, 385);
            this.bt_reserve.Margin = new System.Windows.Forms.Padding(4);
            this.bt_reserve.Name = "bt_reserve";
            this.bt_reserve.Size = new System.Drawing.Size(100, 28);
            this.bt_reserve.TabIndex = 23;
            this.bt_reserve.Text = "Reserve";
            this.bt_reserve.UseVisualStyleBackColor = true;
            this.bt_reserve.Click += new System.EventHandler(this.bt_reserve_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 482);
            this.Controls.Add(this.bt_reserve);
            this.Controls.Add(this.nud_numberOfGuests);
            this.Controls.Add(this.dtp_arrivingDate);
            this.Controls.Add(this.labelCommentOwner);
            this.Controls.Add(this.cb_beginTimeMinute);
            this.Controls.Add(this.cb_beginTimeHour);
            this.Controls.Add(this.labelOptionHidePrices);
            this.Controls.Add(this.cb_OptionHidePrices);
            this.Controls.Add(this.lbl_CommentGuest);
            this.Controls.Add(this.lbl_guestEmail);
            this.Controls.Add(this.lbl_guestPhoneNumber);
            this.Controls.Add(this.lbl_guestName);
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
        private System.Windows.Forms.TextBox lbl_guestName;
        private System.Windows.Forms.TextBox lbl_guestPhoneNumber;
        private System.Windows.Forms.TextBox lbl_guestEmail;
        private System.Windows.Forms.TextBox lbl_CommentGuest;
        private System.Windows.Forms.CheckBox cb_OptionHidePrices;
        private System.Windows.Forms.TextBox labelOptionHidePrices;
        private System.Windows.Forms.ComboBox cb_beginTimeHour;
        private System.Windows.Forms.ComboBox cb_beginTimeMinute;
        private System.Windows.Forms.TextBox labelCommentOwner;
        private System.Windows.Forms.DateTimePicker dtp_arrivingDate;
        private System.Windows.Forms.NumericUpDown nud_numberOfGuests;
        private System.Windows.Forms.Button bt_reserve;
    }
}

