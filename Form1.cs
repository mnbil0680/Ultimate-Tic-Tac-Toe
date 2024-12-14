using problem8.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem8
{
    public partial class Form1 : Form
    {
        int counter = 9;
        public Form1()
        {
            InitializeComponent();
        }
        public void ImageChange(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {

                if (label1.Text == "Player X")
                {
                    btn.Image = Resources.X_letter_8;
                    btn.Tag = "X";
                    label1.Text = "Player O";
                    label1.Tag = "O";
                    counter--;

                    if (counter == 0)
                    {
                        // remove button image
                        foreach (Control c in this.Controls)
                        {
                            if (c is Button)
                            {
                                Button b = (Button)c;
                                b.Image = null;
                                b.Tag = "?";
                            }
                        }
                        // make button background color green

                        foreach (Control c in this.Controls)
                        {
                            if (c is Button)
                            {

                                c.BackColor = Color.Green;
                            }
                        }
                        button5.BackColor = Color.Red;




                    }


                }
                else
                {
                    btn.Image = Resources.O_letter_8;
                    btn.Tag = "O";
                    label1.Text = "Player X";
                    label1.Tag = "X";
                    counter--;
                    if (counter == 0)
                    {
                        // remove button image
                        foreach (Control c in this.Controls)
                        {
                            if (c is Button)
                            {
                                Button b = (Button)c;
                                b.Image = null;
                                b.Tag = "?";
                            }
                        }
                    }


                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button_Click(object sender, EventArgs e)
        {
            ImageChange((Button)sender);
        }
        public void mainGrid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 0, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 10;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 305, 1250, 305);
            e.Graphics.DrawLine(whitePen, 600, 485, 1250, 485);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 810, 140, 810, 640);
            e.Graphics.DrawLine(whitePen, 1040, 140, 1040, 640);
        }
        public void top_left_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 185, 800, 185);
            e.Graphics.DrawLine(whitePen, 600, 240, 800, 240);

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 665, 140, 665, 300);
            e.Graphics.DrawLine(whitePen, 735, 140, 735, 300);

        }
        public void top_center_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 890, 140, 890, 300);
            e.Graphics.DrawLine(whitePen, 960, 140, 960, 300);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 825, 185, 1025, 185);
            e.Graphics.DrawLine(whitePen, 825, 240, 1025, 240);
        }

        public void top_right_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 1115, 140, 1115, 300);
            e.Graphics.DrawLine(whitePen, 1185, 140, 1185, 300);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 1050, 185, 1250, 185);
            e.Graphics.DrawLine(whitePen, 1050, 240, 1250, 240);
        }

        public void middle_left_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 360, 800, 360);
            e.Graphics.DrawLine(whitePen, 600, 420, 800, 420);

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 665, 300, 665, 480);
            e.Graphics.DrawLine(whitePen, 735, 300, 735, 480);

        }

        public void middle_center_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 890, 300, 890, 480);
            e.Graphics.DrawLine(whitePen, 960, 300, 960, 480);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 825, 360, 1025, 360);
            e.Graphics.DrawLine(whitePen, 825, 420, 1025, 420);
        }

        public void middle_right_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 1115, 300, 1115, 480);
            e.Graphics.DrawLine(whitePen, 1185, 300, 1185, 480);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 1050, 360, 1250, 360);
            e.Graphics.DrawLine(whitePen, 1050, 420, 1250, 420);
        }

        public void bottom_left_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 540, 800, 540);
            e.Graphics.DrawLine(whitePen, 600, 600, 800, 600);

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 665, 480, 665, 640);
            e.Graphics.DrawLine(whitePen, 735, 480, 735, 640);

        }

        public void bottom_center_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 890, 480, 890, 640);
            e.Graphics.DrawLine(whitePen, 960, 480, 960, 640);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 825, 540, 1025, 540);
            e.Graphics.DrawLine(whitePen, 825, 600, 1025, 600);
        }

        public void bottom_right_grid(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 5;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Vertical lines
            e.Graphics.DrawLine(whitePen, 1115, 480, 1115, 640);
            e.Graphics.DrawLine(whitePen, 1185, 480, 1185, 640);

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 1050, 540, 1250, 540);
            e.Graphics.DrawLine(whitePen, 1050, 600, 1250, 600);
        }

        public void top_left_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 600, 145, 200, 145);
        }
        public void top_center_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 825, 145, 200, 145);
        }
        public void top_right_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 1050, 145, 200, 145);
        }

        public void middle_left_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 600, 315, 200, 145);
        }

        public void middle_center_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 825, 315, 200, 145);
        }

        public void middle_right_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 1050, 315, 200, 145);
        }

        public void bottom_left_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 600, 485, 200, 145);
        }

        public void bottom_center_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 825, 485, 200, 145);
        }

        public void bottom_right_image(object sender, PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 1050, 485, 200, 145);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw grid
            top_left_grid(sender, e);
            top_center_grid(sender, e);
            top_right_grid(sender, e);
            
            middle_left_grid(sender, e);
            middle_center_grid(sender, e);
            middle_right_grid(sender, e);
            
            bottom_left_grid(sender, e);
            bottom_center_grid(sender, e);
            bottom_right_grid(sender, e);
            


            // draw main grid
            mainGrid(sender, e);
        }


        public void handle_top_left()
        {

        }
    }
}
