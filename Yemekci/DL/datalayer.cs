using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Yemekci.DL
{
    public static class DataLayer
    {
        static MySqlConnection baglantı = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "yemekci",
                UserID = "root",
                Password = "asd",

            }.ConnectionString
         );


        public static int MüşteriEkle(Musteri m)
        {

            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("MusteriEkle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }

        }

        internal static int MüşteriSil(string id)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("MusteriSil", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("MusteriGuncelle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int YemekSil(string id)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("YemekSil", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int SiparisSil(string id)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("SiparisSil", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }


        internal static int YemekGüncelle(Yemek y)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("YemekGuncelle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", y.ID);
                komut.Parameters.AddWithValue("@ad", y.Ad);
                komut.Parameters.AddWithValue("@kategori", y.Kategori);
                komut.Parameters.AddWithValue("@fiyat", y.Fiyat);
                komut.Parameters.AddWithValue("@ayrıntı", y.Ayrıntı);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }


        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("Musteri_listele", baglantı);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("MusteriBul", baglantı);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }
        internal static int YemekEkle(Yemek y)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("YemekEkle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", y.ID);
                komut.Parameters.AddWithValue("@ad", y.Ad);
                komut.Parameters.AddWithValue("@ktgori", y.Kategori);
                komut.Parameters.AddWithValue("@fyt", y.Fiyat);
                komut.Parameters.AddWithValue("@ayrnt", y.Ayrıntı);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }
        internal static DataSet YemekGetir(string filtre)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("Yemek_listele", baglantı);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("YemekBul", baglantı);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int SiparisEkle(Siparis s)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("SiparisEkle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@yid", s.YemekID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }

        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("OdemeEkle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }
        internal static int OdemeGüncelle(Odeme o)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("OdemeGuncelle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int SiparisGüncelle(Siparis s)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("SiparisGuncelle", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.YemekID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (baglantı.State != System.Data.ConnectionState.Open)
                    baglantı.Open();

                MySqlCommand komut = new MySqlCommand("OdemeSil", baglantı);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglantı.State != System.Data.ConnectionState.Closed)
                    baglantı.Close();
            }
        }


    }
}
