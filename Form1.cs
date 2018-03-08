using System;
using System.Windows.Forms;

namespace Page_Generator
{
    public partial class Form1 : Form
    {

        public string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("Path - empty!");
            } else { 
                this.Hide();
                Form2 frm2 = new Form2(path);
                frm2.ShowDialog();
                this.Close();
            }
        }
    }
}
