
namespace Yemekci.UI
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pg_müsteri = new System.Windows.Forms.TabPage();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btbn_tm = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_müsteriekle = new System.Windows.Forms.ToolStripButton();
            this.btn_müsteridüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_müsterisil = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_mstrdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_mstrsil = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.pg_müsteri.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pg_müsteri);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 440);
            this.tabControl1.TabIndex = 2;
            // 
            // pg_müsteri
            // 
            this.pg_müsteri.Controls.Add(this.btn_iptal);
            this.pg_müsteri.Controls.Add(this.btbn_tm);
            this.pg_müsteri.Controls.Add(this.toolStrip1);
            this.pg_müsteri.Controls.Add(this.dataGridView1);
            this.pg_müsteri.Controls.Add(this.toolStrip2);
            this.pg_müsteri.Location = new System.Drawing.Point(4, 25);
            this.pg_müsteri.Name = "pg_müsteri";
            this.pg_müsteri.Padding = new System.Windows.Forms.Padding(3);
            this.pg_müsteri.Size = new System.Drawing.Size(794, 411);
            this.pg_müsteri.TabIndex = 0;
            this.pg_müsteri.Text = "Müşteriler";
            this.pg_müsteri.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.Location = new System.Drawing.Point(677, 370);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(104, 33);
            this.btn_iptal.TabIndex = 4;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btbn_tm
            // 
            this.btbn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btbn_tm.Location = new System.Drawing.Point(567, 370);
            this.btbn_tm.Name = "btbn_tm";
            this.btbn_tm.Size = new System.Drawing.Size(104, 33);
            this.btbn_tm.TabIndex = 3;
            this.btbn_tm.Text = "Tamam";
            this.btbn_tm.UseVisualStyleBackColor = true;
            this.btbn_tm.Click += new System.EventHandler(this.btbn_tm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_müsteriekle,
            this.btn_müsteridüzenle,
            this.btn_müsterisil});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_müsteriekle
            // 
            this.btn_müsteriekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_müsteriekle.Image")));
            this.btn_müsteriekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_müsteriekle.Name = "btn_müsteriekle";
            this.btn_müsteriekle.Size = new System.Drawing.Size(60, 24);
            this.btn_müsteriekle.Text = "Ekle";
            this.btn_müsteriekle.Click += new System.EventHandler(this.btn_müsteriekle_Click);
            // 
            // btn_müsteridüzenle
            // 
            this.btn_müsteridüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_müsteridüzenle.Image")));
            this.btn_müsteridüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_müsteridüzenle.Name = "btn_müsteridüzenle";
            this.btn_müsteridüzenle.Size = new System.Drawing.Size(87, 24);
            this.btn_müsteridüzenle.Text = "Düzenle";
            this.btn_müsteridüzenle.Click += new System.EventHandler(this.btn_müsteridüzenle_Click);
            // 
            // btn_müsterisil
            // 
            this.btn_müsterisil.Image = ((System.Drawing.Image)(resources.GetObject("btn_müsterisil.Image")));
            this.btn_müsterisil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_müsterisil.Name = "btn_müsterisil";
            this.btn_müsterisil.Size = new System.Drawing.Size(49, 24);
            this.btn_müsterisil.Text = "Sil";
            this.btn_müsterisil.Click += new System.EventHandler(this.btn_müsterisil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 405);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_mstrdüzenle,
            this.btn_mstrsil});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(788, 405);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_mstrdüzenle
            // 
            this.btn_mstrdüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_mstrdüzenle.Image")));
            this.btn_mstrdüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mstrdüzenle.Name = "btn_mstrdüzenle";
            this.btn_mstrdüzenle.Size = new System.Drawing.Size(85, 402);
            this.btn_mstrdüzenle.Text = "Düzenle";
            // 
            // btn_mstrsil
            // 
            this.btn_mstrsil.Image = ((System.Drawing.Image)(resources.GetObject("btn_mstrsil.Image")));
            this.btn_mstrsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mstrsil.Name = "btn_mstrsil";
            this.btn_mstrsil.Size = new System.Drawing.Size(47, 402);
            this.btn_mstrsil.Text = "Sil";
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 440);
            this.Controls.Add(this.tabControl1);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.tabControl1.ResumeLayout(false);
            this.pg_müsteri.ResumeLayout(false);
            this.pg_müsteri.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pg_müsteri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_mstrdüzenle;
        private System.Windows.Forms.ToolStripButton btn_mstrsil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_müsteriekle;
        private System.Windows.Forms.ToolStripButton btn_müsteridüzenle;
        private System.Windows.Forms.ToolStripButton btn_müsterisil;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btbn_tm;
    }
}