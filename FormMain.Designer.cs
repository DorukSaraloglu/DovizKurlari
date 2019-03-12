namespace DovizKurlari
{
    partial class FormMain
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
            this.lbxCurrency = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.DovizAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCurrency
            // 
            this.lbxCurrency.FormattingEnabled = true;
            this.lbxCurrency.Location = new System.Drawing.Point(28, 25);
            this.lbxCurrency.Name = "lbxCurrency";
            this.lbxCurrency.Size = new System.Drawing.Size(141, 212);
            this.lbxCurrency.TabIndex = 0;
            this.lbxCurrency.SelectedIndexChanged += new System.EventHandler(this.lstBoxDoviz_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(28, 261);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 36);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Yükle";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Location = new System.Drawing.Point(361, 25);
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.Size = new System.Drawing.Size(427, 188);
            this.dgvCurrency.TabIndex = 2;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DovizAd,
            this.Satis});
            this.dgvList.Location = new System.Drawing.Point(361, 243);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(427, 195);
            this.dgvList.TabIndex = 2;
            // 
            // DovizAd
            // 
            this.DovizAd.HeaderText = "DovizAd";
            this.DovizAd.Name = "DovizAd";
            // 
            // Satis
            // 
            this.Satis.HeaderText = "Satis";
            this.Satis.Name = "Satis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Döv. Alış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Döv. Satış";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(292, 25);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(13, 13);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "0";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(292, 101);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(13, 13);
            this.lblSale.TabIndex = 3;
            this.lblSale.Text = "0";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(292, 63);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(13, 13);
            this.lblPurchase.TabIndex = 3;
            this.lblPurchase.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.dgvCurrency);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbxCurrency);
            this.Name = "FormMain";
            this.Text = "Döviz Kurları Data Source";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCurrency;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovizAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satis;
    }
}

