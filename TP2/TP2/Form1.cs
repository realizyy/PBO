    using System;
using System.Drawing;
    using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //title window
            this.Text = "TP2";
            //ukuran & letak window
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(480, 240);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Menampilkan Inputan nama ke Label setelah tombol submit di tekan.
            this.label1.Text = "Halo " + this.textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //meminta input dari textbox1
            string input = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}