
namespace CeilInnHotelManagement
{
    partial class Customers
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lvwCustomers = new System.Windows.Forms.ListView();
            this.colAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmergencyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmergencyPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCustomers
            // 
            this.lvwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountNumber,
            this.colFirstName,
            this.colLastName,
            this.colPhoneNumber,
            this.colEmergencyName,
            this.colEmergencyPhone});
            this.lvwCustomers.FullRowSelect = true;
            this.lvwCustomers.GridLines = true;
            this.lvwCustomers.HideSelection = false;
            this.lvwCustomers.Location = new System.Drawing.Point(12, 12);
            this.lvwCustomers.Name = "lvwCustomers";
            this.lvwCustomers.Size = new System.Drawing.Size(542, 250);
            this.lvwCustomers.TabIndex = 0;
            this.lvwCustomers.UseCompatibleStateImageBehavior = false;
            this.lvwCustomers.View = System.Windows.Forms.View.Details;
            this.lvwCustomers.SelectedIndexChanged += new System.EventHandler(this.lvwCustomers_SelectedIndexChanged);
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.Text = "Account #";
            this.colAccountNumber.Width = 70;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 65;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 65;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phone #";
            this.colPhoneNumber.Width = 80;
            // 
            // colEmergencyName
            // 
            this.colEmergencyName.Text = "Emergency Name";
            this.colEmergencyName.Width = 100;
            // 
            // colEmergencyPhone
            // 
            this.colEmergencyPhone.Text = "Emergency Phone";
            this.colEmergencyPhone.Width = 100;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(479, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(354, 271);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(119, 23);
            this.btnNewCustomer.TabIndex = 2;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 306);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvwCustomers;
        private System.Windows.Forms.ColumnHeader colAccountNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.ColumnHeader colEmergencyName;
        private System.Windows.Forms.ColumnHeader colEmergencyPhone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewCustomer;
    }
}