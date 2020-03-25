using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelime_Değiştir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = richTextBox1.Text.Replace(textBox1.Text, textBox2.Text);
                richTextBox2.Text = richTextBox1.Text;
                button4.Enabled = true;
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.White;
            }
            catch (Exception)
            {

                MessageBox.Show("Doldurmanız gereken yerleri tekrar kontrol ediniz");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox2.BackColor = Color.Yellow;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            pictureBox2.BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text!="")
            {
                Clipboard.SetText(richTextBox2.Text);
                pictureBox1.BackColor = Color.White;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }
    }
}
