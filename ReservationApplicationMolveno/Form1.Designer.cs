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
            this.inputDateReservation = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inputNameGuest = new System.Windows.Forms.TextBox();
            this.inputGuestPhoneNumber = new System.Windows.Forms.TextBox();
            this.inputGuestEmail = new System.Windows.Forms.TextBox();
            this.inputCommentGuest = new System.Windows.Forms.TextBox();
            this.inputSendReservation = new System.Windows.Forms.TextBox();
            this.inputOptionHidePrices = new System.Windows.Forms.CheckBox();
            this.labelOptionHidePrices = new System.Windows.Forms.TextBox();
            this.inputNumberOfGuests = new System.Windows.Forms.ComboBox();
            this.inputBeginTimeHour = new System.Windows.Forms.ComboBox();
            this.inputBeginTimeMinute = new System.Windows.Forms.ComboBox();
            this.labelCommentOwner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDateReservation
            // 
            this.labelDateReservation.BackColor = System.Drawing.SystemColors.Control;
            this.labelDateReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDateReservation.Location = new System.Drawing.Point(59, 63);
            this.labelDateReservation.Name = "labelDateReservation";
            this.labelDateReservation.Size = new System.Drawing.Size(114, 15);
            this.labelDateReservation.TabIndex = 0;
            this.labelDateReservation.Text = "Date";
            this.labelDateReservation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameGuest.Location = new System.Drawing.Point(59, 91);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(114, 15);
            this.labelNameGuest.TabIndex = 1;
            this.labelNameGuest.Text = "Name";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(59, 119);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(114, 15);
            this.labelNumberOfGuests.TabIndex = 2;
            this.labelNumberOfGuests.Text = "Number of guests";
            this.labelNumberOfGuests.TextChanged += new System.EventHandler(this.labelNumberOfGuests_TextChanged);
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelBeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBeginTime.Location = new System.Drawing.Point(59, 149);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(114, 15);
            this.labelBeginTime.TabIndex = 3;
            this.labelBeginTime.Text = "Reservation time";
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(59, 179);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(114, 15);
            this.labelGuestPhoneNumber.TabIndex = 4;
            this.labelGuestPhoneNumber.Text = "Phonenumber";
            // 
            // labelGuestEmail
            // 
            this.labelGuestEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelGuestEmail.Location = new System.Drawing.Point(59, 207);
            this.labelGuestEmail.Name = "labelGuestEmail";
            this.labelGuestEmail.Size = new System.Drawing.Size(114, 15);
            this.labelGuestEmail.TabIndex = 5;
            this.labelGuestEmail.Text = "Email address";
            // 
            // labelCommentsGuest
            // 
            this.labelCommentsGuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentsGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentsGuest.Location = new System.Drawing.Point(59, 281);
            this.labelCommentsGuest.Name = "labelCommentsGuest";
            this.labelCommentsGuest.Size = new System.Drawing.Size(114, 15);
            this.labelCommentsGuest.TabIndex = 6;
            this.labelCommentsGuest.Text = "Comments";
            // 
            // inputDateReservation
            // 
            this.inputDateReservation.BackColor = System.Drawing.SystemColors.Control;
            this.inputDateReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDateReservation.Location = new System.Drawing.Point(206, 63);
            this.inputDateReservation.Name = "inputDateReservation";
            this.inputDateReservation.Size = new System.Drawing.Size(116, 22);
            this.inputDateReservation.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inputNameGuest
            // 
            this.inputNameGuest.Location = new System.Drawing.Point(206, 91);
            this.inputNameGuest.Name = "inputNameGuest";
            this.inputNameGuest.Size = new System.Drawing.Size(116, 22);
            this.inputNameGuest.TabIndex = 9;
            // 
            // inputGuestPhoneNumber
            // 
            this.inputGuestPhoneNumber.Location = new System.Drawing.Point(206, 179);
            this.inputGuestPhoneNumber.Name = "inputGuestPhoneNumber";
            this.inputGuestPhoneNumber.Size = new System.Drawing.Size(116, 22);
            this.inputGuestPhoneNumber.TabIndex = 10;
            // 
            // inputGuestEmail
            // 
            this.inputGuestEmail.Location = new System.Drawing.Point(206, 207);
            this.inputGuestEmail.Name = "inputGuestEmail";
            this.inputGuestEmail.Size = new System.Drawing.Size(116, 22);
            this.inputGuestEmail.TabIndex = 11;
            // 
            // inputCommentGuest
            // 
            this.inputCommentGuest.Location = new System.Drawing.Point(59, 309);
            this.inputCommentGuest.Multiline = true;
            this.inputCommentGuest.Name = "inputCommentGuest";
            this.inputCommentGuest.Size = new System.Drawing.Size(263, 50);
            this.inputCommentGuest.TabIndex = 12;
            this.inputCommentGuest.TextChanged += new System.EventHandler(this.inputComment_TextChanged);
            // 
            // inputSendReservation
            // 
            this.inputSendReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.inputSendReservation.Location = new System.Drawing.Point(222, 393);
            this.inputSendReservation.Name = "inputSendReservation";
            this.inputSendReservation.Size = new System.Drawing.Size(100, 22);
            this.inputSendReservation.TabIndex = 13;
            this.inputSendReservation.Text = "Reserve";
            this.inputSendReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSendReservation.TextChanged += new System.EventHandler(this.inputSendReservation_TextChanged);
            // 
            // inputOptionHidePrices
            // 
            this.inputOptionHidePrices.AutoSize = true;
            this.inputOptionHidePrices.Location = new System.Drawing.Point(304, 236);
            this.inputOptionHidePrices.Name = "inputOptionHidePrices";
            this.inputOptionHidePrices.Size = new System.Drawing.Size(18, 17);
            this.inputOptionHidePrices.TabIndex = 14;
            this.inputOptionHidePrices.UseVisualStyleBackColor = true;
            // 
            // labelOptionHidePrices
            // 
            this.labelOptionHidePrices.BackColor = System.Drawing.SystemColors.Control;
            this.labelOptionHidePrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOptionHidePrices.Location = new System.Drawing.Point(59, 235);
            this.labelOptionHidePrices.Multiline = true;
            this.labelOptionHidePrices.Name = "labelOptionHidePrices";
            this.labelOptionHidePrices.Size = new System.Drawing.Size(208, 40);
            this.labelOptionHidePrices.TabIndex = 15;
            this.labelOptionHidePrices.Text = "Would you like to hide the prices from the menu?";
            this.labelOptionHidePrices.TextChanged += new System.EventHandler(this.labelOptionHidePrices_TextChanged);
            // 
            // inputNumberOfGuests
            // 
            this.inputNumberOfGuests.FormattingEnabled = true;
            this.inputNumberOfGuests.Location = new System.Drawing.Point(206, 119);
            this.inputNumberOfGuests.Name = "inputNumberOfGuests";
            this.inputNumberOfGuests.Size = new System.Drawing.Size(116, 24);
            this.inputNumberOfGuests.TabIndex = 16;
            this.inputNumberOfGuests.SelectedIndexChanged += new System.EventHandler(this.inputNumberOfGuests_SelectedIndexChanged);
            // 
            // inputBeginTimeHour
            // 
            this.inputBeginTimeHour.FormattingEnabled = true;
            this.inputBeginTimeHour.Location = new System.Drawing.Point(206, 149);
            this.inputBeginTimeHour.Name = "inputBeginTimeHour";
            this.inputBeginTimeHour.Size = new System.Drawing.Size(50, 24);
            this.inputBeginTimeHour.TabIndex = 17;
            this.inputBeginTimeHour.SelectedIndexChanged += new System.EventHandler(this.inputBeginTimeHour_SelectedIndexChanged);
            // 
            // inputBeginTimeMinute
            // 
            this.inputBeginTimeMinute.FormattingEnabled = true;
            this.inputBeginTimeMinute.Location = new System.Drawing.Point(272, 149);
            this.inputBeginTimeMinute.Name = "inputBeginTimeMinute";
            this.inputBeginTimeMinute.Size = new System.Drawing.Size(50, 24);
            this.inputBeginTimeMinute.TabIndex = 18;
            // 
            // labelCommentOwner
            // 
            this.labelCommentOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelCommentOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCommentOwner.Location = new System.Drawing.Point(59, 434);
            this.labelCommentOwner.Multiline = true;
            this.labelCommentOwner.Name = "labelCommentOwner";
            this.labelCommentOwner.Size = new System.Drawing.Size(263, 39);
            this.labelCommentOwner.TabIndex = 19;
            this.labelCommentOwner.Text = "Feel free to contact us on 000-0000000 if you experience any problems.";
            this.labelCommentOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelCommentOwner.TextChanged += new System.EventHandler(this.labelCommentOwner_TextChanged);
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 483);
            this.Controls.Add(this.labelCommentOwner);
            this.Controls.Add(this.inputBeginTimeMinute);
            this.Controls.Add(this.inputBeginTimeHour);
            this.Controls.Add(this.inputNumberOfGuests);
            this.Controls.Add(this.labelOptionHidePrices);
            this.Controls.Add(this.inputOptionHidePrices);
            this.Controls.Add(this.inputSendReservation);
            this.Controls.Add(this.inputCommentGuest);
            this.Controls.Add(this.inputGuestEmail);
            this.Controls.Add(this.inputGuestPhoneNumber);
            this.Controls.Add(this.inputNameGuest);
            this.Controls.Add(this.inputDateReservation);
            this.Controls.Add(this.labelCommentsGuest);
            this.Controls.Add(this.labelGuestEmail);
            this.Controls.Add(this.labelGuestPhoneNumber);
            this.Controls.Add(this.labelBeginTime);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelNameGuest);
            this.Controls.Add(this.labelDateReservation);
            this.Name = "formReservation";
            this.Text = "Reservation Molveno Lake Resort";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox inputDateReservation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inputNameGuest;
        private System.Windows.Forms.TextBox inputGuestPhoneNumber;
        private System.Windows.Forms.TextBox inputGuestEmail;
        private System.Windows.Forms.TextBox inputCommentGuest;
        private System.Windows.Forms.TextBox inputSendReservation;
        private System.Windows.Forms.CheckBox inputOptionHidePrices;
        private System.Windows.Forms.TextBox labelOptionHidePrices;
        private System.Windows.Forms.ComboBox inputNumberOfGuests;
        private System.Windows.Forms.ComboBox inputBeginTimeHour;
        private System.Windows.Forms.ComboBox inputBeginTimeMinute;
        private System.Windows.Forms.TextBox labelCommentOwner;
    }
}

