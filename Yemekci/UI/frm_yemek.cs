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
    public partial class frm_yemek : Form
    {
        public frm_yemek()
        {
            InitializeComponent();
        }

        public Yemek Yemek { get; set; }
        public bool Güncelleme { get; set; } = false;


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txt_yemekadi)) return;
            if (!ErrorControl(cmb_kategori)) return;
            if (!ErrorControl(nmrc_fiyat)) return;
            if (!ErrorControl(txt_ayrıntı)) return;

            Yemek.Ad = txt_yemekadi.Text;
            Yemek.Kategori = cmb_kategori.Text;
            Yemek.Fiyat = (double)nmrc_fiyat.Value;
            Yemek.Ayrıntı = txt_ayrıntı.Text;


            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void frm_yemek_Load(object sender, EventArgs e)
        {
            txt_id.Text = Yemek.ID.ToString();
            if (Güncelleme)
            {
                txt_yemekadi.Text = Yemek.Ad;
                cmb_kategori.Text = Yemek.Kategori;
                nmrc_fiyat.Value = (decimal)Yemek.Fiyat;
                txt_ayrıntı.Text = Yemek.Ayrıntı;
            }
        }
    }
}
