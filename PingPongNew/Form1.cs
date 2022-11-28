using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongNew
{
    public partial class Form1 : Form
    {
        public int speed_left = 8;
        public int speed_top = 8;
        public int point = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = panel1.Bottom - (panel1.Bottom / 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom>=racket.Top&&ball.Bottom<=racket.Bottom&&ball.Left>=racket.Left&&ball.Right<=racket.Right)
            {
                speed_top += 8;
                speed_left += 8;
                speed_top = -speed_top;
                point += 4;
            }

            if (ball.Left<=panel1.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right>=panel1.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top<=panel1.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom>=panel1.Bottom)
            {
                timer1.Enabled = false;
            }
        }
    }
}
