using System;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Page_Generator
{
    public partial class Form2 : Form
    {

        public string path = "";

        public Form2(string gt)
        {
            InitializeComponent();
            path = gt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<b>" + richTextBox1.SelectedText + "</b>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<i>" + richTextBox1.SelectedText + "</i>";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<u>" + richTextBox1.SelectedText + "</u>";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<s>" + richTextBox1.SelectedText + "</s>";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<sup>" + richTextBox1.SelectedText + "</sup>";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<sub>" + richTextBox1.SelectedText + "</sub>";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<img src="+'"'+ Interaction.InputBox("Insert link to image", "Image") + '"'+">");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<a href=" + '"' + Interaction.InputBox("Insert URL", "URL") + '"' + ">" + Interaction.InputBox("Insert name", "URL") + "</a>");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<a href=" + '"' + "mailto:" + Interaction.InputBox("Paste E-Mail address", "E-Mail") + '"' + ">" + Interaction.InputBox("Name", "E-Mail") + "</a>");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<q>" + richTextBox1.SelectedText + "</q>";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 help = new Form3();
            help.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(path);

            text = text.Replace("$TITLE$", textBox1.Text);
            text = text.Replace("$TEXT$", richTextBox1.Text);

            File.WriteAllText("new_page.html",text);
            MessageBox.Show("Successful!");
        }

        void SaveTMP()
        {
            string name = textBox1.Text.Replace(" ", "_");

            if (File.Exists(name+"tmp.html"))
                File.Delete(name + "tmp.html");

            File.WriteAllText(name + "tmp.html", richTextBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveTMP();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<"+ comboBox1.SelectedItem +">" + richTextBox1.SelectedText + "</"+ comboBox1.SelectedItem + ">";
        }
    }
}
