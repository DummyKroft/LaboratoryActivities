
namespace CeilInnHotelManagement
{
    partial class Employees
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
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colEmployeeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwEmployees
            // 
            this.lvwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployeeNumber,
            this.colFirstName,
            this.colLastName,
            this.colTitle});
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.GridLines = true;
            this.lvwEmployees.HideSelection = false;
            this.lvwEmployees.Location = new System.Drawing.Point(12, 12);
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(456, 241);
            this.lvwEmployees.TabIndex = 0;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.Text = "Employee #";
            this.colEmployeeNumber.Width = 70;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 80;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 80;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwEmployees);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwEmployees;
        private System.Windows.Forms.ColumnHeader colEmployeeNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}