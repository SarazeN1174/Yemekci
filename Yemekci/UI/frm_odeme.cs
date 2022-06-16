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
    public partial class frm_odeme : Form
    {
        public frm_odeme()
        {
            InitializeComponent();
        }

        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btn_tm_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txt_müsteri)) return;
            if (!ErrorControl(dt_Tarih)) return;
            if (!ErrorControl(nmrc_tutar)) return;
            if (!ErrorControl(cmb_tur)) return;


            Odeme.MusteriID = Guid.Parse(txt_müsteri.Text);
            Odeme.Tur = cmb_tur.SelectedItem.ToString();
            Odeme.Tutar = (double)nmrc_tutar.Value;
            Odeme.Tarih = dt_Tarih.Value;


            DialogResult = DialogResult.OK;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

        private void frm_odeme_Load(object sender, EventArgs e)
        {
            txt_id.Text = Odeme.ID.ToString();
            if (Güncelleme)
            {
                txt_müsteri.Text = Odeme.MusteriID.ToString();
                nmrc_tutar.Value = (decimal)Odeme.Tutar;
                dt_Tarih.Value = Odeme.Tarih;
                cmb_tur.SelectedItem = Odeme.Tur;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Yemekci ymk = new Yemekci();
            if (ymk.ShowDialog() == DialogResult.OK)
            {
                txt_müsteri.Text = ymk.Musteri.ID.ToString();
            }
        }
    }
}
