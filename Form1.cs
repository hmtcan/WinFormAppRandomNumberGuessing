using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppRandomNumberGuessing
{

	// Amaç: Rastgele sayı üreterek, doğru sayıyı 10 hak içerisinde bulmak
	// Kazanım: Static olmayan metod çağırmasında ref. instance (miras, kalıtsallık) kullanımı, rastgele sayı çağırma metodu & kullanım alanları (CAPTCHA, sipariş numarası, generator  vb.)

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int rastgele, sayac;

		private void btnBaslat_Click(object sender, EventArgs e)
		{

			//MessageBox.Show("Başlat!");
			// TEST: label1.Text = rastgele.ToString();

			//BAŞLAT butonuna basıldığında KONTROL butonu aktif olsun
			btnKontrol.Enabled = true;
			btnKontrol.BackColor = Color.PeachPuff;

			Random random = new Random();
			rastgele = random.Next(0, 100); // Static OLMAYAN Metod
			sayac = 10;
			lblSayac.Text = sayac.ToString() + " Hakkınız Var";
			lblDurum.Text = "";
			txtSayi.Text = "";


		}

		// Girilen Sayı > rastgele veya Girilen Sayı < Rastgele Sayı ise Sayaç ( 10 Hakkımızdan) Azaltsın.
		// Sayaç 0'a eşitlendiğinde hakkımız kalmayacağından "KAZANAMADINIZ" yazsın.

		private void btnKontrol_Click(object sender, EventArgs e)
		{
			if (txtSayi.Text == "")
			{
				lblDurum.Text = "SAYI GİRİNİZ";
			}
			else
			{
				int girilenSayi = Convert.ToInt32(txtSayi.Text);
				if (girilenSayi < rastgele)
				{
					lblDurum.Text = "Arttır";
					sayac--;
				}
				else if (girilenSayi > rastgele)
				{
					lblDurum.Text = "Azalt";
					sayac--;
				}
				else
				{
					lblDurum.Text = "TEBRİKLER KAZANDINIZ!";
					lblDurum.BackColor = Color.Green;
					btnKontrol.Enabled = false;
				}
			}

			lblSayac.Text = sayac.ToString() + " Hakkınız Kaldı!";


			if (sayac == 0)
			{
				lblDurum.Text = "KAZANAMADINIZ, TEKRAR DENEYİNİZ.";
				btnKontrol.Enabled = false;
				lblDurum.BackColor = Color.Red;


			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Kontrol butonu BAŞLAT butonuna basılmadan aktif olmasın
			btnKontrol.Enabled = false;
			lblSayac.Text = "10 Hakkınız Var!";

		}
	}
}