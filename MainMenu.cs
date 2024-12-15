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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // exite the application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show the form1
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show the form3
            RandomPlayer f3 = new RandomPlayer();
            f3.Show();
            this.Hide();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
