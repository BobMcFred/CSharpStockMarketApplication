namespace SE3352_Assignment_2
{
    partial class MarketByPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketByPrice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyNum,
            this.BuyVolume,
            this.BuyPrice,
            this.SellPrice,
            this.SellVolume,
            this.SellNum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // BuyNum
            // 
            this.BuyNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BuyNum.HeaderText = "#    ";
            this.BuyNum.Name = "BuyNum";
            this.BuyNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BuyNum.Width = 29;
            // 
            // BuyVolume
            // 
            this.BuyVolume.HeaderText = "Volume";
            this.BuyVolume.Name = "BuyVolume";
            this.BuyVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Price";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Price";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SellVolume
            // 
            this.SellVolume.HeaderText = "Volume";
            this.SellVolume.Name = "SellVolume";
            this.SellVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SellNum
            // 
            this.SellNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SellNum.HeaderText = "#     ";
            this.SellNum.Name = "SellNum";
            this.SellNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SellNum.Width = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sell";
            // 
            // MarketByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByPrice";
            this.Text = "MarketByPrice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarketByPrice_FormClosed);
            this.Load += new System.EventHandler(this.MarketByPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}