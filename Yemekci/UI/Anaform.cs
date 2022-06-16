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
using Yemekci.UI;

namespace Yemekci
{
    public partial class Yemekci : Form
    {
        public Yemekci()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }
        
        public Yemek Yemek { get; set; }

        private void btn_siparisver_Click(object sender, EventArgs e)
        {
            frm_siparis frmsiparis = new frm_siparis()
            {
                Text = "Sipariş Ver",
                Siparis = new Siparis()
                {
                    ID = Guid.NewGuid()
                }
            };


            var sonuc = frmsiparis.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisEkle(frmsiparis.Siparis);

            }
        }

        private void btn_odemeyap_Click(object sender, EventArgs e)
        {
            frm_odeme frmödeme = new frm_odeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };

            var sonuc = frmödeme.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frmödeme.Odeme);
            }
        }

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
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btn_mstrekle_Click(object sender, EventArgs e)
        {
            frm_müsteri frmMusteri = new frm_müsteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.Musteri);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btn_ymkdüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

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
                    Ayrıntı = row.Cells[6].Value.ToString(),

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
                    row.Cells[6].Value = yemek.Yemek.Ayrıntı;
                }
            }
        }

        private void btn_ymksil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
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
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void btn_mstrdüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            frm_müsteri frmMusteri = new frm_müsteri()
            {
                Text = "Müşteri Güncelle",
                Güncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                },
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Mail;
                    row.Cells[5].Value = frmMusteri.Musteri.Adres;

                }

            }
        }

        private void btn_mstrsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btn_sprsdüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            frm_siparis frmsiparis = new frm_siparis()
            {
                Text = "Siparis Güncelle",
                Güncelleme = true,
                Siparis = new Siparis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    YemekID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[8].Value.ToString()),

                },
            };

            var sonuc = frmsiparis.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisGüncelle(frmsiparis.Siparis);

                if (b)
                {
                    row.Cells[1].Value = frmsiparis.Siparis.MusteriID;
                    row.Cells[2].Value = frmsiparis.Siparis.YemekID;
                    row.Cells[7].Value = frmsiparis.Siparis.Fiyat;
                    row.Cells[8].Value = frmsiparis.Siparis.Tarih;

                }

            }
        }

        private void btn_sprssil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisSil(ID);

            }
        }

        private void btn_odemedüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            frm_odeme frmodeme = new frm_odeme()
            {
                Text = "Ödeme Güncelle",
                Güncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar = double.Parse(row.Cells[4].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                },
            };

            var sonuc = frmodeme.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGüncelle(frmodeme.Odeme);

                if (b)
                {
                    row.Cells[1].Value = frmodeme.Odeme.MusteriID;
                    row.Cells[3].Value = frmodeme.Odeme.Tarih;
                    row.Cells[4].Value = frmodeme.Odeme.Tutar;
                    row.Cells[5].Value = frmodeme.Odeme.Tur;
                }

            }
        }

        private void btn_odemesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

            }
        }

        private void Yemekci_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.YemekGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }


        private void btn_tm_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
