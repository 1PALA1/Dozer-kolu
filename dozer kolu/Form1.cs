using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dozer_kolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics cizim;
        SolidBrush yeşil = new SolidBrush(Color.Green);
        SolidBrush mavi = new SolidBrush(Color.Blue);
        SolidBrush kirmizi = new SolidBrush(Color.Red);

        int acikol = 0;
        int acigövde = 0;
        int X1 = 200, X2 = 0, X3 = 0, X4 = 0, X5 = 0, X6 = 0;
        int Y1 = 200, Y2 = 0, Y3 = 0, Y4 = 0, Y5 = 0, Y6 = 0;

        private void BASLA_Click(object sender, EventArgs e)
        {
            gövde();
            kol(acikol);
            kepce(acigövde);
            BASLA.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Refresh();
                acigövde++;
                gövde();
                kol(acikol);
                kepce(acigövde);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Refresh();
                acigövde--;
                gövde();
                kol(acikol);
                kepce(acigövde);

            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Refresh();
                acikol++;
                gövde();
                kol(acikol);
                kepce(acigövde);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Refresh();
                acikol--;
                gövde();
                kol(acikol);
                kepce(acigövde);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cizim = pictureBox1.CreateGraphics();
        }

        public double dereceradyan(int aciderece)
        {
            double aciradyan = aciderece * 2 * Math.PI / 360;
            return aciradyan;
        }

        public void kol(int Aci1)
        {
            Point[] kolnokta = new Point[8];

            kolnokta[0].X = X1;
            kolnokta[0].Y = Y1;

            X2 = Convert.ToInt16(X1 + Math.Cos(dereceradyan(acikol)) * 200);
            Y2 = Convert.ToInt16(Y1 + Math.Sin(dereceradyan(acikol)) * 200);
            X3 = Convert.ToInt16(X1 + Math.Cos(dereceradyan(acikol + 90)) * 25);
            Y3 = Convert.ToInt16(Y1 + Math.Sin(dereceradyan(acikol + 90)) * 25);
            X4 = Convert.ToInt16(X1 + Math.Cos(dereceradyan(acikol + 7)) * 202);
            Y4 = Convert.ToInt16(Y1 + Math.Sin(dereceradyan(acikol + 7)) * 202);


            kolnokta[0].X = X1;
            kolnokta[0].Y = Y1;
            kolnokta[1].X = X2;
            kolnokta[1].Y = Y2;
            kolnokta[3].X = X3;
            kolnokta[3].Y = Y3;
            kolnokta[2].X = X4;
            kolnokta[2].Y = Y4;
            kolnokta[4].X = X1;
            kolnokta[4].Y = Y1;

            cizim.FillPolygon(mavi, kolnokta);
        }
        public void kepce(int Aci2)
        {
            Point[] kepcenokta = new Point[4];

            X5 = Convert.ToInt16(X2 + Math.Cos(dereceradyan(acigövde)) * 120);
            Y5 = Convert.ToInt16(Y2 + Math.Sin(dereceradyan(acigövde)) * 120);
            X6 = Convert.ToInt16(X2 + Math.Cos(dereceradyan(acigövde + 45)) * 71);
            Y6 = Convert.ToInt16(Y2 + Math.Sin(dereceradyan(acigövde + 45)) * 71);


            kepcenokta[0].X = X2;
            kepcenokta[0].Y = Y2;
            kepcenokta[1].X = X5;
            kepcenokta[1].Y = Y5;
            kepcenokta[2].X = X6;
            kepcenokta[2].Y = Y6;
            kepcenokta[3].X = X2;
            kepcenokta[3].Y = Y2;


            cizim.FillPolygon(kirmizi, kepcenokta);
        }
        public void gövde()
        {
            Point[] gövdenokta = new Point[5];
            gövdenokta[0].X = 50;
            gövdenokta[0].Y = 150;
            gövdenokta[1].X = 200;
            gövdenokta[1].Y = 150;
            gövdenokta[2].X = 200;
            gövdenokta[2].Y = 300;
            gövdenokta[3].X = 50;
            gövdenokta[3].Y = 300;
            gövdenokta[4].X = 50;
            gövdenokta[4].Y = 150;
            cizim.FillPolygon(yeşil, gövdenokta);
        }
    }
}
