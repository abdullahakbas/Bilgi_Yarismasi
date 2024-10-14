using System.Data;
using System.Runtime.InteropServices;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Devredisi();
            Sorular();
            button1.Location = new System.Drawing.Point(265, 190);
            label8.Location = new System.Drawing.Point();
            label10.Text = "Created By Abdullah A.";
            label10.Location = new System.Drawing.Point(19, 388);
            button3.Location = new System.Drawing.Point(248, 288);
            label9.Location = new System.Drawing.Point(73, 168);
            label8.Location = new System.Drawing.Point(73, 87);
            button4.Location = new System.Drawing.Point(333, 127);
            button4.Enabled = false;
            button3.Enabled = false;
            timer1.Interval = 1000;
            label11.Text = "Kalan zaman = 20:00";
            label11.Location = new System.Drawing.Point(12, 320);
        }
        byte soru, dogru, yanlis;
        byte saniye = 60, dakika = 19;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Devredisi()
        {
            richTextBox1.Enabled = false;
            richTextBox1.Visible = false;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonA.Visible = false;
            buttonB.Visible = false;
            buttonC.Visible = false;
            buttonD.Visible = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            label11.Enabled = false;
            label11.Visible = false;
        }
        public void etkin()
        {
            richTextBox1.Enabled = true;
            richTextBox1.Visible = true;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
            label11.Enabled = true;
            label11.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Bu baþtaki Baþlat butonudur
            timer1.Enabled = true;
            etkin();
            button1.Enabled = false;
            button1.Visible = false;
            label4.Text = soru.ToString();
            soru++;
            button2.Enabled = false;
            Sorular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bu Sonraki Butonudur
            soru++;
            Sorular();
            label4.Text = soru.ToString();
            label5.Text = dogru.ToString();
            label6.Text = yanlis.ToString();
            button2.Enabled = false;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            if (soru > 20)
            {
                bitis();
            }
        }
        public void bitis()
        {
            Devredisi();
            label8.Text = "Doðru Sayýsý : " + dogru.ToString();
            label9.Text = "Yanlýþ Sayýsý : " + yanlis.ToString();
            label8.Visible = true;
            label9.Visible = true;
            button3.Visible = true;
            button3.Enabled = true;
            timer1.Enabled = false;
            button4.Visible = true;
            if (dogru >= 15)
            {
                button4.BackColor = Color.Green;
                button4.Text = "Baþarýlý";
            }
            else if (dogru < 20)
            {
                button4.BackColor = Color.Red;
                button4.Text = "Baþarýsýz";
            }
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonA.Text == label7.Text)
            {
                dogru++;
                this.buttonA.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                this.buttonA.BackColor = Color.Red;
            }
            button2.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (buttonB.Text == label7.Text)
            {
                dogru++;
                this.buttonB.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                this.buttonB.BackColor = Color.Red;
            }
            button2.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (buttonC.Text == label7.Text)
            {
                dogru++;
                this.buttonC.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                this.buttonC.BackColor = Color.Red;
            }
            button2.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (buttonD.Text == label7.Text)
            {
                dogru++;
                this.buttonD.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                this.buttonD.BackColor = Color.Red;
            }
            button2.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }
        public void Sorular()
        {
            if (soru == 1)
            {
                richTextBox1.Text = "Aþaðýdakilerden hangisi C#' taki veri türlerinden biridir?";
                buttonA.Text = "Int";
                buttonB.Text = "String";
                buttonC.Text = "Long";
                buttonD.Text = "Hepsi";
                label7.Text = "Hepsi";
            }
            else if (soru == 2)
            {
                richTextBox1.Text = "Aþaðýdakilerde hangisi C# ta Yorum satýrýnýn baþýna konan simgedir?";
                buttonD.Text = "--";
                buttonC.Text = "++";
                buttonB.Text = "**";
                buttonA.Text = "//";
                label7.Text = "//";
            }
            else if (soru == 3)
            {
                richTextBox1.Text = "Aþaðýdakilerden hangisi C# ta veya anlamýna gelen operatördür?";
                buttonA.Text = "+";
                buttonB.Text = "|";
                buttonC.Text = "&&";
                buttonD.Text = "=";
                label7.Text = "|";
            }
            else if (soru == 4)
            {
                richTextBox1.Text =  "C# ta bir döngüyü durdurmak için kullanýlan ifade aþaðýdakilerden hangisidir?";
                buttonA.Text = "stop";
                buttonB.Text = "start";
                buttonC.Text = "break";
                buttonD.Text = "exit";
                label7.Text = "break";
            }
            else if (soru == 5)
            {
                richTextBox1.Text =  "Aþaðýdakilerden hangisi C# ta atama operatörüdür?";
                buttonA.Text = "+";
                buttonB.Text = "-";
                buttonC.Text = "=";
                buttonD.Text = "/";
                label7.Text = "=";
            }
            else if (soru == 6)
            {
                richTextBox1.Text = "Aþaðýdakilerden hangisi C# ta bir döngü çesidi deðildir?";
                buttonA.Text = "while";
                buttonB.Text = "do while";
                buttonC.Text = "foreach";
                buttonD.Text = "static";
                label7.Text = "static";
            }
            else if (soru == 7)
            {
                richTextBox1.Text =  "C# ta swift-case koþulunun if-else koþulundaki else karþýlýðý nedir?";
                buttonA.Text = "break";
                buttonB.Text = "default";
                buttonC.Text = "swift";
                buttonD.Text = "case";
                label7.Text = "default";
            }
            else if (soru == 8)
            {
                richTextBox1.Text =  "C# ta deðiþkenleri baþka bir deðiþkene dönüþtürmek için kullanýlan ifade hangisidir?";
                buttonA.Text = "For";
                buttonB.Text = "return";
                buttonC.Text = "convert";
                buttonD.Text = "replay";
                label7.Text = "convert";
            }
            else if (soru == 9)
            {
                richTextBox1.Text =  "C# ta bölme iþleminden kalaný gösteren operatör hangisidir?";
                buttonA.Text = "%";
                buttonB.Text = "*";
                buttonC.Text = "/";
                buttonD.Text = "<";
                label7.Text = "%";
            }
            else if (soru == 10)
            {
                richTextBox1.Text =  "Aþaðýdakilerden hangisi C# ta tam sayýlarý temsil eden deðiþkenlerden en küçüðüdür?";
                buttonA.Text = "short";
                buttonB.Text = "long";
                buttonC.Text = "byte";
                buttonD.Text = "int";
                label7.Text = "byte";
            }
            else if (soru == 11)
            {
                richTextBox1.Text =  "Aþaðýdakilerden hangisi klavyeden giriþ yapmak istediðimizde kullandýðýmýz araçtýr?";
                buttonA.Text = "button";
                buttonB.Text = "textbox";
                buttonC.Text = "label";
                buttonD.Text = "groupbox";
                label7.Text = "textbox";
            }
            else if (soru == 12)
            {
                richTextBox1.Text =  "Yazýlým dillerinde veri tutan ve farklý deðerler alabilen yapýya ne nedir?";
                buttonA.Text = "program";
                buttonB.Text = "sabit";
                buttonC.Text = "analiz";
                buttonD.Text = "deðiþken";
                label7.Text = "deðiþken";
            }
            else if (soru == 13)
            {
                richTextBox1.Text =  "C# ta tam sayýlarý ifade eden en büyük deðiþken hangisidir?";
                buttonA.Text = "long";
                buttonB.Text = "tall";
                buttonC.Text = "int";
                buttonD.Text = "byte";
                label7.Text = "long";
            }
            else if (soru == 14)
            {
                richTextBox1.Text =  "C# Form'da nesnenin görünürlük özelliðini açýp kapatmaya yarayan özellik hangisidir?";
                buttonA.Text = "text";
                buttonB.Text = "enable";
                buttonC.Text = "visible";
                buttonD.Text = "item";
                label7.Text = "visible";
            }
            else if (soru == 15)
            {
                richTextBox1.Text =  "Aþaðýdakilerden hangisi C# ta tüm veri tiplerini okuyan-anlayan deðiþkendir?";
                buttonA.Text = "int";
                buttonB.Text = "object";
                buttonC.Text = "double";
                buttonD.Text = "char";
                label7.Text = "object";
            }
            else if (soru == 16)
            {
                richTextBox1.Text =  "int a = 1 , buna göre aþaðýdaki while( ? ) döngülerinden hangisi sonsuz döngüye girer?";
                buttonA.Text = "a==2";
                buttonB.Text = "a>=2";
                buttonC.Text = "a==0";
                buttonD.Text = "true";
                label7.Text = "true";
            }
            else if (soru == 17)
            {
                richTextBox1.Text =  "C# ta bir nesnenin aktif veya devre dýþý býrakýlabilmesini saðlayan kod hangisidir?";
                buttonA.Text = "visible";
                buttonB.Text = "enable";
                buttonC.Text = "item";
                buttonD.Text = "text";
                label7.Text = "enable";
            }
            else if (soru == 18)
            {
                richTextBox1.Text = "using System.Data; þeklinde baþlayan ve genellikle kod satýrýnýn en baþýnda yazan kod nedir?";
                buttonA.Text = "kütüphane";
                buttonB.Text = "döngü";
                buttonC.Text = "deðiþken";
                buttonD.Text = "metod";
                label7.Text = "kütüphane";
            }
            else if (soru == 19)
            {
                richTextBox1.Text =  "C# ta bir nesnenin üzerindeki yazýyý deðiþtirmemizi saðlayan kod hangisidir?";
                buttonA.Text = "visible";
                buttonB.Text = "item";
                buttonC.Text = "text";
                buttonD.Text = "enable";
                label7.Text = "text";
            }
            else if (soru == 20)
            {
                richTextBox1.Text =  "Aþaðýdakilerden hangisi C# ta ondalýklý sayýlarý tutan deðiþkendir?";
                buttonA.Text = "int";
                buttonB.Text = "double";
                buttonC.Text = "byte";
                buttonD.Text = "short";
                label7.Text = "double";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            label11.Text = "Kalan zaman = " + dakika.ToString().PadLeft(2, '0') +":" + saniye.ToString().PadLeft(2, '0');
            if (saniye == 0)
            {
                saniye = 60;
                dakika--;
            }
            if (dakika >20)
            {
                bitis();
            }
        }
    }
}
