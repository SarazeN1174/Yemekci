using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekci
{

    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

    }

    public class Yemek
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public string Ayrıntı { get; set; }


    }
    public class Siparis
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid YemekID { get; set; }

        public DateTime Tarih { get; set; }

        public double Fiyat { get; set; }

    }

    public class Odeme
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }

        public string Tur { get; set; }

    }
}
