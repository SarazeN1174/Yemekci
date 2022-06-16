
namespace Yemekci
{
    partial class Yemekci
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yemekci));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_siparisver = new System.Windows.Forms.ToolStripButton();
            this.btn_odemeyap = new System.Windows.Forms.ToolStripButton();
            this.btn_mstrekle = new System.Windows.Forms.ToolStripButton();
            this.btn_yemekekle = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pg_yemek = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_ymkdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_ymksil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.pg_müsteri = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_mstrdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_mstrsil = new System.Windows.Forms.ToolStripButton();
            this.pg_siparis = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btn_sprsdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_sprssil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.pg_odeme = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.btn_odemedüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_odemesil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_tm = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pg_yemek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.pg_müsteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.pg_siparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.pg_odeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_siparisver,
            this.btn_odemeyap,
            this.btn_mstrekle,
            this.btn_yemekekle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_siparisver
            // 
            this.btn_siparisver.Image = ((System.Drawing.Image)(resources.GetObject("btn_siparisver.Image")));
            this.btn_siparisver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_siparisver.Name = "btn_siparisver";
            this.btn_siparisver.Size = new System.Drawing.Size(110, 32);
            this.btn_siparisver.Text = "Sipariş Ver";
            this.btn_siparisver.Click += new System.EventHandler(this.btn_siparisver_Click);
            // 
            // btn_odemeyap
            // 
            this.btn_odemeyap.Image = ((System.Drawing.Image)(resources.GetObject("btn_odemeyap.Image")));
            this.btn_odemeyap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_odemeyap.Name = "btn_odemeyap";
            this.btn_odemeyap.Size = new System.Drawing.Size(118, 32);
            this.btn_odemeyap.Text = "Ödeme Yap";
            this.btn_odemeyap.Click += new System.EventHandler(this.btn_odemeyap_Click);
            // 
            // btn_mstrekle
            // 
            this.btn_mstrekle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_mstrekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_mstrekle.Image")));
            this.btn_mstrekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mstrekle.Name = "btn_mstrekle";
            this.btn_mstrekle.Size = new System.Drawing.Size(121, 32);
            this.btn_mstrekle.Text = "Müşteri Ekle";
            this.btn_mstrekle.Click += new System.EventHandler(this.btn_mstrekle_Click);
            // 
            // btn_yemekekle
            // 
            this.btn_yemekekle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_yemekekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_yemekekle.Image")));
            this.btn_yemekekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yemekekle.Name = "btn_yemekekle";
            this.btn_yemekekle.Size = new System.Drawing.Size(115, 32);
            this.btn_yemekekle.Text = "Yemek Ekle";
            this.btn_yemekekle.Click += new System.EventHandler(this.btn_yemekekle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pg_yemek);
            this.tabControl1.Controls.Add(this.pg_müsteri);
            this.tabControl1.Controls.Add(this.pg_siparis);
            this.tabControl1.Controls.Add(this.pg_odeme);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 430);
            this.tabControl1.TabIndex = 1;
            // 
            // pg_yemek
            // 
            this.pg_yemek.Controls.Add(this.dataGridView2);
            this.pg_yemek.Controls.Add(this.toolStrip3);
            this.pg_yemek.Location = new System.Drawing.Point(4, 25);
            this.pg_yemek.Name = "pg_yemek";
            this.pg_yemek.Padding = new System.Windows.Forms.Padding(3);
            this.pg_yemek.Size = new System.Drawing.Size(824, 432);
            this.pg_yemek.TabIndex = 1;
            this.pg_yemek.Text = "Yemekler";
            this.pg_yemek.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(818, 399);
            this.dataGridView2.TabIndex = 2;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ymkdüzenle,
            this.btn_ymksil,
            this.toolStripButton5,
            this.toolStripTextBox2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(818, 27);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
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
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton4";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            // 
            // pg_müsteri
            // 
            this.pg_müsteri.Controls.Add(this.dataGridView1);
            this.pg_müsteri.Controls.Add(this.toolStrip2);
            this.pg_müsteri.Location = new System.Drawing.Point(4, 25);
            this.pg_müsteri.Name = "pg_müsteri";
            this.pg_müsteri.Padding = new System.Windows.Forms.Padding(3);
            this.pg_müsteri.Size = new System.Drawing.Size(800, 401);
            this.pg_müsteri.TabIndex = 0;
            this.pg_müsteri.Text = "Müşteriler";
            this.pg_müsteri.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 395);
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
            this.toolStrip2.Size = new System.Drawing.Size(794, 395);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_mstrdüzenle
            // 
            this.btn_mstrdüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_mstrdüzenle.Image")));
            this.btn_mstrdüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mstrdüzenle.Name = "btn_mstrdüzenle";
            this.btn_mstrdüzenle.Size = new System.Drawing.Size(85, 24);
            this.btn_mstrdüzenle.Text = "Düzenle";
            this.btn_mstrdüzenle.Click += new System.EventHandler(this.btn_mstrdüzenle_Click);
            // 
            // btn_mstrsil
            // 
            this.btn_mstrsil.Image = ((System.Drawing.Image)(resources.GetObject("btn_mstrsil.Image")));
            this.btn_mstrsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mstrsil.Name = "btn_mstrsil";
            this.btn_mstrsil.Size = new System.Drawing.Size(47, 24);
            this.btn_mstrsil.Text = "Sil";
            this.btn_mstrsil.Click += new System.EventHandler(this.btn_mstrsil_Click);
            // 
            // pg_siparis
            // 
            this.pg_siparis.Controls.Add(this.dataGridView3);
            this.pg_siparis.Controls.Add(this.toolStrip4);
            this.pg_siparis.Location = new System.Drawing.Point(4, 25);
            this.pg_siparis.Name = "pg_siparis";
            this.pg_siparis.Padding = new System.Windows.Forms.Padding(3);
            this.pg_siparis.Size = new System.Drawing.Size(824, 432);
            this.pg_siparis.TabIndex = 2;
            this.pg_siparis.Text = "Siparişler";
            this.pg_siparis.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(818, 399);
            this.dataGridView3.TabIndex = 3;
            // 
            // toolStrip4
            // 
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_sprsdüzenle,
            this.btn_sprssil,
            this.toolStripButton9,
            this.toolStripTextBox3});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(818, 27);
            this.toolStrip4.TabIndex = 2;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btn_sprsdüzenle
            // 
            this.btn_sprsdüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_sprsdüzenle.Image")));
            this.btn_sprsdüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sprsdüzenle.Name = "btn_sprsdüzenle";
            this.btn_sprsdüzenle.Size = new System.Drawing.Size(85, 24);
            this.btn_sprsdüzenle.Text = "Düzenle";
            this.btn_sprsdüzenle.Click += new System.EventHandler(this.btn_sprsdüzenle_Click);
            // 
            // btn_sprssil
            // 
            this.btn_sprssil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sprssil.Image")));
            this.btn_sprssil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sprssil.Name = "btn_sprssil";
            this.btn_sprssil.Size = new System.Drawing.Size(47, 24);
            this.btn_sprssil.Text = "Sil";
            this.btn_sprssil.Click += new System.EventHandler(this.btn_sprssil_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton9.Text = "toolStripButton4";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(200, 27);
            // 
            // pg_odeme
            // 
            this.pg_odeme.Controls.Add(this.dataGridView4);
            this.pg_odeme.Controls.Add(this.toolStrip5);
            this.pg_odeme.Location = new System.Drawing.Point(4, 25);
            this.pg_odeme.Name = "pg_odeme";
            this.pg_odeme.Padding = new System.Windows.Forms.Padding(3);
            this.pg_odeme.Size = new System.Drawing.Size(824, 432);
            this.pg_odeme.TabIndex = 3;
            this.pg_odeme.Text = "Ödemeler";
            this.pg_odeme.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 30);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(818, 399);
            this.dataGridView4.TabIndex = 3;
            // 
            // toolStrip5
            // 
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_odemedüzenle,
            this.btn_odemesil,
            this.toolStripButton12,
            this.toolStripTextBox4});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(818, 27);
            this.toolStrip5.TabIndex = 2;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // btn_odemedüzenle
            // 
            this.btn_odemedüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_odemedüzenle.Image")));
            this.btn_odemedüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_odemedüzenle.Name = "btn_odemedüzenle";
            this.btn_odemedüzenle.Size = new System.Drawing.Size(85, 24);
            this.btn_odemedüzenle.Text = "Düzenle";
            this.btn_odemedüzenle.Click += new System.EventHandler(this.btn_odemedüzenle_Click);
            // 
            // btn_odemesil
            // 
            this.btn_odemesil.Image = ((System.Drawing.Image)(resources.GetObject("btn_odemesil.Image")));
            this.btn_odemesil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_odemesil.Name = "btn_odemesil";
            this.btn_odemesil.Size = new System.Drawing.Size(47, 24);
            this.btn_odemesil.Text = "Sil";
            this.btn_odemesil.Click += new System.EventHandler(this.btn_odemesil_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton12.Text = "toolStripButton4";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(200, 27);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.Location = new System.Drawing.Point(726, 462);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 28);
            this.btn_iptal.TabIndex = 57;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_tm
            // 
            this.btn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tm.Location = new System.Drawing.Point(618, 462);
            this.btn_tm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(100, 28);
            this.btn_tm.TabIndex = 56;
            this.btn_tm.Text = "Tamam";
            this.btn_tm.UseVisualStyleBackColor = true;
            this.btn_tm.Click += new System.EventHandler(this.btn_tm_Click_1);
            // 
            // Yemekci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.btn_tm);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Yemekci";
            this.Text = "Yemekci";
            this.Load += new System.EventHandler(this.Yemekci_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pg_yemek.ResumeLayout(false);
            this.pg_yemek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.pg_müsteri.ResumeLayout(false);
            this.pg_müsteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pg_siparis.ResumeLayout(false);
            this.pg_siparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.pg_odeme.ResumeLayout(false);
            this.pg_odeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_siparisver;
        private System.Windows.Forms.ToolStripButton btn_odemeyap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pg_müsteri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_mstrdüzenle;
        private System.Windows.Forms.ToolStripButton btn_mstrsil;
        private System.Windows.Forms.TabPage pg_yemek;
        private System.Windows.Forms.TabPage pg_siparis;
        private System.Windows.Forms.TabPage pg_odeme;
        private System.Windows.Forms.ToolStripButton btn_mstrekle;
        private System.Windows.Forms.ToolStripButton btn_yemekekle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btn_ymkdüzenle;
        private System.Windows.Forms.ToolStripButton btn_ymksil;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btn_sprsdüzenle;
        private System.Windows.Forms.ToolStripButton btn_sprssil;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton btn_odemedüzenle;
        private System.Windows.Forms.ToolStripButton btn_odemesil;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tm;
    }
}

