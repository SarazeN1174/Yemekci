using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekci.BL;

namespace Yemekci.UI
{
    public partial class yemekler : Form
    {
        public yemekler()
        {
            InitializeComponent();
        }

        public Yemek Yemek { get; set; }


        private void btn_yemekekle_Click(object sender, EventArgs e)
        {
            frm_yemek frmyemek = new frm_yemek()
            {
                Text = "Yemek Ekle",
                Yemek = new Yemek() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmyemek.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YemekEkle(frmyemek.Yemek);

                if (b)
                {

                    DataSet ds = BLogic.YemekGetir("");
                    if (ds != null)
                        dataGridViewymk.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btn_ymkdüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewymk.SelectedRows[0];

            frm_yemek yemek = new frm_yemek()
            {
                Text = "Yemek Güncelle",
                Güncelleme = true,
                Yemek = new Yemek()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Ayrıntı = row.Cells[4].Value.ToString(),

                },
            };

            var sonuc = yemek.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YemekGüncelle(yemek.Yemek);

                if (b)
                {
                    row.Cells[1].Value = yemek.Yemek.Ad;
                    row.Cells[2].Value = yemek.Yemek.Kategori;
                    row.Cells[3].Value = yemek.Yemek.Fiyat;
                    row.Cells[4].Value = yemek.Yemek.Ayrıntı;
                }
            }
        }

        private void btn_ymksil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewymk.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.YemekSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.YemekGetir("");
                    if (ds != null)
                        dataGridViewymk.DataSource = ds.Tables[0];
                }
            }
        }

        private void yemekler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.YemekGetir("");
            if (ds2 != null)
                dataGridViewymk.DataSource = ds2.Tables[0];
        }

        private void btbn_tm_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewymk.SelectedRows[0];


            Yemek = new Yemek()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Kategori = row.Cells[2].Value.ToString(),
                Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                Ayrıntı = row.Cells[4].Value.ToString(),

            };

            DialogResult = DialogResult.OK;
        }
    }
}
