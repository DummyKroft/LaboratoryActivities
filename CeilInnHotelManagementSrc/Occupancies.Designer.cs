
namespace CeilInnHotelManagement
{
    partial class Occupancies
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
            this.lvwOccupancies = new System.Windows.Forms.ListView();
            this.colOccupancyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedFor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRateApplied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewOccupancy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwOccupancies
            // 
            this.lvwOccupancies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOccupancyNumber,
            this.colDateOccupied,
            this.colProcessedBy,
            this.colProcessedFor,
            this.colRoomOccupied,
            this.colRateApplied,
            this.colPhoneUse});
            this.lvwOccupancies.FullRowSelect = true;
            this.lvwOccupancies.GridLines = true;
            this.lvwOccupancies.HideSelection = false;
            this.lvwOccupancies.Location = new System.Drawing.Point(12, 12);
            this.lvwOccupancies.Name = "lvwOccupancies";
            this.lvwOccupancies.Size = new System.Drawing.Size(867, 278);
            this.lvwOccupancies.TabIndex = 0;
            this.lvwOccupancies.UseCompatibleStateImageBehavior = false;
            this.lvwOccupancies.View = System.Windows.Forms.View.Details;
            // 
            // colOccupancyNumber
            // 
            this.colOccupancyNumber.Text = "Occupancy #";
            this.colOccupancyNumber.Width = 80;
            // 
            // colDateOccupied
            // 
            this.colDateOccupied.Width = 150;
            // 
            // colProcessedBy
            // 
            this.colProcessedBy.Width = 140;
            // 
            // colProcessedFor
            // 
            this.colProcessedFor.Width = 140;
            // 
            // colRoomOccupied
            // 
            this.colRoomOccupied.Width = 180;
            // 
            // colRateApplied
            // 
            this.colRateApplied.Text = "Rate Applied";
            this.colRateApplied.Width = 80;
            // 
            // colPhoneUse
            // 
            this.colPhoneUse.Text = "Phone Use";
            this.colPhoneUse.Width = 65;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(752, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewOccupancy
            // 
            this.btnNewOccupancy.Location = new System.Drawing.Point(619, 296);
            this.btnNewOccupancy.Name = "btnNewOccupancy";
            this.btnNewOccupancy.Size = new System.Drawing.Size(127, 23);
            this.btnNewOccupancy.TabIndex = 2;
            this.btnNewOccupancy.Text = "New Occupancy";
            this.btnNewOccupancy.UseVisualStyleBackColor = true;
            this.btnNewOccupancy.Click += new System.EventHandler(this.btnNewOccupancy_Click);
            // 
            // Occupancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 332);
            this.Controls.Add(this.btnNewOccupancy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwOccupancies);
            this.Name = "Occupancies";
            this.Text = "Occupancies";
            this.Load += new System.EventHandler(this.Occupancies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwOccupancies;
        private System.Windows.Forms.ColumnHeader colOccupancyNumber;
        private System.Windows.Forms.ColumnHeader colDateOccupied;
        private System.Windows.Forms.ColumnHeader colProcessedBy;
        private System.Windows.Forms.ColumnHeader colProcessedFor;
        private System.Windows.Forms.ColumnHeader colRoomOccupied;
        private System.Windows.Forms.ColumnHeader colRateApplied;
        private System.Windows.Forms.ColumnHeader colPhoneUse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewOccupancy;
    }
}