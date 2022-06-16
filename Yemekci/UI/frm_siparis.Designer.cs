
namespace Yemekci.UI
{
    partial class frm_siparis
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
            this.btn_yemeksec = new System.Windows.Forms.Button();
            this.btn_MüşteriSeç = new System.Windows.Forms.Button();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.nmrc_fiyat = new System.Windows.Forms.NumericUpDown();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_tm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yemeksec
            // 
            this.btn_yemeksec.Location = new System.Drawing.Point(78, 166);
            this.btn_yemeksec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yemeksec.Name = "btn_yemeksec";
            this.btn_yemeksec.Size = new System.Drawing.Size(300, 28);
            this.btn_yemeksec.TabIndex = 44;
            this.btn_yemeksec.Text = "Listeden Seç";
            this.btn_yemeksec.UseVisualStyleBackColor = true;
            this.btn_yemeksec.Click += new System.EventHandler(this.btn_yemeksec_Click);
            // 
            // btn_MüşteriSeç
            // 
            this.btn_MüşteriSeç.Location = new System.Drawing.Point(78, 85);
            this.btn_MüşteriSeç.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MüşteriSeç.Name = "btn_MüşteriSeç";
            this.btn_MüşteriSeç.Size = new System.Drawing.Size(300, 28);
            this.btn_MüşteriSeç.TabIndex = 45;
            this.btn_MüşteriSeç.Text = "Listeden Seç";
            this.btn_MüşteriSeç.UseVisualStyleBackColor = true;
            this.btn_MüşteriSeç.Click += new System.EventHandler(this.btn_MüşteriSeç_Click);
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(79, 255);
            this.dt_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(300, 22);
            this.dt_tarih.TabIndex = 36;
            // 
            // nmrc_fiyat
            // 
            this.nmrc_fiyat.Location = new System.Drawing.Point(79, 225);
            this.nmrc_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_fiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrc_fiyat.Name = "nmrc_fiyat";
            this.nmrc_fiyat.Size = new System.Drawing.Size(301, 22);
            this.nmrc_fiyat.TabIndex = 35;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_iptal.Location = new System.Drawing.Point(312, 312);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 28);
            this.btn_iptal.TabIndex = 38;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_tm
            // 
            this.btn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_tm.Location = new System.Drawing.Point(201, 312);
            this.btn_tm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(100, 28);
            this.btn_tm.TabIndex = 37;
            this.btn_tm.Text = "Tamam";
            this.btn_tm.UseVisualStyleBackColor = true;
            this.btn_tm.Click += new System.EventHandler(this.btn_tm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Yemek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Müşteri";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(77, 13);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(300, 22);
            this.txt_id.TabIndex = 32;
            this.txt_id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 24);
            this.comboBox1.TabIndex = 46;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 24);
            this.comboBox2.TabIndex = 47;
            // 
            // frm_siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 353);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_yemeksec);
            this.Controls.Add(this.btn_MüşteriSeç);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.nmrc_fiyat);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_tm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "frm_siparis";
            this.Text = "frm_siparis";
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yemeksec;
        private System.Windows.Forms.Button btn_MüşteriSeç;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.NumericUpDown nmrc_fiyat;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}