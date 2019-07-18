namespace Parcel_Log
{
    partial class parcelLog
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
            this.parcelGrid = new System.Windows.Forms.DataGridView();
            this.parcelReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countParcels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffInitials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listWatcher = new System.IO.FileSystemWatcher();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOnePlus = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcelGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWatcher)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parcelGrid
            // 
            this.parcelGrid.AllowUserToAddRows = false;
            this.parcelGrid.AllowUserToDeleteRows = false;
            this.parcelGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.parcelGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parcelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parcelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelReceived,
            this.countParcels,
            this.resident,
            this.suite,
            this.email,
            this.box,
            this.sent,
            this.staffInitials,
            this.building,
            this.notes});
            this.parcelGrid.Location = new System.Drawing.Point(3, 3);
            this.parcelGrid.MultiSelect = false;
            this.parcelGrid.Name = "parcelGrid";
            this.parcelGrid.ReadOnly = true;
            this.parcelGrid.RowTemplate.Height = 24;
            this.parcelGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parcelGrid.Size = new System.Drawing.Size(1228, 405);
            this.parcelGrid.TabIndex = 0;
            // 
            // parcelReceived
            // 
            this.parcelReceived.Frozen = true;
            this.parcelReceived.HeaderText = "Date Received";
            this.parcelReceived.Name = "parcelReceived";
            this.parcelReceived.ReadOnly = true;
            this.parcelReceived.Width = 130;
            // 
            // countParcels
            // 
            this.countParcels.Frozen = true;
            this.countParcels.HeaderText = "Qnt";
            this.countParcels.Name = "countParcels";
            this.countParcels.ReadOnly = true;
            this.countParcels.Width = 40;
            // 
            // resident
            // 
            this.resident.Frozen = true;
            this.resident.HeaderText = "Resident";
            this.resident.Name = "resident";
            this.resident.ReadOnly = true;
            this.resident.Width = 130;
            // 
            // suite
            // 
            this.suite.Frozen = true;
            this.suite.HeaderText = "Suite";
            this.suite.Name = "suite";
            this.suite.ReadOnly = true;
            this.suite.Width = 50;
            // 
            // email
            // 
            this.email.Frozen = true;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // box
            // 
            this.box.Frozen = true;
            this.box.HeaderText = "Box";
            this.box.Name = "box";
            this.box.ReadOnly = true;
            this.box.Width = 30;
            // 
            // sent
            // 
            this.sent.Frozen = true;
            this.sent.HeaderText = "Sent";
            this.sent.Name = "sent";
            this.sent.ReadOnly = true;
            this.sent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sent.Width = 36;
            // 
            // staffInitials
            // 
            this.staffInitials.Frozen = true;
            this.staffInitials.HeaderText = "Staff Initial";
            this.staffInitials.Name = "staffInitials";
            this.staffInitials.ReadOnly = true;
            this.staffInitials.Width = 50;
            // 
            // building
            // 
            this.building.HeaderText = "TRA";
            this.building.Name = "building";
            this.building.ReadOnly = true;
            this.building.Width = 50;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 200;
            // 
            // listWatcher
            // 
            this.listWatcher.EnableRaisingEvents = true;
            this.listWatcher.Path = "C:\\Users\\Uriel\\source\\repos\\Parcel_Log\\Parcel_Log\\bin\\Debug";
            this.listWatcher.SynchronizingObject = this;
            this.listWatcher.Changed += new System.IO.FileSystemEventHandler(this.listWatcher_Changed);
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(21, 21);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(65, 21);
            this.rbt1.TabIndex = 1;
            this.rbt1.Text = "TRA1";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(138, 21);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(65, 21);
            this.rbt2.TabIndex = 2;
            this.rbt2.Text = "TRA2";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbt2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(238, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Both";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(393, 91);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(90, 32);
            this.btnDeliver.TabIndex = 7;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(297, 91);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 32);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOnePlus
            // 
            this.btnOnePlus.Location = new System.Drawing.Point(105, 91);
            this.btnOnePlus.Name = "btnOnePlus";
            this.btnOnePlus.Size = new System.Drawing.Size(90, 32);
            this.btnOnePlus.TabIndex = 9;
            this.btnOnePlus.Text = "+1 Parcel";
            this.btnOnePlus.UseVisualStyleBackColor = true;
            this.btnOnePlus.Click += new System.EventHandler(this.btnOnePlus_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(489, 91);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(90, 32);
            this.btnSendEmail.TabIndex = 10;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(585, 91);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(90, 32);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.parcelGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1246, 405);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.Location = new System.Drawing.Point(201, 91);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(90, 32);
            this.btnMinusOne.TabIndex = 13;
            this.btnMinusOne.Text = "-1 Parcel";
            this.btnMinusOne.UseVisualStyleBackColor = true;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(681, 91);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(90, 32);
            this.btnArchive.TabIndex = 14;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // parcelLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 553);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnMinusOne);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnOnePlus);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "parcelLog";
            this.Text = "Parcel Log";
            this.Load += new System.EventHandler(this.parcelLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcelGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWatcher)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parcelGrid;
        private System.IO.FileSystemWatcher listWatcher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnOnePlus;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn countParcels;
        private System.Windows.Forms.DataGridViewTextBoxColumn resident;
        private System.Windows.Forms.DataGridViewTextBoxColumn suite;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn box;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sent;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffInitials;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.Button btnMinusOne;
        private System.Windows.Forms.Button btnArchive;
    }
}

