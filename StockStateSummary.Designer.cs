namespace SE3352_Assignment_2
{
    partial class StockStateSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummary));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChangePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.Symbol,
            this.OpenPrice,
            this.LastSale,
            this.ChangeNet,
            this.Image,
            this.ChangePercentage,
            this.ShareVolume});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 76;
            // 
            // Symbol
            // 
            this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.Width = 66;
            // 
            // OpenPrice
            // 
            this.OpenPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OpenPrice.HeaderText = "Open Price";
            this.OpenPrice.Name = "OpenPrice";
            this.OpenPrice.Width = 85;
            // 
            // LastSale
            // 
            this.LastSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LastSale.HeaderText = "Last Sale";
            this.LastSale.Name = "LastSale";
            this.LastSale.Width = 76;
            // 
            // ChangeNet
            // 
            this.ChangeNet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ChangeNet.HeaderText = "Change Net";
            this.ChangeNet.Name = "ChangeNet";
            this.ChangeNet.Width = 89;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Image.HeaderText = "  ";
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 5;
            // 
            // ChangePercentage
            // 
            this.ChangePercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ChangePercentage.HeaderText = "Change %";
            this.ChangePercentage.Name = "ChangePercentage";
            this.ChangePercentage.Width = 80;
            // 
            // ShareVolume
            // 
            this.ShareVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ShareVolume.HeaderText = "Share Volume";
            this.ShareVolume.Name = "ShareVolume";
            this.ShareVolume.Width = 98;
            // 
            // StockStateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 168);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummary";
            this.Text = "Stock State Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockStateSummary_FormClosed);
            this.Load += new System.EventHandler(this.StockStateSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeNet;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareVolume;
    }
}