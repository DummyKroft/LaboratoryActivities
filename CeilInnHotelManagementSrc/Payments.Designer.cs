
namespace CeilInnHotelManagement
{
    partial class Payments
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
            this.lvwPayments = new System.Windows.Forms.ListView();
            this.colReceiptNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstDayOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastDayOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalNights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmountCharged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalAmountPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwPayments
            // 
            this.lvwPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReceiptNumber,
            this.colProcessedBy,
            this.colPaymentDate,
            this.colAccountNumber,
            this.colFirstDayOccupied,
            this.colLastDayOccupied,
            this.colTotalNights,
            this.colAmountCharged,
            this.colPhoneUse,
            this.colSubTotal,
            this.colTaxRate,
            this.colTaxAmount,
            this.colTotalAmountPaid});
            this.lvwPayments.FullRowSelect = true;
            this.lvwPayments.GridLines = true;
            this.lvwPayments.HideSelection = false;
            this.lvwPayments.Location = new System.Drawing.Point(12, 12);
            this.lvwPayments.Name = "lvwPayments";
            this.lvwPayments.Size = new System.Drawing.Size(626, 227);
            this.lvwPayments.TabIndex = 0;
            this.lvwPayments.UseCompatibleStateImageBehavior = false;
            this.lvwPayments.View = System.Windows.Forms.View.Details;
            // 
            // colReceiptNumber
            // 
            this.colReceiptNumber.Text = "Receipt #";
            // 
            // colProcessedBy
            // 
            this.colProcessedBy.Text = "Processed By";
            this.colProcessedBy.Width = 140;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Text = "Payment Date";
            this.colPaymentDate.Width = 130;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.Text = "Processed For";
            this.colAccountNumber.Width = 140;
            // 
            // colFirstDayOccupied
            // 
            this.colFirstDayOccupied.Text = "First Day Occupied";
            this.colFirstDayOccupied.Width = 140;
            // 
            // colLastDayOccupied
            // 
            this.colLastDayOccupied.Text = "Last Day Occupied";
            this.colLastDayOccupied.Width = 140;
            // 
            // colTotalNights
            // 
            this.colTotalNights.Text = "Total Nights";
            this.colTotalNights.Width = 70;
            // 
            // colAmountCharged
            // 
            this.colAmountCharged.Text = "Amt Charged";
            this.colAmountCharged.Width = 75;
            // 
            // colPhoneUse
            // 
            this.colPhoneUse.Text = "Phone Use";
            this.colPhoneUse.Width = 65;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Text = "Sub-Total";
            // 
            // colTaxRate
            // 
            this.colTaxRate.Text = "Tax Rate";
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Text = "Tax Amount";
            this.colTaxAmount.Width = 55;
            // 
            // colTotalAmountPaid
            // 
            this.colTotalAmountPaid.Text = "Amt Paid";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(527, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewPayment
            // 
            this.btnNewPayment.Location = new System.Drawing.Point(410, 245);
            this.btnNewPayment.Name = "btnNewPayment";
            this.btnNewPayment.Size = new System.Drawing.Size(111, 23);
            this.btnNewPayment.TabIndex = 2;
            this.btnNewPayment.Text = "New Payment";
            this.btnNewPayment.UseVisualStyleBackColor = true;
            this.btnNewPayment.Click += new System.EventHandler(this.btnNewPayment_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 276);
            this.Controls.Add(this.btnNewPayment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwPayments);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwPayments;
        private System.Windows.Forms.ColumnHeader colReceiptNumber;
        private System.Windows.Forms.ColumnHeader colProcessedBy;
        private System.Windows.Forms.ColumnHeader colPaymentDate;
        private System.Windows.Forms.ColumnHeader colAccountNumber;
        private System.Windows.Forms.ColumnHeader colFirstDayOccupied;
        private System.Windows.Forms.ColumnHeader colLastDayOccupied;
        private System.Windows.Forms.ColumnHeader colTotalNights;
        private System.Windows.Forms.ColumnHeader colAmountCharged;
        private System.Windows.Forms.ColumnHeader colPhoneUse;
        private System.Windows.Forms.ColumnHeader colSubTotal;
        private System.Windows.Forms.ColumnHeader colTaxRate;
        private System.Windows.Forms.ColumnHeader colTaxAmount;
        private System.Windows.Forms.ColumnHeader colTotalAmountPaid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewPayment;
    }
}