using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekci.DL;

namespace Yemekci.UI
{
    public partial class frm_siparis : Form
    {
        public frm_siparis()
        {
            InitializeComponent();
        }

        public Siparis Siparis { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btn_tm_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textBox1)) return;
            if (!ErrorControl(textBox1)) return;
            if (!ErrorControl(nmrc_fiyat)) return;
            if (!ErrorControl(dt_tarih)) return;

            Siparis.MusteriID = Guid.Parse(textBox1.Text);
            Siparis.YemekID = Guid.Parse(textBox2.Text);
            Siparis.Tarih = dt_tarih.Value;
            Siparis.Fiyat = (double)nmrc_fiyat.Value;

            DialogResult = DialogResult.OK;

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
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

        private void btn_MüşteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.Musteri.ID.ToString();
            }

        }

        private void btn_yemeksec_Click(object sender, EventArgs e)
        {
            yemekler frm = new yemekler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = frm.Yemek.ID.ToString();
            }
        }
    }
}
