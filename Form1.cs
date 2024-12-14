using problem8.Properties;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace problem8
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Handle()
        {
            handle_top_left();
            handle_top_center();
            /*
            handle_top_right();

            handle_middle_left();
            handle_middle_center();
            handle_middle_right();

            handle_bottom_left();
            handle_bottom_center();
            handle_bottom_right();
            */
        }
        public void ImageChange(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                if (label1.Text == "Player X")
                {
                    Image img = Resources.X_letter_8;
                    img = new Bitmap(img,new Size(btn.Width-10,btn.Height-10) );
                    btn.Image = img;
                    btn.Tag = "X";
                    Handle();
                    label1.Text = "Player O";
                    label1.Tag = "O";
                    

                }
                else
                {
                    Image img = Resources.O_letter_8;
                    img = new Bitmap(img, new Size(btn.Width - 10, btn.Height - 10));
                    btn.Image = img;
                    btn.Tag = "O";
                    Handle();
                    label1.Text = "Player X";
                    label1.Tag = "X";
                    
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
            Color white = Color.FromArgb(100, 255, 255, 255);
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



        public void top_center_image(PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 825, 145, 200, 145);
        }
        public void top_right_image(PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 1050, 145, 200, 145);
        }

        public void middle_left_image(PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 600, 315, 200, 145);
        }

        public void middle_center_image(PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 825, 315, 200, 145);
        }

        public void middle_right_image(PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 1050, 315, 200, 145);
        }

        public void bottom_left_image(PaintEventArgs e)
        {
            Image img = Resources.Big_X;
            e.Graphics.DrawImage(img, 600, 485, 200, 145);
        }

        public void bottom_center_image(PaintEventArgs e)
        {
            Image img = Resources.Big_O;
            e.Graphics.DrawImage(img, 825, 485, 200, 145);
        }

        public void bottom_right_image(PaintEventArgs e)
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

        public string checkX_threeInRow(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7, Button b8, Button b9)
        {

            // check horizontals
            if (b1.Tag.ToString() == "X" && b2.Tag.ToString() == "X" && b3.Tag.ToString() == "X" ||
                b4.Tag.ToString() == "X" && b5.Tag.ToString() == "X" && b6.Tag.ToString() == "X" ||
                b7.Tag.ToString() == "X" && b8.Tag.ToString() == "X" && b9.Tag.ToString() == "X")
            {

                return "X";
            }

            // check verticals
            if (b1.Tag.ToString() == "X" && b4.Tag.ToString() == "X" && b7.Tag.ToString() == "X" ||
                b2.Tag.ToString() == "X" && b5.Tag.ToString() == "X" && b8.Tag.ToString() == "X" ||
                b3.Tag.ToString() == "X" && b6.Tag.ToString() == "X" && b9.Tag.ToString() == "X")
            {

                return "X";
            }

            // check diagonals
            if (b1.Tag.ToString() == "X" && b5.Tag.ToString() == "X" && b9.Tag.ToString() == "X" ||
                b3.Tag.ToString() == "X" && b5.Tag.ToString() == "X" && b7.Tag.ToString() == "X")
            {
                return "X";
            }

            return string.Empty;



        }

        public string checkO_threeInRow(Button b1,Button b2,Button b3,Button b4,Button b5,Button b6,Button b7,Button b8,Button b9)
        {
            // check horizontals
            if (b1.Tag.ToString() == "O" && b2.Tag.ToString() == "O" && b3.Tag.ToString() == "O" ||
                b4.Tag.ToString() == "O" && b5.Tag.ToString() == "O" && b6.Tag.ToString() == "O" ||
                b7.Tag.ToString() == "O" && b8.Tag.ToString() == "O" && b9.Tag.ToString() == "O")
            {

                return "O";
            }

            // check verticals
            if (b1.Tag.ToString() == "O" && b4.Tag.ToString() == "O" && b7.Tag.ToString() == "O" ||
                b2.Tag.ToString() == "O" && b5.Tag.ToString() == "O" && b8.Tag.ToString() == "O" ||
                b3.Tag.ToString() == "O" && b6.Tag.ToString() == "O" && b9.Tag.ToString() == "O")
            {

                return "O";
            }

            // check diagonals
            if (b1.Tag.ToString() == "O" && b5.Tag.ToString() == "O" && b9.Tag.ToString() == "O" ||
                b3.Tag.ToString() == "O" && b5.Tag.ToString() == "O" && b7.Tag.ToString() == "O")
            {
                return "O";
            }

            return string.Empty;


        }
        public void handle_top_left()
        {
            if (checkX_threeInRow(button1,button2,button3,button4,button5,button6,button7,button8,button9) == "X")
            {
                button1.Hide(); button2.Hide(); button3.Hide();
                button4.Hide(); button5.Hide(); button6.Hide();
                button7.Hide(); button8.Hide(); button9.Hide();

                // picture box
                PictureBox pb = new PictureBox();
                pb.Image = Resources.Big_X;
                pb.Location = new Point(600, 145);
                pb.Size = new Size(200, 145);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Show();
                this.Controls.Add(pb);
            }

            if (checkO_threeInRow(button1, button2, button3, button4, button5, button6, button7, button8, button9) == "O")
            {
                button1.Hide(); button2.Hide(); button3.Hide();
                button4.Hide(); button5.Hide(); button6.Hide();
                button7.Hide(); button8.Hide(); button9.Hide();

                // picture box
                PictureBox pb = new PictureBox();
                pb.Image = Resources.Big_O;
                pb.Location = new Point(600, 145);
                pb.Size = new Size(200, 145);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Show();
                this.Controls.Add(pb);

            }
        }

        public void handle_top_center()
        {

            if (checkX_threeInRow(button1, button2, button3, button4, button5, button6, button7, button8, button9) == "X")
            {
                button1.Hide(); button2.Hide(); button3.Hide();
                button4.Hide(); button5.Hide(); button6.Hide();
                button7.Hide(); button8.Hide(); button9.Hide();

                // picture box
                PictureBox pb = new PictureBox();
                pb.Image = Resources.Big_X;
                pb.Location = new Point(600, 145);
                pb.Size = new Size(200, 145);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Show();
                this.Controls.Add(pb);
            }

            if (checkO_threeInRow(button18, button17, button16, button13, button14, button15, button10, button11, button12) == "O")
            {
                button18.Hide(); button17.Hide(); button16.Hide();
                button13.Hide(); button14.Hide(); button15.Hide();
                button10.Hide(); button11.Hide(); button12.Hide();
                

                // picture box
                PictureBox pb = new PictureBox();
                pb.Image = Resources.Big_O;
                pb.Location = new Point(825, 145);
                pb.Size = new Size(200, 145);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Show();
                this.Controls.Add(pb);






                //PictureBox pb = new PictureBox();
                //pb.Image = Resources.Big_O;
                //pb.Location = new Point(600, 145);
                //pb.Size = new Size(200, 145);
                //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                //pb.Show();
                //this.Controls.Add(pb);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
