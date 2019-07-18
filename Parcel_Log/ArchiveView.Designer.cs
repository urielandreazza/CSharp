namespace Parcel_Log
{
    partial class ArchiveView
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
            this.dgArchive = new System.Windows.Forms.DataGridView();
            this.delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArchive
            // 
            this.dgArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delivered,
            this.received,
            this.Qnt,
            this.resName,
            this.roomNum,
            this.email,
            this.box,
            this.contacted,
            this.staff,
            this.building,
            this.notes});
            this.dgArchive.Location = new System.Drawing.Point(3, 12);
            this.dgArchive.Name = "dgArchive";
            this.dgArchive.RowTemplate.Height = 24;
            this.dgArchive.Size = new System.Drawing.Size(1479, 711);
            this.dgArchive.TabIndex = 0;
            // 
            // delivered
            // 
            this.delivered.HeaderText = "Delivered";
            this.delivered.Name = "delivered";
            // 
            // received
            // 
            this.received.HeaderText = "Received";
            this.received.Name = "received";
            // 
            // Qnt
            // 
            this.Qnt.HeaderText = "Qnt";
            this.Qnt.Name = "Qnt";
            // 
            // resName
            // 
            this.resName.HeaderText = "Resident Name";
            this.resName.Name = "resName";
            // 
            // roomNum
            // 
            this.roomNum.HeaderText = "Room #";
            this.roomNum.Name = "roomNum";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // box
            // 
            this.box.HeaderText = "Box";
            this.box.Name = "box";
            // 
            // contacted
            // 
            this.contacted.HeaderText = "Contacted";
            this.contacted.Name = "contacted";
            // 
            // staff
            // 
            this.staff.HeaderText = "Staff";
            this.staff.Name = "staff";
            // 
            // building
            // 
            this.building.HeaderText = "Building";
            this.building.Name = "building";
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 735);
            this.Controls.Add(this.dgArchive);
            this.Name = "ArchiveView";
            this.Text = "ArchiveView";
            this.Load += new System.EventHandler(this.ArchiveView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn resName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn box;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}