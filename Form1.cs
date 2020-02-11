using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace EP_AKARYAKIT_PROJESI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }

        Akaryakitlar akaryakit = new Akaryakitlar();

        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            akaryakit.Fiyat_Oku_txt();
            Fiyat_Yaz_txt();
            akaryakit.Depo_Oku_txt();

            string[] akaryakit_turleri = { "Benzin(95 oktan)", "Benzin(97 oktan)", "Gazyağı" , "Eurodizel", "Lpg", "Dizel", "Motorin", "Fueloil"};
            mcbYakitTuru.Items.AddRange(akaryakit_turleri);

            nudBenzin95oktan.Enabled = false;
            nudBenzin97oktan.Enabled = false;
            nudGazyagi.Enabled = false;
            nudEurodizel.Enabled = false;
            nudLpg.Enabled = false;
            nudDizel.Enabled = false;
            nudMotorin.Enabled = false;
            nudFueloil.Enabled = false;

            nudBenzin95oktan.DecimalPlaces = 2;
            nudBenzin97oktan.DecimalPlaces = 2;
            nudGazyagi.DecimalPlaces = 2;
            nudEurodizel.DecimalPlaces = 2;
            nudLpg.DecimalPlaces = 2;
            nudDizel.DecimalPlaces = 2;
            nudMotorin.DecimalPlaces = 2;
            nudFueloil.DecimalPlaces = 2;


            nudBenzin95oktan.Increment = 0.1M;
            nudBenzin97oktan.Increment = 0.1M;
            nudGazyagi.Increment = 0.1M;
            nudEurodizel.Increment = 0.1M;
            nudLpg.Increment = 0.1M;
            nudDizel.Increment = 0.1M;
            nudMotorin.Increment = 0.1M;
            nudFueloil.Increment = 0.1M;

            //nudBenzin95oktan.ReadOnly = true;
            //nudBenzin97oktan.ReadOnly = true;
            //nudGazyagi.ReadOnly = true;
            //nudEurodizel.ReadOnly = true;
            //nudLpg.ReadOnly = true;
            //nudDizel.ReadOnly = true;
            //nudMotorin.ReadOnly = true;
            //nudFueloil.ReadOnly = true;

        }


        public void Progressbar_fiyat_guncelle()
        {
            mpbBenzin95oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin95oktan);
            mpbBenzin97oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin97oktan);
            mpbGazyagi.Value = Convert.ToInt16(akaryakit.Fiyat_Gazyagi);
            mpbEuroDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Eurodizel);
            mpbLpg.Value = Convert.ToInt16(akaryakit.Fiyat_Lpg);
            mpbDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Dizel);
            mpbMotorin.Value = Convert.ToInt16(akaryakit.Fiyat_Motorin);
            mpbFueloil.Value = Convert.ToInt16(akaryakit.Fiyat_Fueloil);
        }


        private void Numericupdown_Max_Deger()
        {
            nudBenzin95oktan.Maximum = decimal.Parse(akaryakit.Depo_Benzin95oktan.ToString());
            nudBenzin97oktan.Maximum = decimal.Parse(akaryakit.Depo_Benzin97oktan.ToString());
            nudGazyagi.Maximum = decimal.Parse(akaryakit.Depo_Gazyagi.ToString());
            nudEurodizel.Maximum = decimal.Parse(akaryakit.Depo_Eurodizel.ToString());
            nudLpg.Maximum = decimal.Parse(akaryakit.Depo_Lpg.ToString());
            nudDizel.Maximum = decimal.Parse(akaryakit.Depo_Dizel.ToString());
            nudMotorin.Maximum = decimal.Parse(akaryakit.Depo_Motorin.ToString());
            nudFueloil.Maximum = decimal.Parse(akaryakit.Depo_Fueloil.ToString());
        }


        public void Fiyat_Yaz_txt()
        {
            
            mpbBenzin95oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin95oktan);
            mlblFBenzin95oktan.Text = Convert.ToString(akaryakit.Fiyat_Benzin95oktan);

            mpbBenzin97oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin97oktan);
            mlblFBenzin97oktan.Text = Convert.ToString(akaryakit.Fiyat_Benzin97oktan);

            mpbGazyagi.Value = Convert.ToInt16(akaryakit.Fiyat_Gazyagi);
            mlblFGazyagi.Text = Convert.ToString(akaryakit.Fiyat_Gazyagi);

            mpbEuroDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Eurodizel);
            mlblFDizel.Text = Convert.ToString(akaryakit.Fiyat_Dizel);

            mpbLpg.Value = Convert.ToInt16(akaryakit.Fiyat_Lpg);
            mlblFLpg.Text = Convert.ToString(akaryakit.Fiyat_Lpg);

            mpbDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Dizel);
            mlblFDizel.Text = Convert.ToString(akaryakit.Fiyat_Dizel);

            mpbMotorin.Value = Convert.ToInt16(akaryakit.Fiyat_Motorin);
            mlblFMotorin.Text = Convert.ToString(akaryakit.Fiyat_Motorin);

            mpbFueloil.Value = Convert.ToInt16(akaryakit.Fiyat_Fueloil);
            mlblFFueloil.Text = Convert.ToString(akaryakit.Fiyat_Fueloil);
        }

        private void mbtnDgoruntuleBenzin95oktan_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Benzin95oktan);
            lblDepoGoruntule.Text = akaryakit.Depo_Benzin95oktan.ToString("N");
        }

        private void mbtnDgoruntuleBenzin97oktan_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Benzin97oktan);
            lblDepoGoruntule.Text = akaryakit.Depo_Benzin97oktan.ToString("N");
        }

        private void mbtnDgoruntuleGazyagi_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Gazyagi);
            lblDepoGoruntule.Text = akaryakit.Depo_Gazyagi.ToString("N");
        }

        private void mbtnDgoruntuleEurodizel_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Eurodizel);
            lblDepoGoruntule.Text = akaryakit.Depo_Eurodizel.ToString("N");
        }

        private void mbtnDgoruntuleLpg_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Lpg);
            lblDepoGoruntule.Text = akaryakit.Depo_Lpg.ToString("N");
        }

        private void mbtnDgoruntuleDizel_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Dizel);
            lblDepoGoruntule.Text = akaryakit.Depo_Dizel.ToString("N");
        }

        private void mbtnDgoruntuleMotorin_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Motorin);
            lblDepoGoruntule.Text = akaryakit.Depo_Motorin.ToString("N");
        }

        private void mbtnDgoruntuleFueloil_Click(object sender, EventArgs e)
        {
            mpsDepoGoruntule.Value = Convert.ToInt16(akaryakit.Depo_Fueloil);
            lblDepoGoruntule.Text = akaryakit.Depo_Fueloil.ToString("N");
        }

        private void mcbYakitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mcbYakitTuru.Text == "Benzin(95 oktan)")
            {
                mlblSecilenAkaryakit.Text = "Benzin(95 oktan)";

                nudBenzin95oktan.Enabled = true;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if(mcbYakitTuru.Text == "Benzin(97 oktan)")
            {
                mlblSecilenAkaryakit.Text = "Benzin(97 oktan)";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = true;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if(mcbYakitTuru.Text == "Gazyağı")
            {
                mlblSecilenAkaryakit.Text = "Gazyağı";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = true;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if(mcbYakitTuru.Text == "Eurodizel")
            {
                mlblSecilenAkaryakit.Text = "Eurodizel";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = true;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if(mcbYakitTuru.Text == "Lpg")
            {
                mlblSecilenAkaryakit.Text = "Lpg";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = true;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if (mcbYakitTuru.Text == "Dizel")
            {
                mlblSecilenAkaryakit.Text = "Dizel";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = true;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = false;
            }
            else if (mcbYakitTuru.Text == "Motorin")
            {
                mlblSecilenAkaryakit.Text = "Motorin";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = true;
                nudFueloil.Enabled = false;
            }
            else if (mcbYakitTuru.Text == "Fueloil")
            {
                mlblSecilenAkaryakit.Text = "Fueloil";

                nudBenzin95oktan.Enabled = false;
                nudBenzin97oktan.Enabled = false;
                nudGazyagi.Enabled = false;
                nudEurodizel.Enabled = false;
                nudLpg.Enabled = false;
                nudDizel.Enabled = false;
                nudMotorin.Enabled = false;
                nudFueloil.Enabled = true;
            }
        }


        private void mbtnSecimiOnayla_Click(object sender, EventArgs e)
        {
            // seçilen yakıt ve miktarına göre fiyatı hesapla

            if (nudBenzin95oktan.Enabled == true)
            {
                mlblYakitMiktari.Text = nudBenzin95oktan.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudBenzin95oktan.Value) * akaryakit.Fiyat_Benzin95oktan);
            }
            else if(nudBenzin97oktan.Enabled == true)
            {
                mlblYakitMiktari.Text = nudBenzin97oktan.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudBenzin97oktan.Value) * akaryakit.Fiyat_Benzin97oktan);
            }
            else if(nudGazyagi.Enabled == true)
            {
                mlblYakitMiktari.Text = nudGazyagi.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudGazyagi.Value) * akaryakit.Fiyat_Gazyagi);
            }
            else if(nudEurodizel.Enabled == true)
            {
                mlblYakitMiktari.Text = nudEurodizel.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudEurodizel.Value) * akaryakit.Fiyat_Eurodizel);
            }
            else if(nudLpg.Enabled == true)
            {
                mlblYakitMiktari.Text = nudLpg.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudLpg.Value) * akaryakit.Fiyat_Lpg);
            }
            else if (nudDizel.Enabled == true)
            {
                mlblYakitMiktari.Text = nudDizel.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudDizel.Value) * akaryakit.Fiyat_Dizel);
            }
            else if (nudMotorin.Enabled == true)
            {
                mlblYakitMiktari.Text = nudMotorin.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudMotorin.Value) * akaryakit.Fiyat_Motorin);
            }
            else if (nudFueloil.Enabled == true)
            {
                mlblYakitMiktari.Text = nudFueloil.Value.ToString("N");
                mlblOdenecekTutar.Text = Convert.ToString(Convert.ToDouble(nudFueloil.Value) * akaryakit.Fiyat_Fueloil);
            }

        }


        private void mbtnSatisYap_Click(object sender, EventArgs e)
        {
            akaryakit.Satilan_Benzin95oktan = double.Parse(nudBenzin95oktan.Value.ToString());
            akaryakit.Satilan_Benzin97oktan = double.Parse(nudBenzin97oktan.Value.ToString());
            akaryakit.Satilan_Gazyagi = double.Parse(nudGazyagi.Value.ToString());
            akaryakit.Satilan_Eurodizel = double.Parse(nudEurodizel.Value.ToString());
            akaryakit.Satilan_Lpg = double.Parse(nudLpg.Value.ToString());
            akaryakit.Satilan_Dizel = double.Parse(nudDizel.Value.ToString());
            akaryakit.Satilan_Motorin = double.Parse(nudMotorin.Value.ToString());
            akaryakit.Satilan_Fueloil = double.Parse(nudFueloil.Value.ToString());

            // satış miktarı kadar depoyu azalt
            if(nudBenzin95oktan.Enabled == true)
            {
                akaryakit.Depo_Benzin95oktan = akaryakit.Depo_Benzin95oktan - akaryakit.Satilan_Benzin95oktan;
                akaryakit.depo_bilgileri[0] = Convert.ToString(akaryakit.Depo_Benzin95oktan);
                MessageBox.Show("Benzin 95 oktan satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(nudBenzin97oktan.Enabled == true)
            {
                akaryakit.Depo_Benzin97oktan = akaryakit.Depo_Benzin97oktan - akaryakit.Satilan_Benzin97oktan;
                akaryakit.depo_bilgileri[1] = Convert.ToString(akaryakit.Depo_Benzin97oktan);
                MessageBox.Show("Benzin 97 oktan satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudGazyagi.Enabled == true)
            {
                akaryakit.Depo_Gazyagi = akaryakit.Depo_Gazyagi - akaryakit.Satilan_Gazyagi;
                akaryakit.depo_bilgileri[2] = Convert.ToString(akaryakit.Depo_Gazyagi);
                MessageBox.Show("Gazyağı satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudEurodizel.Enabled == true)
            {
                akaryakit.Depo_Eurodizel = akaryakit.Depo_Eurodizel - akaryakit.Satilan_Eurodizel;
                akaryakit.depo_bilgileri[3] = Convert.ToString(akaryakit.Depo_Eurodizel);
                MessageBox.Show("Eurodizel satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudLpg.Enabled == true)
            {
                akaryakit.Depo_Lpg = akaryakit.Depo_Lpg - akaryakit.Satilan_Lpg;
                akaryakit.depo_bilgileri[4] = Convert.ToString(akaryakit.Depo_Lpg);
                MessageBox.Show("Lpg satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudDizel.Enabled == true)
            {
                akaryakit.Depo_Dizel = akaryakit.Depo_Dizel - akaryakit.Satilan_Dizel;
                akaryakit.depo_bilgileri[5] = Convert.ToString(akaryakit.Depo_Dizel);
                MessageBox.Show("Dizel satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudMotorin.Enabled == true)
            {
                akaryakit.Depo_Motorin = akaryakit.Depo_Motorin - akaryakit.Satilan_Motorin;
                akaryakit.depo_bilgileri[6] = Convert.ToString(akaryakit.Depo_Motorin);
                MessageBox.Show("Motorin satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nudFueloil.Enabled == true)
            {
                akaryakit.Depo_Fueloil = akaryakit.Depo_Fueloil - akaryakit.Satilan_Fueloil;
                akaryakit.depo_bilgileri[7] = Convert.ToString(akaryakit.Depo_Fueloil);
                MessageBox.Show("Fueloil satışı başarıyla gerçekleştirildi!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);

        }


        private void mbtnDguncelleBenzin95oktan_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Eklenen_Benzin95oktan = Convert.ToDouble(mtbxDgBenzin95oktan.Text);
                if (akaryakit.Eklenen_Benzin95oktan + akaryakit.Depo_Benzin95oktan > 1000 || akaryakit.Eklenen_Benzin95oktan <= 0)
                { 
                    MessageBox.Show("Benzin (95 oktan) güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    akaryakit.depo_bilgileri[0] = Convert.ToString(akaryakit.Eklenen_Benzin95oktan + akaryakit.Depo_Benzin95oktan);
                    MessageBox.Show("Benzin (95 oktan) güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Benzin (95 oktan) güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();
            
            mpbDguncelleBenzin95oktan.Value = Convert.ToInt16(akaryakit.Depo_Benzin95oktan);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleBenzin97oktan_Click(object sender, EventArgs e)
        {
            try 
            {
                akaryakit.Eklenen_Benzin97oktan = Convert.ToDouble(mtbxDgBenzin97oktan.Text);
                if(akaryakit.Eklenen_Benzin97oktan + akaryakit.Depo_Benzin97oktan > 1000 || akaryakit.Eklenen_Benzin97oktan <= 0)
                {
                    MessageBox.Show("Benzin (97 oktan) güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    akaryakit.depo_bilgileri[1] = Convert.ToString(akaryakit.Eklenen_Benzin97oktan + akaryakit.Depo_Benzin97oktan);
                    MessageBox.Show("Benzin (97 oktan) güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Benzin (97 oktan) güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleBenzin97oktan.Value = Convert.ToInt16(akaryakit.Depo_Benzin97oktan);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleGazyagi_Click(object sender, EventArgs e)
        {
            try 
            {
                akaryakit.Eklenen_Gazyagi = Convert.ToDouble(mtbxDgGazyagi.Text);
                if(akaryakit.Eklenen_Gazyagi + akaryakit.Depo_Gazyagi > 1000 || akaryakit.Eklenen_Gazyagi <= 0)
                {
                    MessageBox.Show("Gazyağı güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    akaryakit.depo_bilgileri[2] = Convert.ToString(akaryakit.Eklenen_Gazyagi + akaryakit.Depo_Gazyagi);
                    MessageBox.Show("Gazyağı güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Gazyağı güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleGazyagi.Value = Convert.ToInt16(akaryakit.Depo_Gazyagi);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleEurodizel_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Eklenen_Eurodizel = Convert.ToDouble(mtbxDgEurodizel.Text);
                if(akaryakit.Eklenen_Eurodizel + akaryakit.Depo_Eurodizel > 1000 || akaryakit.Eklenen_Eurodizel <= 0)
                {
                    MessageBox.Show("Eurodizel güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.depo_bilgileri[3] = Convert.ToString(akaryakit.Eklenen_Eurodizel + akaryakit.Depo_Eurodizel);
                    MessageBox.Show("Eurodizel güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Eurodizel güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleEurodizel.Value = Convert.ToInt16(akaryakit.Depo_Eurodizel);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleLpg_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Eklenen_Lpg = Convert.ToDouble(mtbxDgLpg.Text);
                if(akaryakit.Eklenen_Lpg + akaryakit.Depo_Lpg > 1000 || akaryakit.Eklenen_Lpg <= 0)
                {
                    MessageBox.Show("Lpg güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.depo_bilgileri[4] = Convert.ToString(akaryakit.Eklenen_Lpg + akaryakit.Depo_Lpg);
                    MessageBox.Show("Lpg güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lpg güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleLpg.Value = Convert.ToInt16(akaryakit.Depo_Lpg);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleDizel_Click(object sender, EventArgs e)
        {
            try 
            {
                akaryakit.Eklenen_Dizel = Convert.ToDouble(mtbxDgDizel.Text);
                if(akaryakit.Eklenen_Dizel + akaryakit.Depo_Dizel > 1000 || akaryakit.Eklenen_Dizel <= 0)
                {
                    MessageBox.Show("Dizel güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.depo_bilgileri[5] = Convert.ToString(akaryakit.Eklenen_Dizel + akaryakit.Depo_Dizel);
                    MessageBox.Show("Dizel güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dizel güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleDizel.Value = Convert.ToInt16(akaryakit.Depo_Dizel);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleMotorin_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Eklenen_Motorin = Convert.ToDouble(mtbxDgMotorin.Text);
                if (akaryakit.Eklenen_Motorin + akaryakit.Depo_Motorin > 1000 || akaryakit.Eklenen_Motorin <= 0)
                {
                    MessageBox.Show("Motorin güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.depo_bilgileri[6] = Convert.ToString(akaryakit.Eklenen_Motorin + akaryakit.Depo_Motorin);
                    MessageBox.Show("Motorin güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Motorin güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleMotorin.Value = Convert.ToInt16(akaryakit.Depo_Motorin);
            Numericupdown_Max_Deger();
        }

        private void mbtnDguncelleFueloil_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Eklenen_Fueloil = Convert.ToDouble(mtbxDgFueloil.Text);
                if (akaryakit.Eklenen_Fueloil + akaryakit.Depo_Fueloil > 1000 || akaryakit.Eklenen_Fueloil <= 0)
                {
                    MessageBox.Show("Fueloil güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.depo_bilgileri[7] = Convert.ToString(akaryakit.Eklenen_Fueloil + akaryakit.Depo_Fueloil);
                    MessageBox.Show("Fueloil güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fueloil güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", akaryakit.depo_bilgileri);
            akaryakit.Depo_Oku_txt();

            mpbDguncelleFueloil.Value = Convert.ToInt16(akaryakit.Depo_Fueloil);
            Numericupdown_Max_Deger();
        }

        private void mbtnFguncelleBenzin95oktan_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Benzin95oktan = Convert.ToDouble(mtbxFguncelleBenzin95oktan.Text);
                if(akaryakit.Fiyat_Benzin95oktan >= 10 || akaryakit.Fiyat_Benzin95oktan <= 0)
                {
                    MessageBox.Show("Benzin (95 oktan) fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[0] = Convert.ToString(akaryakit.Fiyat_Benzin95oktan);
                    MessageBox.Show("Benzin (95 oktan) fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Benzin (95 oktan) fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbBenzin95oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin95oktan);
            mlblFBenzin95oktan.Text = Convert.ToString(akaryakit.Fiyat_Benzin95oktan);
        }

        private void mbtnFguncelleBenzin97oktan_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Benzin97oktan = Convert.ToDouble(mtbxFguncelleBenzin97oktan.Text);
                if(akaryakit.Fiyat_Benzin97oktan >= 10 || akaryakit.Fiyat_Benzin97oktan <= 0)
                {
                    MessageBox.Show("Benzin (97 oktan) fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[1] = Convert.ToString(akaryakit.Fiyat_Benzin97oktan);
                    MessageBox.Show("Benzin (97 oktan) fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Benzin (97 oktan) fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mlblFBenzin97oktan.Text = Convert.ToString(akaryakit.Fiyat_Benzin97oktan);
            mpbBenzin97oktan.Value = Convert.ToInt16(akaryakit.Fiyat_Benzin97oktan);
        }

        private void mbtnFguncelleBenzinGazyagi_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Gazyagi = Convert.ToDouble(mtbxFguncelleGazyagi.Text);
                if(akaryakit.Fiyat_Gazyagi >= 10 || akaryakit.Fiyat_Gazyagi <= 0)
                {
                    MessageBox.Show("Gazyağı fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[2] = Convert.ToString(akaryakit.Fiyat_Gazyagi);
                    MessageBox.Show("Gazyağı fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Gazyağı fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mlblFGazyagi.Text = Convert.ToString(akaryakit.Fiyat_Gazyagi);
            mpbGazyagi.Value = Convert.ToInt16(akaryakit.Fiyat_Gazyagi);
        }

        private void mbtnFguncelleEurodizel_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Eurodizel = Convert.ToDouble(mtbxFguncelleEurodizel.Text);
                if(akaryakit.Fiyat_Eurodizel >= 10 || akaryakit.Fiyat_Eurodizel <= 0)
                {
                    MessageBox.Show("Eurodizel fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[3] = Convert.ToString(akaryakit.Fiyat_Gazyagi);
                    MessageBox.Show("Eurodizel fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Eurodizel fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbEuroDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Eurodizel);
            mlblFEurodizel.Text = Convert.ToString(akaryakit.Fiyat_Eurodizel); 
        }

        private void mbtnFguncelleLpg_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Lpg = Convert.ToDouble(mtbxFguncelleLpg.Text);
                if (akaryakit.Fiyat_Lpg >= 10 || akaryakit.Fiyat_Lpg <= 0)
                {
                    MessageBox.Show("Lpg fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[4] = Convert.ToString(akaryakit.Fiyat_Lpg);
                    MessageBox.Show("Lpg fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lpg fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbLpg.Value = Convert.ToInt16(akaryakit.Fiyat_Lpg);
            mlblFLpg.Text = Convert.ToString(akaryakit.Fiyat_Lpg);
        }

        private void mbtnFguncelleDizel_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Dizel = Convert.ToDouble(mtbxFguncelleDizel.Text);
                if(akaryakit.Fiyat_Dizel >= 10 || akaryakit.Fiyat_Dizel <= 0)
                {
                    MessageBox.Show("Dizel fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[5] = Convert.ToString(akaryakit.Fiyat_Lpg);
                    MessageBox.Show("Dizel fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dizel fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbDizel.Value = Convert.ToInt16(akaryakit.Fiyat_Dizel);
            mlblFDizel.Text = Convert.ToString(akaryakit.Fiyat_Dizel);
        }

        private void mbtnFguncelleMotorin_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Motorin = Convert.ToDouble(mtbxFguncelleMotorin.Text);
                if (akaryakit.Fiyat_Motorin >= 10 || akaryakit.Fiyat_Motorin <= 0)
                {
                    MessageBox.Show("Motorin fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[6] = Convert.ToString(akaryakit.Fiyat_Motorin);
                    MessageBox.Show("Motorin fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Motorin fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbMotorin.Value = Convert.ToInt16(akaryakit.Fiyat_Motorin);
            mlblFMotorin.Text = Convert.ToString(akaryakit.Fiyat_Motorin);
        }

        private void mbtnFguncelleFueloil_Click(object sender, EventArgs e)
        {
            try
            {
                akaryakit.Fiyat_Fueloil = Convert.ToDouble(mtbxFguncelleFueloil.Text);
                if (akaryakit.Fiyat_Fueloil >= 10 || akaryakit.Fiyat_Fueloil <= 0)
                {
                    MessageBox.Show("Fueloil fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    akaryakit.fiyat_bilgileri[7] = Convert.ToString(akaryakit.Fiyat_Fueloil);
                    MessageBox.Show("Fueloil fiyat güncellemesi tamamlandı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fueloil fiyat güncellemesi için hatalı giriş yapıldı!..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", akaryakit.fiyat_bilgileri);
            mpbFueloil.Value = Convert.ToInt16(akaryakit.Fiyat_Fueloil);
            mlblFFueloil.Text = Convert.ToString(akaryakit.Fiyat_Fueloil);
        }

       
    }
}
