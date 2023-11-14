using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola_Oyunu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruno = 0, dogru = 0, yanlis = 0, bos=0;

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel3.Text = "oyun\n10 sn içinde\nbaşlıyor";
			timer1.Start();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
				soruno++;
				bos++;
				labelBos.Text = bos.ToString();


			if (soruno == 1)
			{
				richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
				buttonA.BackColor = Color.Yellow;
				buttonOrta.Text = "A";
				buttonOrta.BackColor = Color.Red;

			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
				buttonB.BackColor = Color.Yellow;
				buttonOrta.Text = "B";
				buttonOrta.BackColor = Color.LightSeaGreen;

			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Müslümanların Kutsal günü?";
				buttonC.BackColor = Color.Yellow;
				buttonOrta.Text = "C";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 4)
			{
				richTextBox1.Text = "Karpuzuyla Ünlü ilimiz?";
				buttonD.BackColor = Color.Yellow;
				buttonOrta.Text= "D";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 5)
			{
				richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
				buttonE.BackColor = Color.Yellow;
				buttonOrta.Text = "E";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 6)
			{
				richTextBox1.Text = "Padişahın yazılı emirlerine ne ad verilir?";
				buttonF.BackColor = Color.Yellow;
				buttonOrta.Text = "F";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 7)
			{
				richTextBox1.Text = "Dünyanın ısı kaynağı nedir?";
				buttonG.BackColor = Color.Yellow;
				buttonOrta.Text = "G";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 8)
			{
				richTextBox1.Text = "Öğrenciler karne gününde sonuç kötü gelince evde bakıştığı nesne?";
				buttonH.BackColor = Color.Yellow;
				buttonOrta.Text = "H";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 9)
			{
				richTextBox1.Text = "Gülüyle ünlü şehir?";
				buttonI.BackColor = Color.Yellow;
				buttonOrta.Text = "I";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 10)
			{
				richTextBox1.Text = "Mersinin diğer adı nedir?";
				buttonİ.BackColor = Color.Yellow;
				buttonOrta.Text = "İ";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 11)
			{
				richTextBox1.Text = "Askeri bir topluluktur?";
				buttonJ.BackColor = Color.Yellow;
				buttonOrta.Text = "J";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 12)
			{
				richTextBox1.Text = "Malatya`nın meşhur meyvesi?";
				buttonK.BackColor = Color.Yellow;
				buttonOrta.Text = "K";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 13)
			{
				richTextBox1.Text = "Her yılın bahar aylarında kutlanan çiçek festival?";
				buttonL.BackColor = Color.Yellow;
				buttonOrta.Text = "L";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 14)
			{
				richTextBox1.Text = "Yılın 3.ayı?";
				buttonM.BackColor = Color.Yellow;
				buttonOrta.Text = "M";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 15)
			{
				richTextBox1.Text = "Üflemeli bir müzik aleti?";
				buttonN.BackColor = Color.Yellow;
				buttonOrta.Text = "N";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 16)
			{
				richTextBox1.Text = "Halk Şairi?";
				buttonO.BackColor = Color.Yellow;
				buttonOrta.Text = "O";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 17)
			{
				richTextBox1.Text = "Çocukların Çok sevmediği pirinç,havuç gibi sebzelerle yapılan yemek?";
				buttonP.BackColor = Color.Yellow;
				buttonOrta.Text = "P";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 18)
			{
				richTextBox1.Text = "11 ayın sultanı?";
				buttonR.BackColor = Color.Yellow;
				buttonOrta.Text = "R";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 19)
			{
				richTextBox1.Text = "İngilizcede yılan?";
				buttonS.BackColor = Color.Yellow;
				buttonOrta.Text = "S";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 20)
			{
				richTextBox1.Text = "Türkiye`nin Megastar`ı";
				buttonT.BackColor = Color.Yellow;
				buttonOrta.Text = "T";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 21)
			{
				richTextBox1.Text = "Ümit kelimesinin eş anlamlısı??";
				buttonU.BackColor = Color.Yellow;
				buttonOrta.Text = "U";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 22)
			{
				richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
				buttonV.BackColor = Color.Yellow;
				buttonOrta.Text = "V";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 23)
			{
				richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
				buttonY.BackColor = Color.Yellow;
				buttonOrta.Text = "Y";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}
			if (soruno == 24)
			{
				richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan ve yağı da yapılan bir kahvaltı besinidir?";
				buttonZ.BackColor = Color.Yellow;
				buttonOrta.Text = "Z";
				buttonOrta.BackColor = Color.LightSeaGreen;
			}


		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				switch (soruno)
				{
					case 1:
						if (textBox1.Text == "Ege")
						{
							buttonA.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonA.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();
						}
						break;

					case 2:
						if(textBox1.Text =="bursa")
						{
							buttonB.BackColor = Color.Green;
							dogru++;
							labelDogru.Text= dogru.ToString();
						}
						else
						{
							buttonB.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text= yanlis.ToString();
						}
						break;

					case 3:
						if(textBox1.Text=="Cuma")
						{
							buttonC.BackColor= Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
						else
						{
							buttonC.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

					case 4:
						if(textBox1.Text=="Diyarbakır")
						{
							buttonD.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonD.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

					case 5:
						if(textBox1.Text=="Eski")
						{
							buttonE.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonE.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text= yanlis.ToString();
						}
						break;

					case 6:
						if(textBox1.Text=="Ferman")
						{
							buttonF.BackColor = Color.Green;
							dogru++;
							labelDogru.Text= dogru.ToString();
						}
						else
						{
							buttonF.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();

						}
						break;

					case 7:
						if(textBox1.Text=="Güneş")
						{
							buttonG.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonG.BackColor=Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

					case 8:
						if(textBox1.Text=="Halı")
						{
							buttonH.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonH.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

					case 9:
						if(textBox1.Text=="Isparta")
						{
							buttonI.BackColor= Color.Green;
							dogru++;
							labelDogru.Text= dogru.ToString();
						}
						else
						{
							buttonI.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text= yanlis.ToString();
						}
						break;

						case 10:
							if(textBox1.Text=="İçel")
						{
							buttonİ.BackColor= Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
							else
						{
							buttonİ.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 11:
							if(textBox1.Text=="Jandarma")
						{
							buttonJ.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonJ.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();
						}
						break;

						case 12:	
							if(textBox1.Text=="Kayısı")
						{
							buttonK.BackColor = Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
							else
						{
							buttonK.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

					case 13:
						if(textBox1.Text=="Kiraz Çiçeği")
						{
							buttonL.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
						else
						{
							buttonL.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();

						}
						break;

						case 14:
							if(textBox1.Text=="Mart")
						{
							buttonM.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonM.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 15:
							if(textBox1.Text=="Ney")
						{
							buttonN.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonN.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();
						}
						break;

					case 16:
						if(textBox1.Text=="Ozan")
						{
							buttonO.BackColor = Color.Green;
							dogru++;
							labelDogru.Text= dogru.ToString();
						}
						else
						{
							buttonO.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();
						}
						break;

						case 17:
							if(textBox1.Text=="Pırasa")
						{
							buttonP.BackColor=Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonP.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text= yanlis.ToString();
						}
						break;

						case 18:
							if(textBox1.Text=="Ramazan")
						{
							buttonR.BackColor=Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
							else
						{
							buttonR.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 19:
							if(textBox1.Text=="Snake")
						{
							buttonS.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonS.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 20:
							if(textBox1.Text=="Tarkan")
						{
							buttonT.BackColor=Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();	
						}
							else
						{
							buttonT.BackColor= Color.Red;
							yanlis++;
							labelYanlis.Text = yanlis.ToString();
						}
						break;

						case 21:
							if(textBox1.Text=="Umut")
						{
							buttonU.BackColor = Color.Green;
							dogru++;
							labelDogru.Text= dogru.ToString();
						}
							else
						{
							buttonU.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text= yanlis.ToString();
						}
						break;

						case 22:
							if(textBox1.Text=="Van")
						{
							buttonV.BackColor = Color.Green;
							dogru++;
							labelDogru.Text = dogru.ToString();
						}
							else
						{
							buttonV.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 23:
							if(textBox1.Text=="Yıldırım")
						{
							buttonY.BackColor = Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
							else
						{
							buttonY.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text=yanlis.ToString();
						}
						break;

						case 24:
							if(textBox1.Text=="Zeytin")
						{
							buttonZ.BackColor=Color.Green;
							dogru++;
							labelDogru.Text=dogru.ToString();
						}
							else
						{
							buttonZ.BackColor = Color.Red;
							yanlis++;
							labelYanlis.Text =yanlis.ToString();
						}
						break;

					default:
						break;
				}
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
			if(string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Cevap vermek istemiyorsanız lütfen 'Pass geç' tuşuna basınız");
				
			}
			else
			{
				linkLabel1.Text = "Sonraki soruya geç";
				soruno++;
				this.Text = soruno.ToString();
			}
				
			

			if(soruno==1)
			{
				richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
				buttonA.BackColor = Color.Yellow;
				buttonOrta.Text = "A";
				buttonOrta.BackColor = Color.Aquamarine;

			}
			if(soruno==2)
			{
				richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
				buttonB.BackColor = Color.Yellow;
				buttonOrta.Text="B";
				buttonOrta.BackColor = Color.Aquamarine;


			}
			if(soruno==3)
			{
				richTextBox1.Text = "Müslümanların Kutsal günü?";
				buttonC.BackColor = Color.Yellow;
				buttonOrta.Text = "C";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==4)
			{
				richTextBox1.Text = "Karpuzuyla Ünlü ilimiz?";
				buttonD.BackColor = Color.Yellow;
				buttonOrta.Text = "D";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==5)
			{
				richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
				buttonE.BackColor = Color.Yellow;
				buttonOrta.Text = "E";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==6)
			{
				richTextBox1.Text = "Padişahın yazılı emirlerine ne ad verilir?";
				buttonF.BackColor = Color.Yellow;
				buttonOrta.Text = "F";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==7)
			{
				richTextBox1.Text = "Dünyanın ısı kaynağı nedir?";
				buttonG.BackColor = Color.Yellow;
				buttonOrta.Text = "G";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno == 8)
			{
				richTextBox1.Text = "Öğrenciler karne gününde sonuç kötü gelince evde bakıştığı nesne?";
				buttonH.BackColor = Color.Yellow;
				buttonOrta.Text = "H";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if(soruno ==9)
			{
				richTextBox1.Text = "Gülüyle ünlü şehir?";
				buttonI.BackColor = Color.Yellow;
				buttonOrta.Text = "I";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==10)
			{
				richTextBox1.Text = "Mersinin diğer adı nedir?";
				buttonİ.BackColor = Color.Yellow;
				buttonOrta.Text = "İ";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==11)
			{
				richTextBox1.Text = "Askeri bir topluluktur?";
				buttonJ.BackColor = Color.Yellow;
				buttonOrta.Text = "J";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==12)
			{
				richTextBox1.Text = "Malatya`nın meşhur meyvesi?";
				buttonK.BackColor = Color.Yellow;
				buttonOrta.Text = "K";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==13)
			{
				richTextBox1.Text = "Her yılın bahar aylarında kutlanan çiçek festival?";
				buttonL.BackColor = Color.Yellow;
				buttonOrta.Text = "L";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==14)
			{
				richTextBox1.Text = "Yılın 3.ayı?";
				buttonM.BackColor = Color.Yellow;
				buttonOrta.Text = "M";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==15)
			{
				richTextBox1.Text = "Üflemeli bir müzik aleti?";
				buttonN.BackColor = Color.Yellow;
				buttonOrta.Text= "N";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==16)
			{
				richTextBox1.Text = "Halk Şairi?";
				buttonO.BackColor = Color.Yellow;
				buttonOrta.Text= "O";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==17)
			{
				richTextBox1.Text = "Çocukların Çok sevmediği pirinç,havuç gibi sebzelerle yapılan yemek?";
				buttonP.BackColor = Color.Yellow;
				buttonOrta.Text = "P";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==18)
			{
				richTextBox1.Text = "11 ayın sultanı?";
				buttonR.BackColor = Color.Yellow;
				buttonOrta.Text = "R";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==19)
			{
				richTextBox1.Text = "İngilizcede yılan?";
				buttonS.BackColor = Color.Yellow;
				buttonOrta.Text = "S";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==20)
			{
				richTextBox1.Text = "Türkiye`nin Megastar`ı";
				buttonT.BackColor = Color.Yellow;
				buttonOrta.Text = "T";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==21)
			{
				richTextBox1.Text = "Ümit kelimesinin eş anlamlısı??";
				buttonU.BackColor = Color.Yellow;
				buttonOrta.Text = "U";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==22)
			{
				richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
				buttonV.BackColor = Color.Yellow;
				buttonOrta.Text= "V";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==23)
			{
				richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
				buttonY.BackColor = Color.Yellow;
				buttonOrta.Text = "Y";
				buttonOrta.BackColor = Color.Aquamarine;
			}
			if (soruno ==24)
			{
				richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan ve yağı da yapılan bir kahvaltı besinidir?";
				buttonZ.BackColor = Color.Yellow;
				buttonOrta.Text = "Z";
				buttonOrta.BackColor = Color.Aquamarine;
			}
		}
	}
}
