
namespace Yemekci.UI
{
    partial class frm_odeme
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
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Tarih = new System.Windows.Forms.DateTimePicker();
            this.nmrc_tutar = new System.Windows.Forms.NumericUpDown();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_tm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_müsteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_tutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMüşteriSeç.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMüşteriSeç.Location = new System.Drawing.Point(99, 86);
            this.btnMüşteriSeç.Margin = new System.Windows.Forms.Padding(4);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(301, 28);
            this.btnMüşteriSeç.TabIndex = 62;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = true;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // cmb_tur
            // 
            this.cmb_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Banka Ödemesi"});
            this.cmb_tur.Location = new System.Drawing.Point(100, 203);
            this.cmb_tur.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(300, 24);
            this.cmb_tur.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Ödeme Türü";
            // 
            // dt_Tarih
            // 
            this.dt_Tarih.Location = new System.Drawing.Point(100, 138);
            this.dt_Tarih.Margin = new System.Windows.Forms.Padding(4);
            this.dt_Tarih.Name = "dt_Tarih";
            this.dt_Tarih.Size = new System.Drawing.Size(300, 22);
            this.dt_Tarih.TabIndex = 50;
            // 
            // nmrc_tutar
            // 
            this.nmrc_tutar.Location = new System.Drawing.Point(100, 171);
            this.nmrc_tutar.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_tutar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrc_tutar.Name = "nmrc_tutar";
            this.nmrc_tutar.Size = new System.Drawing.Size(301, 22);
            this.nmrc_tutar.TabIndex = 51;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.Location = new System.Drawing.Point(331, 288);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 28);
            this.btn_iptal.TabIndex = 55;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_tm
            // 
            this.btn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tm.Location = new System.Drawing.Point(223, 288);
            this.btn_tm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(100, 28);
            this.btn_tm.TabIndex = 54;
            this.btn_tm.Text = "Tamam";
            this.btn_tm.UseVisualStyleBackColor = true;
            this.btn_tm.Click += new System.EventHandler(this.btn_tm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tutar";
            // 
            // txt_müsteri
            // 
            this.txt_müsteri.Location = new System.Drawing.Point(100, 56);
            this.txt_müsteri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_müsteri.Name = "txt_müsteri";
            this.txt_müsteri.ReadOnly = true;
            this.txt_müsteri.Size = new System.Drawing.Size(300, 22);
            this.txt_müsteri.TabIndex = 49;
            this.txt_müsteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Müşteri";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(100, 24);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(300, 22);
            this.txt_id.TabIndex = 48;
            this.txt_id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 329);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.cmb_tur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Tarih);
            this.Controls.Add(this.nmrc_tutar);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_tm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_müsteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "frm_odeme";
            this.Text = "frm_odeme";
            this.Load += new System.EventHandler(this.frm_odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_tutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMüşteriSeç;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Tarih;
        private System.Windows.Forms.NumericUpDown nmrc_tutar;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_müsteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}