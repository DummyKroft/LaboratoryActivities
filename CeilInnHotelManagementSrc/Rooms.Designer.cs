
namespace CeilInnHotelManagement
{
    partial class Rooms
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
            this.lvwRooms = new System.Windows.Forms.ListView();
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBedType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRooms
            // 
            this.lvwRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRoomType,
            this.colBedType,
            this.colRate,
            this.colAvailable});
            this.lvwRooms.FullRowSelect = true;
            this.lvwRooms.GridLines = true;
            this.lvwRooms.HideSelection = false;
            this.lvwRooms.Location = new System.Drawing.Point(12, 12);
            this.lvwRooms.Name = "lvwRooms";
            this.lvwRooms.Size = new System.Drawing.Size(445, 228);
            this.lvwRooms.TabIndex = 0;
            this.lvwRooms.UseCompatibleStateImageBehavior = false;
            this.lvwRooms.View = System.Windows.Forms.View.Details;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Room #";
            // 
            // colRoomType
            // 
            this.colRoomType.Text = "Room Type";
            this.colRoomType.Width = 100;
            // 
            // colBedType
            // 
            this.colBedType.Text = "Bed Type";
            this.colBedType.Width = 80;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            // 
            // colAvailable
            // 
            this.colAvailable.Text = "Status";
            this.colAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAvailable.Width = 65;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(233, 255);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(109, 23);
            this.btnNewRoom.TabIndex = 1;
            this.btnNewRoom.Text = "New Room";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 293);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.lvwRooms);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRooms;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomType;
        private System.Windows.Forms.ColumnHeader colBedType;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colAvailable;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Button btnClose;
    }
}