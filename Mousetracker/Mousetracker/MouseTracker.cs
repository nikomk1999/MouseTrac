using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mousetracker
{
    public partial class MouseTracker : Form
    {
        public MouseTracker()
        {
            InitializeComponent();
        }

        public void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            lblx.Visible = true;
            lbly.Visible = true;
            buttonstart.Visible = false;
            GameButton.Visible = true;



            Thread trackerThread = new Thread(Tracker); //makes a new thread for the code bellow
            trackerThread.Start();
        
        }
        private void Tracker()
        {
            while (true) // infinite loop
            {
                int x = MousePosition.X;
                int y = MousePosition.Y; // gets the mouse possition

                lblx.Text = x.ToString();
                lbly.Text = y.ToString(); // sets the form1's text field named "lbly" to the int value
            }
        }

        private void ButAbout_MouseClick(object sender, MouseEventArgs e)
        {
            About f2 = new About();
            f2.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int Score = 0;
            Target.Visible = true;
            TargX.Visible = true;
            TargY.Visible = true;
            Score2.Visible = true;
            Scorel.Visible = true;
            GameButton.Visible = false;
            EndButton.Visible = true;
            int My = MousePosition.Y;
            int Mx = MousePosition.X;
            Random r = new Random();
            int rIntX = r.Next(0, 1919);
            int rIntY = r.Next(0, 1079);
            TargX.Text = rIntX.ToString();
            TargY.Text = rIntY.ToString();
            Thread GamingThread = new Thread(Gamer); //makes a new thread for the code bellow
            GamingThread.Start();
            /* {
                if (My == rIntY && Mx == rIntX) ;
                {
                    Scorel.Text = Score + 1.ToString();
                    Random a = new Random();
                    int aIntX = r.Next(0, 1919);
                    int aIntY = r.Next(0, 1079);
                    TargX.Text = rIntX.ToString();
                    TargY.Text = rIntY.ToString();

                }
            } */
            
        }
        private void Gamer()
        {
            void DrawEllipseRectangle(PaintEventArgs e)
            {
                // Create pen.
                Pen blackPen = new Pen(Color.Black, 3);

                // Create rectangle for ellipse.
                int MY = MousePosition.Y;
                int MX = MousePosition.X;
                Rectangle rect = new Rectangle(MX, MY, 200, 100);

                // Draw ellipse to screen.
                e.Graphics.DrawEllipse(blackPen, rect);
            }
            int My = MousePosition.Y;
            int Mx = MousePosition.X;
            int rIntX;
            int rIntY;
            int Score = 0;

            
            Scorel.Text = Score.ToString();
            Random r = new Random();
            rIntX = r.Next(0, 1919);
            rIntY = r.Next(0, 1079);
            int radius = 5;
            int rIntYRad = rIntY + radius;
            int rIntXRad = rIntX + radius;

            if (My <= rIntYRad && My >= -rIntYRad && Mx <= rIntXRad && Mx >= -rIntXRad)
            {
                Scorel.Text = Score + 1.ToString(); ;
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Target.Visible = false;
            TargX.Visible = false;
            TargY.Visible = false;
            Score2.Visible = false;
            Scorel.Visible = false;
            GameButton.Visible = true;
            EndButton.Visible = false;
            Scorel.Text = 0.ToString();

            //GamingThread.Stop();
        }

        private void MouseTracker_Load(object sender, EventArgs e)
        {
            
            //button1_MouseClick.trackerThread.();
        }
    }
}
