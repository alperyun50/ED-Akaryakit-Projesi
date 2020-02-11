using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace EP_AKARYAKIT_PROJESI
{
    public class Akaryakitlar
    {
        public double Depo_Benzin95oktan { get; set; }
        public double Depo_Benzin97oktan { get; set; }
        public double Depo_Gazyagi { get; set; }
        public double Depo_Eurodizel { get; set; }
        public double Depo_Lpg { get; set; }
        public double Depo_Dizel { get; set; }
        public double Depo_Motorin { get; set; }
        public double Depo_Fueloil { get; set; }

        public double Fiyat_Benzin95oktan { get; set; }
        public double Fiyat_Benzin97oktan { get; set; }
        public double Fiyat_Gazyagi { get; set; }
        public double Fiyat_Eurodizel { get; set; }
        public double Fiyat_Lpg { get; set; }
        public double Fiyat_Dizel { get; set; }
        public double Fiyat_Motorin { get; set; }
        public double Fiyat_Fueloil { get; set; }

        public double Eklenen_Benzin95oktan { get; set; }
        public double Eklenen_Benzin97oktan { get; set; }
        public double Eklenen_Gazyagi { get; set; }
        public double Eklenen_Eurodizel { get; set; }
        public double Eklenen_Lpg { get; set; }
        public double Eklenen_Dizel { get; set; }
        public double Eklenen_Motorin { get; set; }
        public double Eklenen_Fueloil { get; set; }

        public double Satilan_Benzin95oktan { get; set; }
        public double Satilan_Benzin97oktan { get; set; }
        public double Satilan_Gazyagi { get; set; }
        public double Satilan_Eurodizel { get; set; }
        public double Satilan_Lpg { get; set; }
        public double Satilan_Dizel { get; set; }
        public double Satilan_Motorin { get; set; }
        public double Satilan_Fueloil { get; set; }


        public string[] depo_bilgileri;
        public string[] fiyat_bilgileri;
        public string[] eklenen_bilgileri;
        public string[] satilan_bilgileri;


        public void Depo_Oku_txt()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\depo.txt");  // Application.StartupPath bin dosyasındaki debug klasörüne denk
            Depo_Benzin95oktan = Convert.ToDouble(depo_bilgileri[0]);
            Depo_Benzin97oktan = Convert.ToDouble(depo_bilgileri[1]);
            Depo_Gazyagi = Convert.ToDouble(depo_bilgileri[2]);
            Depo_Eurodizel = Convert.ToDouble(depo_bilgileri[3]);
            Depo_Lpg = Convert.ToDouble(depo_bilgileri[4]);
            Depo_Dizel = Convert.ToDouble(depo_bilgileri[5]);
            Depo_Motorin = Convert.ToDouble(depo_bilgileri[6]);
            Depo_Fueloil = Convert.ToDouble(depo_bilgileri[7]);
        }


        public void Fiyat_Oku_txt()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            Fiyat_Benzin95oktan = Convert.ToDouble(fiyat_bilgileri[0]);
            Fiyat_Benzin97oktan = Convert.ToDouble(fiyat_bilgileri[1]);
            Fiyat_Gazyagi = Convert.ToDouble(fiyat_bilgileri[2]);
            Fiyat_Eurodizel = Convert.ToDouble(fiyat_bilgileri[3]);
            Fiyat_Lpg = Convert.ToDouble(fiyat_bilgileri[4]);
            Fiyat_Dizel = Convert.ToDouble(fiyat_bilgileri[5]);
            Fiyat_Motorin = Convert.ToDouble(fiyat_bilgileri[6]);
            Fiyat_Fueloil = Convert.ToDouble(fiyat_bilgileri[7]);
        }

       
    }
}
