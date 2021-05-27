using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_CG_DrawingObjects
{
    public partial class Form1 : Form
    {
        #region Objects
        private int _x;
        private int _z;
        private int _y;
        private int _v;
        private int _v2;
        private int _v3;
        private int _p1;
        private int _p2;
        private int _p3;
        private int _p4;

        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            _x = 850;
            _y = 0;
            _z = 0;
            _v = 520;
            _v2 = 420;
            _v3 = 320;
        }
        #endregion

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region Poligonet

            //poligoni 1
            Point[] pikat = {
                new Point(0, 660),
                new Point (100,560),
                new Point(1180,560),
                new Point(1280,660),
                new Point(0,660)
            };

            e.Graphics.FillPolygon(Brushes.Gray, pikat);

            Point[] skaji1 =
            {
                new Point(0,660),
                new Point(40,660),
                new Point(140,560),
                new Point(100,560),
                new Point(0,660)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji1);

            Point[] skaji2 =
            {
                new Point(1180,560),
                new Point(1140,560),
                new Point(1240,660),
                new Point(1280,660),
                new Point(1180,560)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji2);

            Point[] greenPoints1 =
            {
               new Point(0,660),
               new Point(100, 560),
               new Point(0,560),
               new Point(0,660)
            };

            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPoints1);

            Point[] greenPoints2 =
            {
                new Point (1280,660),
                new Point (1180,560),
                new Point (1280,560),
                new Point (1280,660)
            };
            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPoints2);


            //poligoni 2
            Point[] pikat2 = {
                new Point (100,560),
                new Point(190,470),
                new Point(1090,470),
                new Point(1180,560),
                new Point (100,560),
            };
            e.Graphics.FillPolygon(Brushes.Gray, pikat2);

            Point[] skaji3 =
            {
                new Point(100,560),
                new Point(140,560),
                new Point(230,470),
                new Point(190,470),
                new Point(100,560)
            };
            e.Graphics.FillPolygon(Brushes.Black, skaji3);

            Point[] skaji4 =
            {
                new Point(1090,470),
                new Point(1050 ,470),
                new Point(1140,560),
                new Point(1180,560),
                new Point(1090,470)
            };
            e.Graphics.FillPolygon(Brushes.Black, skaji4);

            Point[] greenPoints3 =
            {
                new Point (100,560),
                new Point (0,560),
                new Point (0,470),
                new Point (190,470),
                new Point (100,560),

            };
            e.Graphics.FillPolygon(Brushes.Green, greenPoints3);

            Point[] greenPoints4 =
            {
                new Point (1180,560),
                new Point (1090,470),
                new Point (1280,470),
                new Point (1280,560),
                new Point (1180,560),
            };
            e.Graphics.FillPolygon(Brushes.Green, greenPoints4);



            //poligoni 3
            Point[] pikat3 = {
                new Point(190,470),
                new Point(270,400),
                new Point(1020,400),
                new Point(1090,470),
                new Point(190,470),
            };
            e.Graphics.FillPolygon(Brushes.Gray, pikat3);

            Point[] skaji5 =
            {
                new Point(270,400),
                new Point(310,400),
                new Point(230,470),
                new Point(190,470),
                new Point(270,400)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji5);

            Point[] skaji6 =
            {
                new Point(1020,400),
                new Point(980,400),
                new Point(1050,470),
                new Point(1090,470),
                new Point(1020,400)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji6);

            Point[] greenPoint5 = {
                new Point(270,400),
                new Point(0,400),
                new Point(0,470),
                new Point(190,470),
                new Point(270,400)
            };
            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPoint5);

            Point[] greenPOint6 =
            {
                new Point(1020,400),
                new Point(1280,400),
                new Point(1280,470),
                new Point(1090,470),
                new Point(1020,400)
            };
            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPOint6);


            //poligoni 4
            Point[] pikat4 =
            {
                new Point(270,400),
                new Point(350,340),
                new Point(940,340),
                new Point(1020,400),
                new Point(270,400)
            };
            e.Graphics.FillPolygon(Brushes.Gray, pikat4);

            Point[] skaji7 =
            {
                new Point(270,400),
                new Point(310,400),
                new Point(390,340),
                new Point(350,340),
                new Point(270,400)
            };
            e.Graphics.FillPolygon(Brushes.Black, skaji7);

            Point[] skaji8 =
            {
                new Point(940,340),
                new Point(900,340),
                new Point(980,400),
                new Point(1020,400),
                new Point(940,340)
            };
            e.Graphics.FillPolygon(Brushes.Black, skaji8);

            Point[] greenPoint7 =
            {
                new Point(270,400),
                new Point(0,400),
                new Point (0,340),
                new Point(350,340),
                new Point(270,400)
            };
            e.Graphics.FillPolygon(Brushes.Green, greenPoint7);

            Point[] greenPoint8 =
            {
                new Point(940,340),
                new Point(1280,340),
                new Point(1280,400),
                new Point(1020,400),
                new Point(940,340)
            };
            e.Graphics.FillPolygon(Brushes.Green, greenPoint8);

            e.Graphics.FillRectangle(Brushes.SkyBlue, 0, 0, 1280, 300);


            //poligoni 5
            Point[] pikat5 =
            {
                new Point(350,340),
                new Point(420, 300),
                new Point(870,300),
                new Point(940,340),
                new Point(350,340),
            };
            e.Graphics.FillPolygon(Brushes.Gray, pikat5);

            Point[] skaji9 =
            {
                new Point(350,340),
                new Point(390,340),
                new Point(460,300),
                new Point(420,300),
                new Point(350,340)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji9);

            Point[] skaji10 =
            {
                new Point(870,300),
                new Point(830,300),
                new Point(900,340),
                new Point(940,340),
                new Point(870,300)
            };
            e.Graphics.FillPolygon(Brushes.White, skaji10);

            Point[] greenPoint9 =
            {
                new Point(350,340),
                new Point(0,340),
                new Point(0,300),
                new Point(420,300),
                new  Point(350,340)
            };
            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPoint9);

            Point[] greenPoint10 =
            {
                new Point(870,300),
                new Point(1280 ,300),
                new Point(1280,340),
                new Point(940,340),
                new Point(870,300)
            };
            e.Graphics.FillPolygon(Brushes.DarkGreen, greenPoint10);

            #endregion

            #region Malet
            //mountains
            Point[] mountainsPoints1 =
            {
                new Point(0,300),
                new Point(50,200),
                new Point(100,300),
                new Point(0,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainsPoints1);

            Point[] mountainPoints2 =
            {
                new Point(20,300),
                new Point(80,150),
                new Point(150,300),
                new Point(20,300),
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoints2);

            Point[] mountainPoints3 =
            {
                new Point(130,300),
                new Point(180,130),
                new Point(250,300),
                new Point(130,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoints3);

            Point[] mountainPoint4 =
            {
                new Point(200,300),
                new Point(240,150),
                new Point(310,300),
                new Point(200,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoint4);




            //left
            Point[] mountainsPoints6 =
           {
                new Point(800,300),
                new Point(850,200),
                new Point(900,300),
                new Point(800,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainsPoints6);

            Point[] mountainPoints7 =
            {
                new Point(820,300),
                new Point(880,150),
                new Point(950,300),
                new Point(820,300),
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoints7);

            Point[] mountainPoints8 =
            {
                new Point(930,300),
                new Point(980,130),
                new Point(1050,300),
                new Point(930,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoints8);

            Point[] mountainPoint9 =
           {
                new Point(1000,300),
                new Point(1040,150),
                new Point(1110,300),
                new Point(1000,300)
            };
            e.Graphics.FillPolygon(Brushes.Olive, mountainPoint9);
            #endregion

            #region Dielli
            //Sun
            e.Graphics.FillEllipse(Brushes.Gold, _x, _y, 130, 130);
            #endregion

            #region Rete
            //Cloud1
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 10, 70, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 40, 50, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 50, 80, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 40, 90, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 70, 70, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 110, 100, 120, 80);

            //Cloud2
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 300, 100, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 330, 80, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 370, 110, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 360, 120, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 390, 100, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 430, 130, 120, 80);

            //Cloud3
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 600, 40, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 630, 20, 120, 108);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 670, 50, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 660, 60, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 690, 40, 120, 108);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 730, 70, 110, 70);

            //Cloud4
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 900, 80, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 930, 60, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 970, 90, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 960, 100, 120, 80);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 990, 80, 130, 118);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1030, 110, 120, 80);

            //Cloud5
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1100, 40, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1130, 20, 120, 108);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1170, 50, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1160, 60, 110, 70);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1190, 40, 120, 108);
            e.Graphics.FillEllipse(Brushes.LightGray, _z + 1230, 70, 110, 70);
            #endregion

            #region VijaHorizontale
            //WhiteStreetLines
            Point[] whiteLine1 =
            {
                new Point(610,660),
                new Point(650,300),
                new Point(660, 300),
                new Point(700,660),
                new Point(610,660)
            };
            e.Graphics.FillPolygon(Brushes.White, whiteLine1);
            #endregion

            #region RectHorizontale
            //GrayStreetLines 
            e.Graphics.FillRectangle(Brushes.Gray, 610, _v, 100, 50);
            e.Graphics.FillRectangle(Brushes.Gray, 610, _v2, 100, 50);
            e.Graphics.FillRectangle(Brushes.Gray, 610, _v3, 100, 50);
            #endregion

            #region Pemet
            //Tree1
            e.Graphics.FillRectangle(Brushes.SaddleBrown, 75, 480, 30, 80);
            Point[] pema1 =
            {
                new Point(10,500),
                new Point(95,350),
                new Point(95,350),
                new Point(170,500),
            };
            e.Graphics.FillPolygon(Brushes.OliveDrab, pema1);

            //Tree2
            e.Graphics.FillRectangle(Brushes.SaddleBrown, 190, 330, 20, 40);
            Point[] pema2 =
            {
                new Point(150,330),
                new Point(200,250),
                new Point(200,250),
                new Point(250,330),
            };
            e.Graphics.FillPolygon(Brushes.OliveDrab, pema2);
            #endregion


            e.Graphics.FillRectangle(Brushes.Black, 549, 386, 10, 120);
            e.Graphics.FillRectangle(Brushes.Black, 505, 386, 10, 120);

        }


        #region nimp
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Black, 110, 120, 113, 60);
            //.Graphics.FillEllipse(Brushes.Red, 105, 20, 30, 55);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //bmg = Graphics.FromImage(bm);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Gray, 0, 0, 523, 350);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
        private void tmrCar_Tick(object sender, EventArgs e)
        {

        }

        #endregion

        #region MovingObjects
        //Move clouds and sun
        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_y < 290)
            {
                _x += 5;
                _y += 5;
                _z += 25;
                Invalidate();
            }
            else
            {
                _x = 750;
                _y = -100;
                _z = -1205;
            }
        }
        #endregion


        #region KeyEvents
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if(_v>300)
                _v += -1;
                else
                {
                    _v = 590;
                }

                if (_v2 > 300)
                    _v2 += -1;
                else
                {
                    _v2 = 590;
                }

            if (_v3 > 300)
                _v3 += -1;
            else
            {
                _v3 = 590;
            }

            }
        }


        #endregion

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, 160, 250, 100, 100);
        }
    }
}
