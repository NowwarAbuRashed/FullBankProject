namespace FullBankProject
{
    partial class frmShowClientList
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
            this.dgvGetAllCliantData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllCliantData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetAllCliantData
            // 
            this.dgvGetAllCliantData.AllowUserToAddRows = false;
            this.dgvGetAllCliantData.AllowUserToDeleteRows = false;
            this.dgvGetAllCliantData.AllowUserToOrderColumns = true;
            this.dgvGetAllCliantData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllCliantData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGetAllCliantData.Location = new System.Drawing.Point(0, 0);
            this.dgvGetAllCliantData.Name = "dgvGetAllCliantData";
            this.dgvGetAllCliantData.ReadOnly = true;
            this.dgvGetAllCliantData.RowHeadersWidth = 51;
            this.dgvGetAllCliantData.RowTemplate.Height = 26;
            this.dgvGetAllCliantData.Size = new System.Drawing.Size(682, 484);
            this.dgvGetAllCliantData.TabIndex = 1;
            // 
            // frmShowClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 484);
            this.Controls.Add(this.dgvGetAllCliantData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowClientList";
            this.Text = "frmShowClientList";
            this.Load += new System.EventHandler(this.frmShowClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllCliantData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGetAllCliantData;
    }
}