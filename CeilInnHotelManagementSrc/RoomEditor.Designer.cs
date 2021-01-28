
namespace CeilInnHotelManagement
{
    partial class RoomEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.cbxBedType = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cbxOccupanciesStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(111, 15);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(182, 20);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(111, 41);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(182, 21);
            this.cbxRoomType.TabIndex = 2;
            // 
            // cbxBedType
            // 
            this.cbxBedType.FormattingEnabled = true;
            this.cbxBedType.Location = new System.Drawing.Point(111, 68);
            this.cbxBedType.Name = "cbxBedType";
            this.cbxBedType.Size = new System.Drawing.Size(182, 21);
            this.cbxBedType.TabIndex = 3;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(111, 95);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(182, 20);
            this.txtRate.TabIndex = 4;
            // 
            // cbxOccupanciesStatus
            // 
            this.cbxOccupanciesStatus.FormattingEnabled = true;
            this.cbxOccupanciesStatus.Location = new System.Drawing.Point(111, 121);
            this.cbxOccupanciesStatus.Name = "cbxOccupanciesStatus";
            this.cbxOccupanciesStatus.Size = new System.Drawing.Size(182, 21);
            this.cbxOccupanciesStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bed Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(111, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 194);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxOccupanciesStatus);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.cbxBedType);
            this.Controls.Add(this.cbxRoomType);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomEditor";
            this.Text = "RoomEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtRoomNumber;
        public System.Windows.Forms.ComboBox cbxRoomType;
        public System.Windows.Forms.ComboBox cbxBedType;
        public System.Windows.Forms.TextBox txtRate;
        public System.Windows.Forms.ComboBox cbxOccupanciesStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}