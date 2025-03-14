using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();           
            textBox1.Clear();
            

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmında ki kıyı bölgesi ?";
                buton1.BackColor = Color.Yellow;
                btnharf.Text = "A";
                MessageBox.Show("oyun başlıyor");
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz ?";
                buton2.BackColor = Color.Yellow;
                btnharf.Text = "B"; 
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                buton3.BackColor = Color.Yellow;
                btnharf.Text = "C";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz ?";
                buton4.BackColor = Color.Yellow;
                btnharf.Text = "D";
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "yeni kelimesinin zıt anlamlısı ?";
                buton5.BackColor = Color.Yellow;
                btnharf.Text = "E";                   
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                buton6.BackColor = Color.Yellow;
                btnharf.Text = "F";
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                buton7.BackColor = Color.Yellow;
                btnharf.Text = "G";
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne ?";
                buton8.BackColor = Color.Yellow;
                btnharf.Text = "H";
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz ?";
                buton9.BackColor = Color.Yellow;
                btnharf.Text = "I";
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi ?";
                buton10.BackColor = Color.Yellow;
                btnharf.Text = "İ";
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                buton11.BackColor = Color.Yellow;
                btnharf.Text = "J";
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi ?";
                buton12.BackColor = Color.Yellow;
                btnharf.Text = "K";
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali ?";
                buton13.BackColor = Color.Yellow;
                btnharf.Text = "L";
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın 3.Ayı  ?";
                buton14.BackColor = Color.Yellow;
                btnharf.Text = "M";
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti ?";
                buton15.BackColor = Color.Yellow;
                btnharf.Text = "N";
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi ?";
                buton16.BackColor = Color.Yellow;
                btnharf.Text = "O";
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile  yapılan yemek  ?";
                buton17.BackColor = Color.Yellow;
                btnharf.Text = "P";
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11 Ayın Sultanı ?";
                buton18.BackColor = Color.Yellow;
                btnharf.Text = "R";
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan ?";
                buton19.BackColor = Color.Yellow;
                btnharf.Text = "S";
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı ?";
                buton20.BackColor = Color.Yellow;
                btnharf.Text = "T";
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                buton21.BackColor = Color.Yellow;
                btnharf.Text = "U"; 
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "kahvaltısı ile ünlü ilimiz ?";
                buton22.BackColor = Color.Yellow;
                btnharf.Text = "V";
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı ?";
                buton23.BackColor = Color.Yellow;
                btnharf.Text = "Y";
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesininin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini ?";
                buton24.BackColor = Color.Yellow;
                btnharf.Text = "z";
               
            }             

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {      
                    // cevap 1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buton1.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            
                        }
                        else
                        {
                            buton1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            buton2.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 3
                    case 3:
                        if (textBox1.Text =="cuma")
                        {
                            buton3.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();

                        }
                        else
                        {
                            buton3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buton4.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            buton5.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                        // cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            buton6.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            buton7.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 8
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            buton8.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buton9.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            buton10.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            buton11.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            buton12.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton12.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            buton13.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            buton14.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            buton15.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            buton16.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton16.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            buton17.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            buton18.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            buton19.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            buton20.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            buton21.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton21.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            buton22.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton22.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            buton23.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            buton23.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            buton24.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            linkLabel1.Text = "Bitti";
                            linkLabel1.Enabled = false;
                            MessageBox.Show("oyunumuz bitti");
                            


                        }
                        else
                        {
                            buton24.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            linkLabel1.Text = "Bitti";
                            linkLabel1.Enabled = false;
                            MessageBox.Show("oyunumuz bitti");
                        }
                        break;
                        
                        




                }
            }
        }
    }


}


