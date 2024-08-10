namespace FullBankProject
{
    partial class frmUpdateRate
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtRat1Dolar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrenciesName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodeOrCountry = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 343);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Rat1Dolar            :";
            // 
            // txtRat1Dolar
            // 
            this.txtRat1Dolar.Location = new System.Drawing.Point(202, 340);
            this.txtRat1Dolar.Name = "txtRat1Dolar";
            this.txtRat1Dolar.Size = new System.Drawing.Size(178, 24);
            this.txtRat1Dolar.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Currencies Name :";
            // 
            // txtCurrenciesName
            // 
            this.txtCurrenciesName.Enabled = false;
            this.txtCurrenciesName.Location = new System.Drawing.Point(202, 294);
            this.txtCurrenciesName.Name = "txtCurrenciesName";
            this.txtCurrenciesName.Size = new System.Drawing.Size(178, 24);
            this.txtCurrenciesName.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Code                   :";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(202, 245);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(178, 24);
            this.txtCode.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Country              :";
            // 
            // txtCountry
            // 
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(202, 200);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(178, 24);
            this.txtCountry.TabIndex = 56;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(457, 127);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 37);
            this.btnFind.TabIndex = 55;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Code  or Country:";
            // 
            // txtCodeOrCountry
            // 
            this.txtCodeOrCountry.Location = new System.Drawing.Point(203, 134);
            this.txtCodeOrCountry.Name = "txtCodeOrCountry";
            this.txtCodeOrCountry.Size = new System.Drawing.Size(178, 24);
            this.txtCodeOrCountry.TabIndex = 53;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRat1Dolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrenciesName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodeOrCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateRate";
            this.Text = "frmUpdateRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRat1Dolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrenciesName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodeOrCountry;
        private System.Windows.Forms.Button btnUpdate;
    }
}