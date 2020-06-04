namespace Speech_Recognition
{
    partial class Info
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
            this.Back = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trevelingTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.economyClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(23, 435);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 29);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatReservationToolStripMenuItem,
            this.trevelingTypeToolStripMenuItem,
            this.selectPlaceToolStripMenuItem,
            this.cancelReservationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // seatReservationToolStripMenuItem
            // 
            this.seatReservationToolStripMenuItem.Name = "seatReservationToolStripMenuItem";
            this.seatReservationToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.seatReservationToolStripMenuItem.Text = "Seat Reservation";
            this.seatReservationToolStripMenuItem.Click += new System.EventHandler(this.SeatReservationToolStripMenuItem_Click);
            // 
            // trevelingTypeToolStripMenuItem
            // 
            this.trevelingTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstClassToolStripMenuItem,
            this.businessClassToolStripMenuItem,
            this.economyClassToolStripMenuItem});
            this.trevelingTypeToolStripMenuItem.Name = "trevelingTypeToolStripMenuItem";
            this.trevelingTypeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.trevelingTypeToolStripMenuItem.Text = "Treveling Type";
            // 
            // firstClassToolStripMenuItem
            // 
            this.firstClassToolStripMenuItem.Name = "firstClassToolStripMenuItem";
            this.firstClassToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.firstClassToolStripMenuItem.Text = "First Class";
            // 
            // businessClassToolStripMenuItem
            // 
            this.businessClassToolStripMenuItem.Name = "businessClassToolStripMenuItem";
            this.businessClassToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.businessClassToolStripMenuItem.Text = "Business Class";
            // 
            // economyClassToolStripMenuItem
            // 
            this.economyClassToolStripMenuItem.Name = "economyClassToolStripMenuItem";
            this.economyClassToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.economyClassToolStripMenuItem.Text = "Economy Class";
            // 
            // selectPlaceToolStripMenuItem
            // 
            this.selectPlaceToolStripMenuItem.Name = "selectPlaceToolStripMenuItem";
            this.selectPlaceToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.selectPlaceToolStripMenuItem.Text = "Select Place";
            this.selectPlaceToolStripMenuItem.Click += new System.EventHandler(this.SelectPlaceToolStripMenuItem_Click);
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Reservation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 336);
            this.dataGridView1.TabIndex = 8;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1111, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Info_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trevelingTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem economyClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}