namespace ReservationApplicationMolveno
{
    partial class formReservation
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
            this.inputNameGuest = new System.Windows.Forms.TextBox();
            this.inputGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.inputGuestEmail = new System.Windows.Forms.TextBox();
            this.inputCommentGuest = new System.Windows.Forms.TextBox();
            this.inputSendReservation = new System.Windows.Forms.TextBox();
            this.inputOptionHidePrices = new System.Windows.Forms.CheckBox();
            this.labelOptionHidePrices = new System.Windows.Forms.TextBox();
            this.inputBeginTimeHour = new System.Windows.Forms.ComboBox();
            this.inputBeginTimeMinute = new System.Windows.Forms.ComboBox();
            this.labelCommentOwner = new System.Windows.Forms.TextBox();
            this.dtp_arrivingDate = new System.Windows.Forms.DateTimePicker();
            this.nud_numberOfGuests = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateReservation
            // 
            this.labelDateReservation.BackColor = System.Drawing.SystemColors.Control;
            this.labelDateReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDateReservation.Location = new System.Drawing.Point(51, 79);
            this.labelDateReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelDateReservation.Name = "labelDateReservation";
            this.labelDateReservation.Size = new System.Drawing.Size(128, 19);
            this.labelDateReservation.TabIndex = 0;
            this.labelDateReservation.Text = "Date";
            this.labelDateReservation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameGuest.Location = new System.Drawing.Point(51, 114);
            this.labelNameGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(128, 19);
            this.labelNameGuest.TabIndex = 1;
            this.labelNameGuest.Text = "Name";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(51, 149);
            this.labelNumberOfGuests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(128, 19);
            this.labelNumberOfGuests.TabIndex = 2;
            this.labelNumberOfGuests.Text = "Number of guests";
            this.labelNumberOfGuests.TextChanged += new System.EventHandler(this.labelNumberOfGuests_TextChanged);
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelBeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBeginTime.Location = new System.Drawing.Point(51, 189);
            this.labelBeginTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(128, 19);
            this.labelBeginTime.TabIndex = 3;
            this.labelBeginTime.Text = "Reservation time";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(51, 224);
            this.labelGuestPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(128, 19);
            this.labelGuestPhoneNumber.TabIndex = 4;
            this.labelGuestPhoneNumber.Text = "Phonenumber";
            // 
            // labelGuestEmail
            // 
            this.labelGuestEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestEmail.Location = new System.Drawing.Point(51, 259);
            this.labelGuestEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelGuestEmail.Name = "labelGuestEmail";
            this.labelGuestEmail.Size = new System.Drawing.Size(128, 19);
            this.labelGuestEmail.TabIndex = 5;
            this.labelGuestEmail.Text = "Email address";
            // 
            // labelCommentsGuest
            // 
            this.labelCommentsGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentsGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentsGuest.Location = new System.Drawing.Point(66, 351);
            this.labelCommentsGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelCommentsGuest.Name = "labelCommentsGuest";
            this.labelCommentsGuest.Size = new System.Drawing.Size(128, 19);
            this.labelCommentsGuest.TabIndex = 6;
            this.labelCommentsGuest.Text = "Comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inputNameGuest
            // 
            this.inputNameGuest.Location = new System.Drawing.Point(200, 114);
            this.inputNameGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputNameGuest.Name = "inputNameGuest";
            this.inputNameGuest.Size = new System.Drawing.Size(207, 26);
            this.inputNameGuest.TabIndex = 9;
            this.inputNameGuest.TextChanged += new System.EventHandler(this.inputNameGuest_TextChanged);
            // 
            // inputGuestPhoneNumber
            // 
            this.inputGuestPhoneNumber.Location = new System.Drawing.Point(200, 224);
            this.inputGuestPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGuestPhoneNumber.Name = "inputGuestPhoneNumber";
            this.inputGuestPhoneNumber.Size = new System.Drawing.Size(207, 26);
            this.inputGuestPhoneNumber.TabIndex = 10;
            // 
            // inputGuestEmail
            // 
            this.inputGuestEmail.Location = new System.Drawing.Point(200, 259);
            this.inputGuestEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGuestEmail.Name = "inputGuestEmail";
            this.inputGuestEmail.Size = new System.Drawing.Size(207, 26);
            this.inputGuestEmail.TabIndex = 11;
            // 
            // inputCommentGuest
            // 
            this.inputCommentGuest.Location = new System.Drawing.Point(66, 386);
            this.inputCommentGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputCommentGuest.Multiline = true;
            this.inputCommentGuest.Name = "inputCommentGuest";
            this.inputCommentGuest.Size = new System.Drawing.Size(295, 62);
            this.inputCommentGuest.TabIndex = 12;
            this.inputCommentGuest.TextChanged += new System.EventHandler(this.inputComment_TextChanged);
            // 
            // inputSendReservation
            // 
            this.inputSendReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.inputSendReservation.Location = new System.Drawing.Point(250, 491);
            this.inputSendReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputSendReservation.Name = "inputSendReservation";
            this.inputSendReservation.Size = new System.Drawing.Size(112, 26);
            this.inputSendReservation.TabIndex = 13;
            this.inputSendReservation.Text = "Reserve";
            this.inputSendReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSendReservation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputSendReservation_MouseClick);
            this.inputSendReservation.TextChanged += new System.EventHandler(this.inputSendReservation_TextChanged);
            // 
            // inputOptionHidePrices
            // 
            this.inputOptionHidePrices.AutoSize = true;
            this.inputOptionHidePrices.Location = new System.Drawing.Point(385, 294);
            this.inputOptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputOptionHidePrices.Name = "inputOptionHidePrices";
            this.inputOptionHidePrices.Size = new System.Drawing.Size(22, 21);
            this.inputOptionHidePrices.TabIndex = 14;
            this.inputOptionHidePrices.UseVisualStyleBackColor = true;
            // 
            // labelOptionHidePrices
            // 
            this.labelOptionHidePrices.BackColor = System.Drawing.SystemColors.Control;
            this.labelOptionHidePrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOptionHidePrices.Location = new System.Drawing.Point(51, 293);
            this.labelOptionHidePrices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelOptionHidePrices.Multiline = true;
            this.labelOptionHidePrices.Name = "labelOptionHidePrices";
            this.labelOptionHidePrices.Size = new System.Drawing.Size(234, 50);
            this.labelOptionHidePrices.TabIndex = 15;
            this.labelOptionHidePrices.Text = "Would you like to hide the prices from the menu?";
            this.labelOptionHidePrices.TextChanged += new System.EventHandler(this.labelOptionHidePrices_TextChanged);
            // 
            // inputBeginTimeHour
            // 
            this.inputBeginTimeHour.FormattingEnabled = true;
            this.inputBeginTimeHour.Location = new System.Drawing.Point(200, 186);
            this.inputBeginTimeHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBeginTimeHour.Name = "inputBeginTimeHour";
            this.inputBeginTimeHour.Size = new System.Drawing.Size(88, 28);
            this.inputBeginTimeHour.TabIndex = 17;
            this.inputBeginTimeHour.SelectedIndexChanged += new System.EventHandler(this.inputBeginTimeHour_SelectedIndexChanged);
            // 
            // inputBeginTimeMinute
            // 
            this.inputBeginTimeMinute.FormattingEnabled = true;
            this.inputBeginTimeMinute.Location = new System.Drawing.Point(306, 186);
            this.inputBeginTimeMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBeginTimeMinute.Name = "inputBeginTimeMinute";
            this.inputBeginTimeMinute.Size = new System.Drawing.Size(101, 28);
            this.inputBeginTimeMinute.TabIndex = 18;
            // 
            // labelCommentOwner
            // 
            this.labelCommentOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentOwner.Location = new System.Drawing.Point(66, 542);
            this.labelCommentOwner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelCommentOwner.Multiline = true;
            this.labelCommentOwner.Name = "labelCommentOwner";
            this.labelCommentOwner.Size = new System.Drawing.Size(296, 49);
            this.labelCommentOwner.TabIndex = 19;
            this.labelCommentOwner.Text = "Feel free to contact us on 000-0000000 if you experience any problems.";
            this.labelCommentOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelCommentOwner.TextChanged += new System.EventHandler(this.labelCommentOwner_TextChanged);
            // 
            // dtp_arrivingDate
            // 
            this.dtp_arrivingDate.Location = new System.Drawing.Point(200, 74);
            this.dtp_arrivingDate.Name = "dtp_arrivingDate";
            this.dtp_arrivingDate.Size = new System.Drawing.Size(207, 26);
            this.dtp_arrivingDate.TabIndex = 21;
            // 
            // nud_numberOfGuests
            // 
            this.nud_numberOfGuests.Location = new System.Drawing.Point(200, 149);
            this.nud_numberOfGuests.Name = "nud_numberOfGuests";
            this.nud_numberOfGuests.Size = new System.Drawing.Size(207, 26);
            this.nud_numberOfGuests.TabIndex = 20;
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 690);
            this.Controls.Add(this.dtp_arrivingDate);
            this.Controls.Add(this.nud_numberOfGuests);
            this.Controls.Add(this.labelCommentOwner);
            this.Controls.Add(this.inputBeginTimeMinute);
            this.Controls.Add(this.inputBeginTimeHour);
            this.Controls.Add(this.labelOptionHidePrices);
            this.Controls.Add(this.inputOptionHidePrices);
            this.Controls.Add(this.inputSendReservation);
            this.Controls.Add(this.inputCommentGuest);
            this.Controls.Add(this.inputGuestEmail);
            this.Controls.Add(this.inputGuestPhoneNumber);
            this.Controls.Add(this.inputNameGuest);
            this.Controls.Add(this.labelCommentsGuest);
            this.Controls.Add(this.labelGuestEmail);
            this.Controls.Add(this.labelGuestPhoneNumber);
            this.Controls.Add(this.labelBeginTime);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelNameGuest);
            this.Controls.Add(this.labelDateReservation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formReservation";
            this.Text = "Reservation Molveno Lake Resort";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox inputGuestPhoneNumber;
        private System.Windows.Forms.TextBox inputGuestEmail;
        private System.Windows.Forms.TextBox inputCommentGuest;
        private System.Windows.Forms.TextBox inputSendReservation;
        private System.Windows.Forms.CheckBox inputOptionHidePrices;
        private System.Windows.Forms.TextBox labelOptionHidePrices;
        private System.Windows.Forms.ComboBox inputBeginTimeHour;
        private System.Windows.Forms.ComboBox inputBeginTimeMinute;
        private System.Windows.Forms.TextBox labelCommentOwner;
        public System.Windows.Forms.TextBox inputNameGuest;
        private System.Windows.Forms.DateTimePicker dtp_arrivingDate;
        private System.Windows.Forms.NumericUpDown nud_numberOfGuests;
    }
}

