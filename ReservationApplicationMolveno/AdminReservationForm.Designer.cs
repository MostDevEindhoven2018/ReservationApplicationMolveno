namespace ReservationApplicationMolveno
{
    partial class AdminReservationForm
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
            this.dgv_reservationsList = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reservationsList
            // 
            this.dgv_reservationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Party,
            this.GuestName,
            this.GuestPhone});
            this.dgv_reservationsList.Location = new System.Drawing.Point(12, 12);
            this.dgv_reservationsList.Name = "dgv_reservationsList";
            this.dgv_reservationsList.Size = new System.Drawing.Size(581, 150);
            this.dgv_reservationsList.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Party
            // 
            this.Party.HeaderText = "Party";
            this.Party.Name = "Party";
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "Guest Name";
            this.GuestName.Name = "GuestName";
            // 
            // GuestPhone
            // 
            this.GuestPhone.HeaderText = "Phone";
            this.GuestPhone.Name = "GuestPhone";
            // 
            // AdminReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.dgv_reservationsList);
            this.Name = "AdminReservationForm";
            this.Text = "AdminReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservationsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reservationsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestPhone;
    }
}