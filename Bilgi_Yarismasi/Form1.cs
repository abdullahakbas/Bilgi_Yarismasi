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
            //Bu ba�taki Ba�lat butonudur
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
            label8.Text = "Do�ru Say�s� : " + dogru.ToString();
            label9.Text = "Yanl�� Say�s� : " + yanlis.ToString();
            label8.Visible = true;
            label9.Visible = true;
            button3.Visible = true;
            button3.Enabled = true;
            timer1.Enabled = false;
            button4.Visible = true;
            if (dogru >= 15)
            {
                button4.BackColor = Color.Green;
                button4.Text = "Ba�ar�l�";
            }
            else if (dogru < 20)
            {
                button4.BackColor = Color.Red;
                button4.Text = "Ba�ar�s�z";
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
                richTextBox1.Text = "A�a��dakilerden hangisi C#' taki veri t�rlerinden biridir?";
                buttonA.Text = "Int";
                buttonB.Text = "String";
                buttonC.Text = "Long";
                buttonD.Text = "Hepsi";
                label7.Text = "Hepsi";
            }
            else if (soru == 2)
            {
                richTextBox1.Text = "A�a��dakilerde hangisi C# ta Yorum sat�r�n�n ba��na konan simgedir?";
                buttonD.Text = "--";
                buttonC.Text = "++";
                buttonB.Text = "**";
                buttonA.Text = "//";
                label7.Text = "//";
            }
            else if (soru == 3)
            {
                richTextBox1.Text = "A�a��dakilerden hangisi C# ta veya anlam�na gelen operat�rd�r?";
                buttonA.Text = "+";
                buttonB.Text = "|";
                buttonC.Text = "&&";
                buttonD.Text = "=";
                label7.Text = "|";
            }
            else if (soru == 4)
            {
                richTextBox1.Text =  "C# ta bir d�ng�y� durdurmak i�in kullan�lan ifade a�a��dakilerden hangisidir?";
                buttonA.Text = "stop";
                buttonB.Text = "start";
                buttonC.Text = "break";
                buttonD.Text = "exit";
                label7.Text = "break";
            }
            else if (soru == 5)
            {
                richTextBox1.Text =  "A�a��dakilerden hangisi C# ta atama operat�r�d�r?";
                buttonA.Text = "+";
                buttonB.Text = "-";
                buttonC.Text = "=";
                buttonD.Text = "/";
                label7.Text = "=";
            }
            else if (soru == 6)
            {
                richTextBox1.Text = "A�a��dakilerden hangisi C# ta bir d�ng� �esidi de�ildir?";
                buttonA.Text = "while";
                buttonB.Text = "do while";
                buttonC.Text = "foreach";
                buttonD.Text = "static";
                label7.Text = "static";
            }
            else if (soru == 7)
            {
                richTextBox1.Text =  "C# ta swift-case ko�ulunun if-else ko�ulundaki else kar��l��� nedir?";
                buttonA.Text = "break";
                buttonB.Text = "default";
                buttonC.Text = "swift";
                buttonD.Text = "case";
                label7.Text = "default";
            }
            else if (soru == 8)
            {
                richTextBox1.Text =  "C# ta de�i�kenleri ba�ka bir de�i�kene d�n��t�rmek i�in kullan�lan ifade hangisidir?";
                buttonA.Text = "For";
                buttonB.Text = "return";
                buttonC.Text = "convert";
                buttonD.Text = "replay";
                label7.Text = "convert";
            }
            else if (soru == 9)
            {
                richTextBox1.Text =  "C# ta b�lme i�leminden kalan� g�steren operat�r hangisidir?";
                buttonA.Text = "%";
                buttonB.Text = "*";
                buttonC.Text = "/";
                buttonD.Text = "<";
                label7.Text = "%";
            }
            else if (soru == 10)
            {
                richTextBox1.Text =  "A�a��dakilerden hangisi C# ta tam say�lar� temsil eden de�i�kenlerden en k�����d�r?";
                buttonA.Text = "short";
                buttonB.Text = "long";
                buttonC.Text = "byte";
                buttonD.Text = "int";
                label7.Text = "byte";
            }
            else if (soru == 11)
            {
                richTextBox1.Text =  "A�a��dakilerden hangisi klavyeden giri� yapmak istedi�imizde kulland���m�z ara�t�r?";
                buttonA.Text = "button";
                buttonB.Text = "textbox";
                buttonC.Text = "label";
                buttonD.Text = "groupbox";
                label7.Text = "textbox";
            }
            else if (soru == 12)
            {
                richTextBox1.Text =  "Yaz�l�m dillerinde veri tutan ve farkl� de�erler alabilen yap�ya ne nedir?";
                buttonA.Text = "program";
                buttonB.Text = "sabit";
                buttonC.Text = "analiz";
                buttonD.Text = "de�i�ken";
                label7.Text = "de�i�ken";
            }
            else if (soru == 13)
            {
                richTextBox1.Text =  "C# ta tam say�lar� ifade eden en b�y�k de�i�ken hangisidir?";
                buttonA.Text = "long";
                buttonB.Text = "tall";
                buttonC.Text = "int";
                buttonD.Text = "byte";
                label7.Text = "long";
            }
            else if (soru == 14)
            {
                richTextBox1.Text =  "C# Form'da nesnenin g�r�n�rl�k �zelli�ini a��p kapatmaya yarayan �zellik hangisidir?";
                buttonA.Text = "text";
                buttonB.Text = "enable";
                buttonC.Text = "visible";
                buttonD.Text = "item";
                label7.Text = "visible";
            }
            else if (soru == 15)
            {
                richTextBox1.Text =  "A�a��dakilerden hangisi C# ta t�m veri tiplerini okuyan-anlayan de�i�kendir?";
                buttonA.Text = "int";
                buttonB.Text = "object";
                buttonC.Text = "double";
                buttonD.Text = "char";
                label7.Text = "object";
            }
            else if (soru == 16)
            {
                richTextBox1.Text =  "int a = 1 , buna g�re a�a��daki while( ? ) d�ng�lerinden hangisi sonsuz d�ng�ye girer?";
                buttonA.Text = "a==2";
                buttonB.Text = "a>=2";
                buttonC.Text = "a==0";
                buttonD.Text = "true";
                label7.Text = "true";
            }
            else if (soru == 17)
            {
                richTextBox1.Text =  "C# ta bir nesnenin aktif veya devre d��� b�rak�labilmesini sa�layan kod hangisidir?";
                buttonA.Text = "visible";
                buttonB.Text = "enable";
                buttonC.Text = "item";
                buttonD.Text = "text";
                label7.Text = "enable";
            }
            else if (soru == 18)
            {
                richTextBox1.Text = "using System.Data; �eklinde ba�layan ve genellikle kod sat�r�n�n en ba��nda yazan kod nedir?";
                buttonA.Text = "k�t�phane";
                buttonB.Text = "d�ng�";
                buttonC.Text = "de�i�ken";
                buttonD.Text = "metod";
                label7.Text = "k�t�phane";
            }
            else if (soru == 19)
            {
                richTextBox1.Text =  "C# ta bir nesnenin �zerindeki yaz�y� de�i�tirmemizi sa�layan kod hangisidir?";
                buttonA.Text = "visible";
                buttonB.Text = "item";
                buttonC.Text = "text";
                buttonD.Text = "enable";
                label7.Text = "text";
            }
            else if (soru == 20)
            {
                richTextBox1.Text =  "A�a��dakilerden hangisi C# ta ondal�kl� say�lar� tutan de�i�kendir?";
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
