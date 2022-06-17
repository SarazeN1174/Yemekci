using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekci.DL;

namespace Yemekci.BL
{
    public static class BLogic
    {
        
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MüşteriGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool YemekEkle(Yemek y)
        {
            try
            {
                int res = DataLayer.YemekEkle(y);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet YemekGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.YemekGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool YemekGüncelle(Yemek y)
        {
            try
            {
                int res = DataLayer.YemekGüncelle(y);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool YemekSil(string id)
        {
            try
            {
                int res = DataLayer.YemekSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisSil(string id)
        {
            try
            {
                int res = DataLayer.SiparisSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisEkle(Siparis s)
        {
            try
            {
                int res = DataLayer.SiparisEkle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
        internal static bool SiparisGüncelle(Siparis s)
        {
            try
            {
                int res = DataLayer.SiparisGüncelle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool OdemeEkle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeEkle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeGüncelle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeGüncelle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = DataLayer.OdemeSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SiparisDetay()
        {
            try
            {
                DataSet ds = DataLayer.SiparisDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }
    }
}
