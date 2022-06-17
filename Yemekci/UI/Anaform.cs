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


        private void btn_sprsdüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewsiparis.SelectedRows[0];

            frm_siparis frmsiparis = new frm_siparis()
            {
                Text = "Siparis Güncelle",
                Güncelleme = true,
                Siparis = new Siparis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    YemekID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[4].Value.ToString()),

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
                    row.Cells[3].Value = frmsiparis.Siparis.Fiyat;
                    row.Cells[4].Value = frmsiparis.Siparis.Tarih;

                }
            }
        }

        private void btn_sprssil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewsiparis.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.SiparisDetay();
                    if (ds != null)
                        dataGridViewsiparis.DataSource = ds.Tables[0];
                }

            }
        }



        private void btn_odemedüzenle_Click(object sender, EventArgs e)
        { 
        
            DataGridViewRow row = dataGridViewodeme.SelectedRows[0];

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
                    row.Cells[2].Value = frmodeme.Odeme.Tarih;
                    row.Cells[3].Value = frmodeme.Odeme.Tutar;
                    row.Cells[4].Value = frmodeme.Odeme.Tur;
                }

            }
        }

        private void btn_odemesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewodeme.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridViewodeme.DataSource = ds.Tables[0];
                }
            }
        }

        private void Yemekci_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SiparisDetay();
            if (ds1 != null)
                dataGridViewsiparis.DataSource = ds1.Tables[0];


            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataGridViewodeme.DataSource = ds2.Tables[0];
        }

        Musteriler M_from = new Musteriler();
        yemekler Y_form = new yemekler();

        private void btn_yemekler_Click(object sender, EventArgs e)
        {
            Y_form.ShowDialog();
        }

        private void btn_müsteriler_Click(object sender, EventArgs e)
        {
            M_from.ShowDialog();
        }


    }
}
