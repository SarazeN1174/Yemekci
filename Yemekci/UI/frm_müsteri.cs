using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemekci.UI
{
    public partial class frm_müsteri : Form
    {
        public frm_müsteri()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btn_tm_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txt_Ad)) return;
            if (!ErrorControl(txt_Soyad)) return;
            if (!ErrorControl(txt_Tel)) return;
            if (!ErrorControl(txt_Mail)) return;
            if (!ErrorControl(txt_Adres)) return;

            Musteri.Ad = txt_Ad.Text;
            Musteri.Soyad = txt_Soyad.Text;
            Musteri.Telefon = txt_Tel.Text;
            Musteri.Mail = txt_Mail.Text;
            Musteri.Adres = txt_Adres.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_müsteri_Load(object sender, EventArgs e)
        {
            txt_id.Text = Musteri.ID.ToString();
            if (Güncelleme)
            {
                txt_Ad.Text = Musteri.Ad;
                txt_Soyad.Text = Musteri.Soyad;
                txt_Tel.Text = Musteri.Telefon;
                txt_Mail.Text = Musteri.Mail;
                txt_Adres.Text = Musteri.Adres;

            }
        }
    }
}
