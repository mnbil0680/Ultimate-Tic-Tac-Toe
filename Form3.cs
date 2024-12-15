using problem8.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void ImageChange(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                if (label1.Text == "Player X")
                {
                    Image img = Resources.X_letter_8;
                    img = new Bitmap(img, new Size(btn.Width - 10, btn.Height - 10));
                    btn.Image = img;
                    btn.Tag = "X";
                    //Handle();
                    label1.Text = "Player O";
                    label1.Tag = "O";


                }
                else
                {
                    Image img = Resources.O_letter_8;
                    img = new Bitmap(img, new Size(btn.Width - 10, btn.Height - 10));
                    btn.Image = img;
                    btn.Tag = "O";
                    //Handle();
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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
