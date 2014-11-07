using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.Settings
{
    public partial class Stroka : Form
    {
        public Stroka()
        {
            InitializeComponent();
        }

        private void Stroka_Load(object sender, EventArgs e)
        {
            textBox1.Text = hotel.Program.Pole.pole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(Application.StartupPath.ToString() + "\\settings\\DataSource.txt");
                writer.WriteLine(textBox1.Text);
                writer.Close();
                hotel.Program.Pole.pole = textBox1.Text;
                this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
