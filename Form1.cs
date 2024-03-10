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

			btnKontrol.Enabled = true;
			btnKontrol.BackColor = Color.PeachPuff;
			Random random = new Random();
			rastgele = random.Next(0, 100); // Static OLMAYAN Metod
			sayac = 10;
			lblSayac.Text = sayac.ToString() + " Hakkınız Var";
			lblDurum.Text = "";
			txtSayi.Text = "";


		}

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
					btnKontrol.Enabled = false;
				}
			}

			lblSayac.Text = sayac.ToString() + " Hakkınız Kaldı!";


			if (sayac == 0)
			{
				lblDurum.Text = "KAZANAMADINIZ, TEKRAR DENEYİNİZ.";
				btnKontrol.Enabled = false;


			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnKontrol.Enabled = false;
			lblSayac.Text = "10 Hakkınız Var!";

		}
	}
}