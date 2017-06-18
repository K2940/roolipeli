using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roolipeli
{
    public partial class Form1 : Form
    {
        enum sijainti
        {
            left, right, up, down
        }

        private int _x;
        private int _y;
        private sijainti _objsijainti;

        public Form1()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            _objsijainti = sijainti.down;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkViolet, _x, _y, 100,100);
            //e.Graphics.DrawImage(new Bitmap("fenxprofiili2.5.png") , _x, _y, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_objsijainti == sijainti.right)
            {
            _x += 10;

            }
            else if (_objsijainti == sijainti.left)
            {
                _x -= 10;

            }
            else if (_objsijainti == sijainti.up)
            {
                _y -= 10;

            }
            else if (_objsijainti == sijainti.down)
            {
                _y += 10;

            }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objsijainti = sijainti.left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objsijainti = sijainti.right;

            }
            else if (e.KeyCode == Keys.Up)
            {
                _objsijainti = sijainti.up;

            }
            else if (e.KeyCode == Keys.Down)
            {
                _objsijainti = sijainti.down;

            }
        
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }


    }
}
