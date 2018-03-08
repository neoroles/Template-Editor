using System;
using System.Windows.Forms;

namespace Page_Generator
{
    public partial class Form3 : Form
    {
        public int page = 1;

        public Form3()
        {
            InitializeComponent();
        }

        void ChangeImage(string op)
        {
            if (op == "-") {
                if (page > 1)
                {
                    page -= 1;
                }
            } else {
                if (page < 3)
                {
                    page += 1;
                }
            }

            if (page == 1) {
                button11.Visible = false;
                pictureBox1.Image = Properties.Resources._1;
            }

            if (page > 1)
                button11.Visible = true;

            if (page == 3) { 
                pictureBox1.Image = Properties.Resources._3;
                button1.Visible = false;
            }

            if (page < 3)
                button1.Visible = true;

            if (page == 2)
                pictureBox1.Image = Properties.Resources._2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage("+");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangeImage("-");
        }
    }
}
