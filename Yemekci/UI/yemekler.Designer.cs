
namespace Yemekci.UI
{
    partial class yemekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yemekler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pg_yemek = new System.Windows.Forms.TabPage();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btbn_tm = new System.Windows.Forms.Button();
            this.dataGridViewymk = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_yemekekle = new System.Windows.Forms.ToolStripButton();
            this.btn_ymkdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_ymksil = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.pg_yemek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewymk)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pg_yemek);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // pg_yemek
            // 
            this.pg_yemek.Controls.Add(this.btn_iptal);
            this.pg_yemek.Controls.Add(this.btbn_tm);
            this.pg_yemek.Controls.Add(this.dataGridViewymk);
            this.pg_yemek.Controls.Add(this.toolStrip3);
            this.pg_yemek.Location = new System.Drawing.Point(4, 25);
            this.pg_yemek.Name = "pg_yemek";
            this.pg_yemek.Padding = new System.Windows.Forms.Padding(3);
            this.pg_yemek.Size = new System.Drawing.Size(792, 421);
            this.pg_yemek.TabIndex = 1;
            this.pg_yemek.Text = "Yemekler";
            this.pg_yemek.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.Location = new System.Drawing.Point(680, 380);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(104, 33);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // btbn_tm
            // 
            this.btbn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btbn_tm.Location = new System.Drawing.Point(570, 380);
            this.btbn_tm.Name = "btbn_tm";
            this.btbn_tm.Size = new System.Drawing.Size(104, 33);
            this.btbn_tm.TabIndex = 5;
            this.btbn_tm.Text = "Tamam";
            this.btbn_tm.UseVisualStyleBackColor = true;
            this.btbn_tm.Click += new System.EventHandler(this.btbn_tm_Click);
            // 
            // dataGridViewymk
            // 
            this.dataGridViewymk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewymk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewymk.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewymk.Name = "dataGridViewymk";
            this.dataGridViewymk.RowHeadersWidth = 51;
            this.dataGridViewymk.RowTemplate.Height = 24;
            this.dataGridViewymk.Size = new System.Drawing.Size(786, 388);
            this.dataGridViewymk.TabIndex = 2;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_yemekekle,
            this.btn_ymkdüzenle,
            this.btn_ymksil});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 27);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btn_yemekekle
            // 
            this.btn_yemekekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_yemekekle.Image")));
            this.btn_yemekekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yemekekle.Name = "btn_yemekekle";
            this.btn_yemekekle.Size = new System.Drawing.Size(58, 24);
            this.btn_yemekekle.Text = "Ekle";
            this.btn_yemekekle.Click += new System.EventHandler(this.btn_yemekekle_Click);
            // 
            // btn_ymkdüzenle
            // 
            this.btn_ymkdüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ymkdüzenle.Image")));
            this.btn_ymkdüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ymkdüzenle.Name = "btn_ymkdüzenle";
            this.btn_ymkdüzenle.Size = new System.Drawing.Size(85, 24);
            this.btn_ymkdüzenle.Text = "Düzenle";
            this.btn_ymkdüzenle.Click += new System.EventHandler(this.btn_ymkdüzenle_Click);
            // 
            // btn_ymksil
            // 
            this.btn_ymksil.Image = ((System.Drawing.Image)(resources.GetObject("btn_ymksil.Image")));
            this.btn_ymksil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ymksil.Name = "btn_ymksil";
            this.btn_ymksil.Size = new System.Drawing.Size(47, 24);
            this.btn_ymksil.Text = "Sil";
            this.btn_ymksil.Click += new System.EventHandler(this.btn_ymksil_Click);
            // 
            // yemekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "yemekler";
            this.Text = "yemekler";
            this.Load += new System.EventHandler(this.yemekler_Load);
            this.tabControl1.ResumeLayout(false);
            this.pg_yemek.ResumeLayout(false);
            this.pg_yemek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewymk)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pg_yemek;
        private System.Windows.Forms.DataGridView dataGridViewymk;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btn_ymkdüzenle;
        private System.Windows.Forms.ToolStripButton btn_ymksil;
        private System.Windows.Forms.ToolStripButton btn_yemekekle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btbn_tm;
    }
}