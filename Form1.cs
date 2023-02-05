using pac_man.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pac_man
{
    public partial class Form1 : Form
    {
        static Graphics g;
        bool hold, right, left, up, down = true;
        public Form1()
        {
            InitializeComponent();
            //DrawMap1();
            Init();
        }
        public void Init()
        {
            level1();

        }

        public void level1()
        {
            DrawMap1();
            pacman.Image = MyResource.fijo;
        }

        public void DrawMap1()
        {
            Bitmap bmp = new Bitmap(400, 400);
            g = Graphics.FromImage(bmp);
            map.Image = bmp;
            g.Clear(Color.Black);


            for (int x = 0; x < mapaBase.map0.GetLength(0); x++)
            {
                for (int y = 0; y < mapaBase.map0.GetLength(1); y++)
                {


                    if (mapaBase.map0[y, x] != 0)
                    {
                        //g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 10, y * 10, 10, 10);
                        g.FillRectangle(new SolidBrush(Color.Blue), x * 10, y * 10, 10, 10);
                    }
                    else
                        g.FillRectangle(new SolidBrush(Color.Black), x * 10, y * 10, 10, 10);

                    //guía panel cuadrado para código 
                    g.DrawRectangle(Pens.Gray, x * 10, y * 10, 10, 10);
                }
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & hold)
            {
                right = true;
                hold = false;
                pacman.Image = MyResource.pac_man_d;
                pacman.Left +=5;
            }
            else if (e.KeyData == Keys.Left & hold)
            {
                left = true;
                hold = false;
                pacman.Image = MyResource.pac_man_i;
            }
            else if (e.KeyData == Keys.Up & hold)
            {
                up = true;
                hold = false;
                pacman.Image = MyResource.pac_man_ar;
            }
            else if (e.KeyData == Keys.Down & hold)
            {
                down = true;
                hold = false;
                pacman.Image = MyResource.pac_man_ab;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & !hold)
            {
                right = false;
                hold = true;
                pacman.Image = MyResource.fijo;
            }
            else if (e.KeyData == Keys.Left & !hold)
            {
                left = false;
                hold = true;
                pacman.Image = MyResource.fijo;
            }
            else if (e.KeyData == Keys.Up & !hold)
            {
                up = false;
                hold = true;
                pacman.Image = MyResource.fijo;
            }
            else if (e.KeyData == Keys.Down & !hold)
            {
                down = false;
                hold = true;
                pacman.Image = MyResource.fijo;
            }
        }
    }
}
