/****************************************************************************
** SAKARYA �N�VERS�TES�
** B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
** B�LG�SAYAR M�HEND�SL��� B�L�M�
** PROGRAMLAMAYA G�R��� DERS�
**
** �DEV NUMARASI�...: 1
** ��RENC� ADI...............: Muhammed yusuf ya�c�
** ��RENC� NUMARASI.:B211210017
** DERS GRUBU����: c
YOUTUBE L�NK݅ �: https://youtube.com/playlist?list=PL49A8BNtm3R0xThhDnXdT0xACJHZ_ehmb
****************************************************************************/
namespace Odev_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Daire_Click(object sender, EventArgs e)
        {
            Graphics g =this.CreateGraphics();
            Pen kalem =new Pen(Color.Black, 3);

            int merkezX = 150;
            int merkezY = 350;
            int R = 100;

            int x = merkezX - R;
            int y = merkezY - R;
            int genislik = 2 * R;
            int yukseklik = 2 * R;  

            g.DrawEllipse(kalem , x,y,genislik, yukseklik);

        }

        private void Ucgen_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);

            Point p1 = new Point(50,150);
            Point p2 = new Point(150, 50);
            Point p3 = new Point(250, 150);

            Point[] kenarlar = { p1, p2, p3 };

            g.DrawPolygon(kalem, kenarlar);

        }

        private void Kare_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);


            int x = 350;
            int y = 50;
            int kenar = 150;

            g.DrawRectangle(kalem, x,y,kenar,kenar);
            

        }

        private void D�kdortgen_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);


            int x = 250;
            int y = 100;
            int kenar1 = 150;
            int kenar2 = 225;  

            g.DrawRectangle(kalem, x, y, kenar1, kenar2);

        }

        private void Besgen_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);

            // Be�genin merkez noktas�n� ve yar��ap�n� belirle
            int merkezX = 310;
            int merkezY = 220;
            int yariCap = 100;

            // Be�genin k��e noktalar�n� hesapla
            Point[] koseNoktalar = new Point[5];
            double aci = -Math.PI / 2; // Ba�lang�� a��s�
            double aciAdim = 2 * Math.PI / 5; // Her bir k��e i�in a�� ad�m�

            for (int i = 0; i < 5; i++)
            {
                int x = (int)(merkezX + yariCap * Math.Cos(aci));
                int y = (int)(merkezY + yariCap * Math.Sin(aci));
                koseNoktalar[i] = new Point(x, y);
                aci += aciAdim;
            }

            // Be�geni �iz
            g.DrawPolygon(kalem, koseNoktalar);

        }

        private void Altigen_Click(object sender, EventArgs e)
        {
            // �izim i�in grafik nesnesi olu�tur
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);

            // Alt�genin merkez noktas�n� ve yar��ap�n� belirle
            int merkezX = 370;
            int merkezY = 270;
            int yariCap = 100;

            // Alt�genin k��e noktalar�n� hesapla
            Point[] koseNoktalar = new Point[6];
            double aci = -Math.PI / 2; // Ba�lang�� a��s�
            double aciAdim = 2 * Math.PI / 6; // Her bir k��e i�in a�� ad�m�

            for (int i = 0; i < 6; i++)
            {
                int x = (int)(merkezX + yariCap * Math.Cos(aci));
                int y = (int)(merkezY + yariCap * Math.Sin(aci));
                koseNoktalar[i] = new Point(x, y);
                aci += aciAdim;
            }

            // Alt�geni �iz
            g.DrawPolygon(kalem, koseNoktalar);
        }

        private void Silindir_Click(object sender, EventArgs e)
        {
            // �izim i�in grafik nesnesi olu�tur
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);

            // Silindirin merkez noktas�n� ve yar��ap�n� belirle
            int merkezX = 250;
            int merkezY = 100;
            int yariCap = 50;

            int merkezX1 = 250;
            int merkezY1 = 360;
            int yariCap1 = 50;

            // Silindirin taban�n� �iz
            int x = merkezX - yariCap;
            int y = merkezY - yariCap;
            int genislik = 4 * yariCap;
            int yukseklik = yariCap;

            int x1 = merkezX1 - yariCap1;
            int y1 = merkezY1 - yariCap1;
            int genislik1 = 4 * yariCap1;
            int yukseklik1 = yariCap1;

            g.DrawEllipse(new Pen(Color.Black, 5), x, y, genislik, yukseklik);
            g.DrawEllipse(new Pen(Color.Black, 5), x1, y1, genislik1, yukseklik1);
            g.DrawLine(kalem, x, y + 20, x1, y1 + 20);
            g.DrawLine(kalem, x + 4 * yariCap, y + 20, x1 + 4 * yariCap1, y1 + 20);

        }

        private void Kup_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 3);
            int x = 70;
            int y = 70;
            int boyut = 100;

            int x1 = 45;
            int y1 = 45;
            int boyut1 = 100;
            
            Point p1 = new Point(45, 145);
            Point p2 = new Point(70, 170);

            Point p3 = new Point(145, 45);
            Point p4 = new Point(170, 70);

            Point p5 = new Point(145, 145);
            Point p6 = new Point(170, 170);
            
            // Kareyi �iz
            g.DrawRectangle(kalem, x, y, boyut, boyut);
            g.DrawRectangle(kalem, x1, y1, boyut1, boyut1);
            
            g.DrawLine(kalem, p1, p2);
            g.DrawLine(kalem, p3, p4);
            g.DrawLine(kalem, p5, p6);
            g.DrawLine(kalem, x, y, x1, y1);

        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush f�rca = new SolidBrush(Color.LightCyan);

            int x =0;
            int y = 0;

            int genislik = 575;
            int yukseklik = 497;
            g.FillRectangle(f�rca,x,y,genislik,yukseklik);
        }
    }
}