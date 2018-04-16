namespace ReservationApplicationMolveno
{
    partial class ReservationViewingForm
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_GuestName = new System.Windows.Forms.Label();
            this.lbl_partySize = new System.Windows.Forms.Label();
            this.lbl_tableNum = new System.Windows.Forms.Label();
            this.lbl_arrivalTime = new System.Windows.Forms.Label();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(91, 17);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Reservations";
            // 
            // lbl_GuestName
            // 
            this.lbl_GuestName.AutoSize = true;
            this.lbl_GuestName.Location = new System.Drawing.Point(12, 38);
            this.lbl_GuestName.Name = "lbl_GuestName";
            this.lbl_GuestName.Size = new System.Drawing.Size(87, 17);
            this.lbl_GuestName.TabIndex = 1;
            this.lbl_GuestName.Text = "Guest Name";
            // 
            // lbl_partySize
            // 
            this.lbl_partySize.AutoSize = true;
            this.lbl_partySize.Location = new System.Drawing.Point(109, 38);
            this.lbl_partySize.Name = "lbl_partySize";
            this.lbl_partySize.Size = new System.Drawing.Size(72, 17);
            this.lbl_partySize.TabIndex = 2;
            this.lbl_partySize.Text = "Party Size";
            // 
            // lbl_tableNum
            // 
            this.lbl_tableNum.AutoSize = true;
            this.lbl_tableNum.Location = new System.Drawing.Point(187, 38);
            this.lbl_tableNum.Name = "lbl_tableNum";
            this.lbl_tableNum.Size = new System.Drawing.Size(94, 17);
            this.lbl_tableNum.TabIndex = 3;
            this.lbl_tableNum.Text = "TableNumber";
            // 
            // lbl_arrivalTime
            // 
            this.lbl_arrivalTime.AutoSize = true;
            this.lbl_arrivalTime.Location = new System.Drawing.Point(287, 38);
            this.lbl_arrivalTime.Name = "lbl_arrivalTime";
            this.lbl_arrivalTime.Size = new System.Drawing.Size(83, 17);
            this.lbl_arrivalTime.TabIndex = 4;
            this.lbl_arrivalTime.Text = "Arrival Time";
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Location = new System.Drawing.Point(446, 38);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(68, 17);
            this.lbl_EndTime.TabIndex = 5;
            this.lbl_EndTime.Text = "End Time";
            // 
            // ReservationViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 353);
            this.Controls.Add(this.lbl_EndTime);
            this.Controls.Add(this.lbl_arrivalTime);
            this.Controls.Add(this.lbl_tableNum);
            this.Controls.Add(this.lbl_partySize);
            this.Controls.Add(this.lbl_GuestName);
            this.Controls.Add(this.lbl_header);
            this.Name = "ReservationViewingForm";
            this.Text = "ReservationViewingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_GuestName;
        private System.Windows.Forms.Label lbl_partySize;
        private System.Windows.Forms.Label lbl_tableNum;
        private System.Windows.Forms.Label lbl_arrivalTime;
        private System.Windows.Forms.Label lbl_EndTime;
    }
}