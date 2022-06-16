using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            if (!ErrorControl(comboBox1)) return;
            if (!ErrorControl(comboBox2)) return;
            if (!ErrorControl(nmrc_fiyat)) return;
            if (!ErrorControl(dt_tarih)) return;

            Siparis.MusteriID = Guid.Parse(comboBox1.Text);
            Siparis.YemekID = Guid.Parse(comboBox2.Text);
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
            
            MySqlConnection baglantı = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {Server = "localhost",Database = "yemekci",UserID = "root",Password = "",}.ConnectionString);

            baglantı.Open();
            MySqlCommand cmd = new MySqlCommand("select musteri_ID from musteriler", baglantı);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["musteri_ID"]);
            }
        }

        private void btn_yemeksec_Click(object sender, EventArgs e)
        {
            MySqlConnection baglantı = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            { Server = "localhost", Database = "yemekci", UserID = "root", Password = "", }.ConnectionString);

            baglantı.Open();
            MySqlCommand cmd = new MySqlCommand("select yemekID from yemekler", baglantı);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["yemekID"]);
            }
        }
    }
}
