namespace WinFormAppRandomNumberGuessing
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lblSayac = new System.Windows.Forms.Label();
			this.lblDurum = new System.Windows.Forms.Label();
			this.btnBaslat = new System.Windows.Forms.Button();
			this.btnKontrol = new System.Windows.Forms.Button();
			this.txtSayi = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(63, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "DOĞRU SAYIYI BUL";
			// 
			// lblSayac
			// 
			this.lblSayac.AutoSize = true;
			this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSayac.Location = new System.Drawing.Point(29, 139);
			this.lblSayac.Name = "lblSayac";
			this.lblSayac.Size = new System.Drawing.Size(64, 20);
			this.lblSayac.TabIndex = 1;
			this.lblSayac.Text = "SAYAÇ";
			// 
			// lblDurum
			// 
			this.lblDurum.AutoSize = true;
			this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDurum.Location = new System.Drawing.Point(23, 71);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(70, 20);
			this.lblDurum.TabIndex = 2;
			this.lblDurum.Text = "DURUM";
			// 
			// btnBaslat
			// 
			this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBaslat.Location = new System.Drawing.Point(33, 178);
			this.btnBaslat.Name = "btnBaslat";
			this.btnBaslat.Size = new System.Drawing.Size(82, 73);
			this.btnBaslat.TabIndex = 3;
			this.btnBaslat.Text = "BAŞLAT";
			this.btnBaslat.UseVisualStyleBackColor = true;
			this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
			// 
			// btnKontrol
			// 
			this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKontrol.Location = new System.Drawing.Point(198, 167);
			this.btnKontrol.Name = "btnKontrol";
			this.btnKontrol.Size = new System.Drawing.Size(94, 73);
			this.btnKontrol.TabIndex = 4;
			this.btnKontrol.Text = "KONTROL";
			this.btnKontrol.UseVisualStyleBackColor = true;
			this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
			// 
			// txtSayi
			// 
			this.txtSayi.Location = new System.Drawing.Point(198, 141);
			this.txtSayi.Name = "txtSayi";
			this.txtSayi.Size = new System.Drawing.Size(94, 20);
			this.txtSayi.TabIndex = 5;
			this.txtSayi.Text = "Sayı Giriniz";
			this.txtSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 270);
			this.Controls.Add(this.txtSayi);
			this.Controls.Add(this.btnKontrol);
			this.Controls.Add(this.btnBaslat);
			this.Controls.Add(this.lblDurum);
			this.Controls.Add(this.lblSayac);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSayac;
		private System.Windows.Forms.Label lblDurum;
		private System.Windows.Forms.Button btnBaslat;
		private System.Windows.Forms.Button btnKontrol;
		private System.Windows.Forms.TextBox txtSayi;
	}
}

