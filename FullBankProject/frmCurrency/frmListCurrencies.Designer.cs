namespace FullBankProject
{
    partial class frmListCurrencies
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
            this.dgvListCurrencies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCurrencies
            // 
            this.dgvListCurrencies.AllowUserToAddRows = false;
            this.dgvListCurrencies.AllowUserToDeleteRows = false;
            this.dgvListCurrencies.AllowUserToOrderColumns = true;
            this.dgvListCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListCurrencies.Location = new System.Drawing.Point(0, 0);
            this.dgvListCurrencies.Name = "dgvListCurrencies";
            this.dgvListCurrencies.ReadOnly = true;
            this.dgvListCurrencies.RowHeadersWidth = 51;
            this.dgvListCurrencies.RowTemplate.Height = 26;
            this.dgvListCurrencies.Size = new System.Drawing.Size(682, 490);
            this.dgvListCurrencies.TabIndex = 0;
            // 
            // frmListCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.dgvListCurrencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListCurrencies";
            this.Text = "frmListCurrencies";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCurrencies;
    }
}