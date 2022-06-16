
namespace Yemekci.UI
{
    partial class frm_yemek
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
            this.components = new System.ComponentModel.Container();
            this.nmrc_fiyat = new System.Windows.Forms.NumericUpDown();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_tm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yemekadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ayrıntı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrc_fiyat
            // 
            this.nmrc_fiyat.Location = new System.Drawing.Point(107, 131);
            this.nmrc_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_fiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrc_fiyat.Name = "nmrc_fiyat";
            this.nmrc_fiyat.Size = new System.Drawing.Size(258, 22);
            this.nmrc_fiyat.TabIndex = 18;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(107, 99);
            this.cmb_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(258, 24);
            this.cmb_kategori.TabIndex = 17;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_iptal.Location = new System.Drawing.Point(280, 320);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 28);
            this.btn_iptal.TabIndex = 23;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_tm
            // 
            this.btn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_tm.Location = new System.Drawing.Point(173, 320);
            this.btn_tm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(100, 28);
            this.btn_tm.TabIndex = 22;
            this.btn_tm.Text = "Tamam";
            this.btn_tm.UseVisualStyleBackColor = true;
            this.btn_tm.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kategori";
            // 
            // txt_yemekadi
            // 
            this.txt_yemekadi.Location = new System.Drawing.Point(107, 67);
            this.txt_yemekadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yemekadi.Name = "txt_yemekadi";
            this.txt_yemekadi.Size = new System.Drawing.Size(258, 22);
            this.txt_yemekadi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Yemek Adı";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(107, 35);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(258, 22);
            this.txt_id.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // txt_ayrıntı
            // 
            this.txt_ayrıntı.Location = new System.Drawing.Point(107, 161);
            this.txt_ayrıntı.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ayrıntı.Multiline = true;
            this.txt_ayrıntı.Name = "txt_ayrıntı";
            this.txt_ayrıntı.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ayrıntı.Size = new System.Drawing.Size(258, 107);
            this.txt_ayrıntı.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ayrıntı";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_yemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 363);
            this.Controls.Add(this.txt_ayrıntı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmrc_fiyat);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_tm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yemekadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "frm_yemek";
            this.Text = "frm_yemek";
            this.Load += new System.EventHandler(this.frm_yemek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmrc_fiyat;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yemekadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ayrıntı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}