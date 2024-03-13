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

namespace Flappy_birt_a_doua_incercare
{
    public partial class Form1 : Form
    {
        private bool obstacol_gbl=false;
        private bool obstacol_gb2 = false;
        private bool a = false;
        private bool b = false;
        private bool pornire = true;
      //  private bool gameover = false;
        private int point = 0;
        Random rnd = new Random();
        PictureBox obstacol1;
        PictureBox obstacol2;
        PictureBox obstacol3;
        PictureBox obstacol4;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
        

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                pictureBox1.Top += -40;

            }
        }
    
        public void obstacol_susl()
        {
          
            if(pornire==true)
            {
                if (obstacol_gbl == false)
                {
                    point = 0;
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(rnd.Next(150, 430), rnd.Next(-170, -20));
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.Red;
                    obstacol1  = pb;
                    panel1.Controls.Add(pb);
                    obstacol_gbl = true;
                    a = true;
                  //  label1.Text = "0";
                 //   point ++;
                  //  label1.Text = point.ToString();

                }

            }
            
        }
        public void obstacol_continuu()
        {
            if (pornire == false)
            {
                if (obstacol_gbl == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(obstacol3.Location.X + 200, rnd.Next(-170, -20));
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.Black;
                    obstacol1 = pb;
                    panel1.Controls.Add(pb);
                    obstacol_gbl = true;
                   a = true;
                  

                }

            }

        }


        public void obstacol_sus2()
        {
            
                if (a == true)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(obstacol1.Location.X, obstacol1.Bottom + 150);
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.Yellow;
                    obstacol2 = pb;
                    panel1.Controls.Add(pb);
                    a = false;
              //  label1.Text = "0";
               // point ++;
             //   label1.Text = point.ToString();

                }
           

        }

       
        public void obstacol_jos1()
        {
            
                if (obstacol_gb2 == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(obstacol1.Location.X + 200, rnd.Next(-170, -20));
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.Green;
                    obstacol3 = pb;
                    panel1.Controls.Add(pb);
                    obstacol_gb2 = true;
                    b = true;
                 


            }

            

        }
       private void obstacol_jos2()
        {
           
                if (b == true)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(obstacol3.Location.X, obstacol3.Bottom + 150);
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.Pink;
                    obstacol4 = pb;
                    panel1.Controls.Add(pb);
                    b = false;
                //  label1.Text = "0";
               // point++;
                   //label1.Text = point.ToString();


            }

            
               
        }

        void miscare_obstacol()
        {
            obstacol1.Left += -10;
            obstacol2.Left += -10;
            obstacol3.Left += -10;
            obstacol4.Left += -10;

            if (obstacol1.Right - 10 <= pictureBox1.Left)
            {
                panel1.Controls.Remove(obstacol1);
                panel1.Controls.Remove(obstacol2);
                point++;
                obstacol_gbl = false;
                pornire = false;
             

            }
            if (obstacol3.Right - 10 <= pictureBox1.Left)
            {
                panel1.Controls.Remove(obstacol3);
                panel1.Controls.Remove(obstacol4);
                point++;
                obstacol_gb2 = false;
                pornire = false;
                



            }

            if (pictureBox1.Right >= obstacol1.Left && pictureBox1.Right <= obstacol1.Right && pictureBox1.Top <= obstacol1.Bottom)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;


            }
   
            if (pictureBox1.Right >= obstacol2.Left && pictureBox1.Right <= obstacol2.Right && pictureBox1.Bottom >= obstacol2.Top)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;


            }
          
            if (pictureBox1.Right >= obstacol3.Left && pictureBox1.Right <= obstacol3.Right && pictureBox1.Top <= obstacol3.Bottom)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;


            }
       
            if (pictureBox1.Right >= obstacol4.Left && pictureBox1.Right <= obstacol4.Right && pictureBox1.Bottom >= obstacol4.Top)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
         
            if (pictureBox1.Location.Y >= 330)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "0";
         //   point += 1;
            label1.Text = point.ToString();
            obstacol_susl();
            obstacol_sus2();
            obstacol_jos1();
            obstacol_jos2();
            obstacol_continuu();
            miscare_obstacol();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void Reciteste()
        {
            Form1 f = new Form1();
            Application.Run(f);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Reciteste));
            t.Start();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {



        }
    }
}
