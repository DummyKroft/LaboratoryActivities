
namespace CeilInnHotelManagement
{
    partial class PaymentEditor
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
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountDetails = new System.Windows.Forms.TextBox();
            this.dtpFirstDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.dtpLastDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.txtTotalNights = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneUse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmountCharged = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Date:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(144, 20);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPaymentDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Processed By: ___________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee #:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(144, 71);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(64, 20);
            this.txtEmployeeNumber.TabIndex = 4;
            this.txtEmployeeNumber.Leave += new System.EventHandler(this.txtEmployeeNumber_Leave);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(214, 71);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(130, 20);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Processed for Customer: ___________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account #:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(144, 119);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(64, 20);
            this.txtAccountNumber.TabIndex = 8;
            this.txtAccountNumber.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtOccupancyNumberLayout);
            this.txtAccountNumber.Leave += new System.EventHandler(this.txtOccupancyNumber_Leave);
            // 
            // txtAccountDetails
            // 
            this.txtAccountDetails.Location = new System.Drawing.Point(144, 145);
            this.txtAccountDetails.Name = "txtAccountDetails";
            this.txtAccountDetails.Size = new System.Drawing.Size(200, 20);
            this.txtAccountDetails.TabIndex = 9;
            // 
            // dtpFirstDateOccupied
            // 
            this.dtpFirstDateOccupied.Location = new System.Drawing.Point(144, 171);
            this.dtpFirstDateOccupied.Name = "dtpFirstDateOccupied";
            this.dtpFirstDateOccupied.Size = new System.Drawing.Size(200, 20);
            this.dtpFirstDateOccupied.TabIndex = 10;
            // 
            // dtpLastDateOccupied
            // 
            this.dtpLastDateOccupied.Location = new System.Drawing.Point(144, 197);
            this.dtpLastDateOccupied.Name = "dtpLastDateOccupied";
            this.dtpLastDateOccupied.Size = new System.Drawing.Size(200, 20);
            this.dtpLastDateOccupied.TabIndex = 11;
            // 
            // txtTotalNights
            // 
            this.txtTotalNights.Location = new System.Drawing.Point(242, 223);
            this.txtTotalNights.Name = "txtTotalNights";
            this.txtTotalNights.Size = new System.Drawing.Size(64, 20);
            this.txtTotalNights.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payment: _______________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Use:";
            // 
            // txtPhoneUse
            // 
            this.txtPhoneUse.Location = new System.Drawing.Point(81, 268);
            this.txtPhoneUse.Name = "txtPhoneUse";
            this.txtPhoneUse.Size = new System.Drawing.Size(44, 20);
            this.txtPhoneUse.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amt. Charged:";
            // 
            // txtAmountCharged
            // 
            this.txtAmountCharged.Location = new System.Drawing.Point(220, 268);
            this.txtAmountCharged.Name = "txtAmountCharged";
            this.txtAmountCharged.Size = new System.Drawing.Size(64, 20);
            this.txtAmountCharged.TabIndex = 17;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(220, 294);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(64, 20);
            this.txtSubTotal.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sub-Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "/night";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(155, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 23);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(189, 352);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(94, 20);
            this.txtTaxRate.TabIndex = 23;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(189, 378);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(94, 20);
            this.txtTaxAmount.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tax Amount:";
            // 
            // txtTotalAmountPaid
            // 
            this.txtTotalAmountPaid.Location = new System.Drawing.Point(189, 404);
            this.txtTotalAmountPaid.Name = "txtTotalAmountPaid";
            this.txtTotalAmountPaid.Size = new System.Drawing.Size(94, 20);
            this.txtTotalAmountPaid.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Amount Paid:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(337, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "_______________________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Receipt #:";
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Location = new System.Drawing.Point(75, 448);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(89, 20);
            this.txtReceiptNumber.TabIndex = 31;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(177, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 23);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PaymentEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(356, 479);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalAmountPaid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtAmountCharged);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhoneUse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalNights);
            this.Controls.Add(this.dtpLastDateOccupied);
            this.Controls.Add(this.dtpFirstDateOccupied);
            this.Controls.Add(this.txtAccountDetails);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentEditor";
            this.ShowInTaskbar = false;
            this.Text = "PaymentEditor";
            this.Load += new System.EventHandler(this.PaymentEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEmployeeNumber;
        public System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountDetails;
        public System.Windows.Forms.DateTimePicker dtpFirstDateOccupied;
        public System.Windows.Forms.DateTimePicker dtpLastDateOccupied;
        public System.Windows.Forms.TextBox txtTotalNights;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPhoneUse;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAmountCharged;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTaxRate;
        public System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtTotalAmountPaid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}