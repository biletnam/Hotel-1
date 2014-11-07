using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.RabotaSKlientomi
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.pass = textBox1.Text.ToString();
            this.Close();
        }
    }
}
