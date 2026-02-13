using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Petrol_Istasyon_Yönetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-JKNOO9P\\SQLEXPRESS;Initial Catalog=PetrolSatış;Integrated Security=True;");
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            
            if (numericUpDown1.Value!=0)
            {
                baglanti.Open();
 
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)",baglanti);
                komut.Parameters.AddWithValue("@p1",TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3",numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4",decimal.Parse(TxtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1",numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                Listele();
            }
            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtKursunsuz97Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuz97Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                Listele();
            }
            if (numericUpDown3.Value != 0)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "EuroDizel10");
                komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtEuroDizel10Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtEuroDizel10Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='EuroDizel10'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                Listele();
            }
            if (numericUpDown4.Value != 0)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "ProDizel");
                komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtProDizelFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtProDizelFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='ProDizel'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                Listele();
            }
            if (numericUpDown5.Value != 0)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gaz");
                komut.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtGazFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtGazFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='Gaz'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown5.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                
                Listele();
            }
                MessageBox.Show("Satış Yapıldı.");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (true)
            {


                if (numericUpDown10.Value != 0)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("insert into TBLALIM(BENZINTURU,EKLENENLITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", "Kurşunsuz95");
                    komut.Parameters.AddWithValue("@p2", numericUpDown10.Value);
                    komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtKursunsuz95AlisTutar.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuz95AlisTutar.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown10.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    Giris();
                }
                if (numericUpDown9.Value != 0)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("insert into TBLALIM(BENZINTURU,EKLENENLITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", "Kurşunsuz97");
                    komut.Parameters.AddWithValue("@p2", numericUpDown9.Value);
                    komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtKursunsuz97AlisTutar.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuz97AlisTutar.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown9.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    Giris();
                }
                if (numericUpDown8.Value != 0)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("insert into TBLALIM(BENZINTURU,EKLENENLITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", "EuroDizel10");
                    komut.Parameters.AddWithValue("@p2", numericUpDown10.Value);
                    komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtEuroDizel10AlisTutar.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtEuroDizel10AlisTutar.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where PETROLTUR='EuroDizel10'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown8.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    Giris();
                }
                if (numericUpDown7.Value != 0)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("insert into TBLALIM(BENZINTURU,EKLENENLITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", "ProDizel");
                    komut.Parameters.AddWithValue("@p2", numericUpDown7.Value);
                    komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtProDizelAlisTutar.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtProDizelAlisTutar.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where PETROLTUR='ProDizel'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown7.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    Giris();
                }
                if (numericUpDown6.Value != 0)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("insert into TBLALIM(BENZINTURU,EKLENENLITRE,FIYAT) values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", "Gaz");
                    komut.Parameters.AddWithValue("@p2", numericUpDown6.Value);
                    komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtGazAlisTutar.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtGazAlisTutar.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where PETROLTUR='Gaz'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown6.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    Giris();
                }
                MessageBox.Show("Alış Yapıldı.");
            }
        }
        void Giris()
        {
            //Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtKursunsuz95Alis.Text = dr[2].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                Miktar1.Text = dr[4].ToString();

            }
            baglanti.Close();

            //Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                TxtKursunsuz97Alis.Text = dr2[2].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                Miktar2.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //EuroDizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                TxtEuroDizel10Alis.Text = dr3[2].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                Miktar3.Text = dr3[4].ToString();


            }
            baglanti.Close();

            //ProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='ProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                TxtProDizelAlis.Text = dr4[2].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                Miktar4.Text = dr4[4].ToString();

            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                TxtGazAlis.Text = dr5[2].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                Miktar5.Text = dr5[4].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }


        void Listele()
        {
            //Tek tek yazmamızın nedeni tüm değerlerin tek bir tablodan olmasından dolayı ve de bu yüzden aynı sütunda bulundukları için
            //Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                Miktar1.Text = dr[4].ToString();

            }
            baglanti.Close();

            //Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblKursunsuz97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                Miktar2.Text = dr2[4].ToString();


            }
            baglanti.Close();

            //EuroDizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblEuroDizel10.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                Miktar3.Text = dr3[4].ToString();


            }
            baglanti.Close();

            //ProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='ProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblProDizel.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                Miktar4.Text = dr4[4].ToString();

            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblGaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                Miktar5.Text = dr5[4].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from TBLKASA",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Listele();
            Giris();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Miktar1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95=Convert.ToDouble(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Fiyat.Text=tutar.ToString();
                
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunusz97,litre, tutar;
            kursunusz97=Convert.ToDouble(LblKursunsuz97.Text);
            litre= Convert.ToDouble(numericUpDown2.Value);
            tutar= kursunusz97 * litre;
            TxtKursunsuz97Fiyat.Text=tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel,litre,tutar;
            eurodizel=Convert.ToDouble(LblEuroDizel10.Text);
            litre=Convert.ToDouble(numericUpDown3.Value);
            tutar= eurodizel * litre;
            TxtEuroDizel10Fiyat.Text=tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(LblProDizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodizel * litre;
            TxtProDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(LblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            TxtGazFiyat.Text = tutar.ToString();
        }
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(TxtKursunsuz95Alis.Text);
            litre = Convert.ToDouble(numericUpDown10.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95AlisTutar.Text = tutar.ToString();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(TxtKursunsuz97Alis.Text);
            litre = Convert.ToDouble(numericUpDown9.Value);
            tutar = kursunsuz97 * litre;
            TxtKursunsuz97AlisTutar.Text = tutar.ToString();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(TxtEuroDizel10Alis.Text);
            litre = Convert.ToDouble(numericUpDown8.Value);
            tutar = eurodizel * litre;
            TxtEuroDizel10AlisTutar.Text = tutar.ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(TxtProDizelAlis.Text);
            litre = Convert.ToDouble(numericUpDown7.Value);
            tutar = prodizel * litre;
            TxtProDizelAlisTutar.Text = tutar.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(TxtGazAlis.Text);
            litre = Convert.ToDouble(numericUpDown6.Value);
            tutar = gaz * litre;
            TxtGazAlisTutar.Text = tutar.ToString();
        }
    }
}
