namespace MyATM
{
    partial class Transactions
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
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnToDashButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Description,
            this.Amount,
            this.AccountBalance});
            this.transactionsGrid.Location = new System.Drawing.Point(13, 13);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.Size = new System.Drawing.Size(445, 154);
            this.transactionsGrid.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // AccountBalance
            // 
            this.AccountBalance.DataPropertyName = "accountBalance";
            this.AccountBalance.HeaderText = "Account Balance";
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.ReadOnly = true;
            // 
            // returnToDashButton
            // 
            this.returnToDashButton.Location = new System.Drawing.Point(383, 173);
            this.returnToDashButton.Name = "returnToDashButton";
            this.returnToDashButton.Size = new System.Drawing.Size(75, 23);
            this.returnToDashButton.TabIndex = 1;
            this.returnToDashButton.Text = "Return";
            this.returnToDashButton.UseVisualStyleBackColor = true;
            this.returnToDashButton.Click += new System.EventHandler(this.returnToDashButton_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 210);
            this.Controls.Add(this.returnToDashButton);
            this.Controls.Add(this.transactionsGrid);
            this.Name = "Transactions";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.Button returnToDashButton;

    }
}