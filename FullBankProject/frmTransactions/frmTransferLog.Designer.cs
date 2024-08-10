namespace FullBankProject
{
    partial class frmTransferLog
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
            this.dgvGetTransferLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetTransferLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetTransferLog
            // 
            this.dgvGetTransferLog.AllowUserToAddRows = false;
            this.dgvGetTransferLog.AllowUserToDeleteRows = false;
            this.dgvGetTransferLog.AllowUserToOrderColumns = true;
            this.dgvGetTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetTransferLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGetTransferLog.Location = new System.Drawing.Point(0, 0);
            this.dgvGetTransferLog.Name = "dgvGetTransferLog";
            this.dgvGetTransferLog.ReadOnly = true;
            this.dgvGetTransferLog.RowHeadersWidth = 51;
            this.dgvGetTransferLog.RowTemplate.Height = 26;
            this.dgvGetTransferLog.Size = new System.Drawing.Size(682, 490);
            this.dgvGetTransferLog.TabIndex = 0;
            // 
            // frmTransferLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.dgvGetTransferLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferLog";
            this.Text = "frmTransferLog";
            this.Load += new System.EventHandler(this.frmTransferLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetTransferLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetTransferLog;
    }
}