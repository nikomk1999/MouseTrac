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
        private int TargetX;
        private int TargetY;
        private int Score = 0;
        private int radiusAMiRIGHTxd;




        public MouseTracker()
        {
            InitializeComponent();
            Tracker();
            Gamer();
        }

        public void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
            buttonstart.Visible = false;
            GameButton.Visible = true;
            this.label3.Location = new Point(120, 50);
        }

        private async void Tracker()
        {
            while (true) // infinite loop
            {
                await Task.Delay(10);
                int x = MousePosition.X;
                int y = MousePosition.Y; // gets the mouse possition
                radiusAMiRIGHTxd = vScrollBar1.Value;


                label3.Text = $"X {x}\nY {y}";

                //    §12345.a1-B
                int dx = TargetX - x;
				int dy = TargetY - y;

				// a² + b² = c²

				double distance = Math.Sqrt((dx * dx) + (dy * dy));
                double BLOB = 0;
                int radius = radiusAMiRIGHTxd;


				// Math.Min(Math.Max(x, minimum), maximum)


				//progressBar1.Value = (int) BLOB;
				progressBar1.Value = (int) Math.Min(Math.Max(distance/10.0, 0), 100);

				// Foony progress function bear made :) :)
				//progressBar1.Value = (int)Math.Min(Math.Max(100.0 - Math.Log(distance, 2) / 10.0 * 100.0, 0), 100);

				if (distance <= radius) 
                {
					Score = Score + 1;
					Scorel.Text = Score.ToString();
					TargetGameing();
				}
            }
        }

        private void ButAbout_MouseClick(object sender, MouseEventArgs e)
        {
            About f2 = new About();
            f2.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Target.Visible = true;
            TargX.Visible = true;
            TargY.Visible = true;
            Score2.Visible = true;
            Scorel.Visible = true;
            GameButton.Visible = false;
            EndButton.Visible = true;
            int My = MousePosition.Y;
            int Mx = MousePosition.X;
            progressBar1.Visible = true;
            vScrollBar1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            this.label3.Location = new Point(20, 50);
            TargetGameing();
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
            } 
            while (true)
            {
                Gamer();
            }*/
        }

        private void TargetGameing()
        {
            Random r = new Random();
            TargetX = r.Next(0, 1919);
            TargetY = r.Next(0, 1079);

            TargX.Text = TargetX.ToString();
            TargY.Text = TargetY.ToString();
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
                Rectangle rect = new Rectangle(0, 0, 200, 100);

                // Draw ellipse to screen.
                e.Graphics.DrawEllipse(blackPen, rect);
            }
            /*
            int My = MousePosition.Y;
            int Mx = MousePosition.X;
            int rIntX;
            int rIntY;

            
            Scorel.Text = Score.ToString();
            Random r = new Random();
            rIntX = r.Next(0, 1919);
            rIntY = r.Next(0, 1079);
            int radius = 5;
            int rIntYRad = rIntY + radius;
            int rIntXRad = rIntX + radius;
            TargX.Text = rIntX.ToString();
            TargY.Text = rIntY.ToString();
            

            if (My <= rIntYRad && My >= -rIntYRad && Mx <= rIntXRad && Mx >= -rIntXRad)
            {
                Scorel.Text = Score + 1.ToString(); ;

            }
            */
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
            progressBar1.Visible= false;
            vScrollBar1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            this.label3.Location = new Point(120, 50);
            Scorel.Text = 0.ToString();

            //GamingThread.Stop();
        }

        private void MouseTracker_Load(object sender, EventArgs e)
        {
            
            //button1_MouseClick.trackerThread.();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
