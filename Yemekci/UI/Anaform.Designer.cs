
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
            this.btn_müsteriler = new System.Windows.Forms.ToolStripButton();
            this.btn_yemekler = new System.Windows.Forms.ToolStripButton();
            this.pg_odeme = new System.Windows.Forms.TabPage();
            this.dataGridViewodeme = new System.Windows.Forms.DataGridView();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.btn_odemedüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_odemesil = new System.Windows.Forms.ToolStripButton();
            this.pg_siparis = new System.Windows.Forms.TabPage();
            this.dataGridViewsiparis = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btn_sprsdüzenle = new System.Windows.Forms.ToolStripButton();
            this.btn_sprssil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.pg_odeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewodeme)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.pg_siparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparis)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_siparisver,
            this.btn_odemeyap,
            this.btn_müsteriler,
            this.btn_yemekler});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_siparisver
            // 
            this.btn_siparisver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_siparisver.Image = ((System.Drawing.Image)(resources.GetObject("btn_siparisver.Image")));
            this.btn_siparisver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_siparisver.Name = "btn_siparisver";
            this.btn_siparisver.Size = new System.Drawing.Size(82, 24);
            this.btn_siparisver.Text = "Sipariş Ver";
            this.btn_siparisver.Click += new System.EventHandler(this.btn_siparisver_Click);
            // 
            // btn_odemeyap
            // 
            this.btn_odemeyap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_odemeyap.Image = ((System.Drawing.Image)(resources.GetObject("btn_odemeyap.Image")));
            this.btn_odemeyap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_odemeyap.Name = "btn_odemeyap";
            this.btn_odemeyap.Size = new System.Drawing.Size(90, 24);
            this.btn_odemeyap.Text = "Ödeme Yap";
            this.btn_odemeyap.Click += new System.EventHandler(this.btn_odemeyap_Click);
            // 
            // btn_müsteriler
            // 
            this.btn_müsteriler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_müsteriler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_müsteriler.Image = ((System.Drawing.Image)(resources.GetObject("btn_müsteriler.Image")));
            this.btn_müsteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_müsteriler.Name = "btn_müsteriler";
            this.btn_müsteriler.Size = new System.Drawing.Size(79, 24);
            this.btn_müsteriler.Text = "Müşteriler";
            this.btn_müsteriler.Click += new System.EventHandler(this.btn_müsteriler_Click);
            // 
            // btn_yemekler
            // 
            this.btn_yemekler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_yemekler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_yemekler.Image = ((System.Drawing.Image)(resources.GetObject("btn_yemekler.Image")));
            this.btn_yemekler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yemekler.Name = "btn_yemekler";
            this.btn_yemekler.Size = new System.Drawing.Size(73, 24);
            this.btn_yemekler.Text = "Yemekler";
            this.btn_yemekler.Click += new System.EventHandler(this.btn_yemekler_Click);
            // 
            // pg_odeme
            // 
            this.pg_odeme.Controls.Add(this.dataGridViewodeme);
            this.pg_odeme.Controls.Add(this.toolStrip5);
            this.pg_odeme.Location = new System.Drawing.Point(4, 25);
            this.pg_odeme.Name = "pg_odeme";
            this.pg_odeme.Padding = new System.Windows.Forms.Padding(3);
            this.pg_odeme.Size = new System.Drawing.Size(831, 439);
            this.pg_odeme.TabIndex = 3;
            this.pg_odeme.Text = "Ödemeler";
            this.pg_odeme.UseVisualStyleBackColor = true;
            // 
            // dataGridViewodeme
            // 
            this.dataGridViewodeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewodeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewodeme.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewodeme.Name = "dataGridViewodeme";
            this.dataGridViewodeme.RowHeadersWidth = 51;
            this.dataGridViewodeme.RowTemplate.Height = 24;
            this.dataGridViewodeme.Size = new System.Drawing.Size(825, 406);
            this.dataGridViewodeme.TabIndex = 3;
            // 
            // toolStrip5
            // 
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_odemedüzenle,
            this.btn_odemesil});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(825, 27);
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
            // pg_siparis
            // 
            this.pg_siparis.Controls.Add(this.dataGridViewsiparis);
            this.pg_siparis.Controls.Add(this.toolStrip4);
            this.pg_siparis.Location = new System.Drawing.Point(4, 25);
            this.pg_siparis.Name = "pg_siparis";
            this.pg_siparis.Padding = new System.Windows.Forms.Padding(3);
            this.pg_siparis.Size = new System.Drawing.Size(831, 439);
            this.pg_siparis.TabIndex = 2;
            this.pg_siparis.Text = "Siparişler";
            this.pg_siparis.UseVisualStyleBackColor = true;
            // 
            // dataGridViewsiparis
            // 
            this.dataGridViewsiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsiparis.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewsiparis.Name = "dataGridViewsiparis";
            this.dataGridViewsiparis.RowHeadersWidth = 51;
            this.dataGridViewsiparis.RowTemplate.Height = 24;
            this.dataGridViewsiparis.Size = new System.Drawing.Size(825, 406);
            this.dataGridViewsiparis.TabIndex = 3;
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
            this.toolStrip4.Size = new System.Drawing.Size(825, 27);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pg_siparis);
            this.tabControl1.Controls.Add(this.pg_odeme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 468);
            this.tabControl1.TabIndex = 1;
            // 
            // Yemekci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Yemekci";
            this.Text = "Yemekci";
            this.Load += new System.EventHandler(this.Yemekci_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pg_odeme.ResumeLayout(false);
            this.pg_odeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewodeme)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.pg_siparis.ResumeLayout(false);
            this.pg_siparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparis)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_siparisver;
        private System.Windows.Forms.ToolStripButton btn_odemeyap;
        private System.Windows.Forms.ToolStripButton btn_müsteriler;
        private System.Windows.Forms.ToolStripButton btn_yemekler;
        private System.Windows.Forms.TabPage pg_odeme;
        private System.Windows.Forms.DataGridView dataGridViewodeme;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton btn_odemedüzenle;
        private System.Windows.Forms.ToolStripButton btn_odemesil;
        private System.Windows.Forms.TabPage pg_siparis;
        private System.Windows.Forms.DataGridView dataGridViewsiparis;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btn_sprsdüzenle;
        private System.Windows.Forms.ToolStripButton btn_sprssil;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

