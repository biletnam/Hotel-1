using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.SpisokVeshi
{
    public partial class DeleteSpisokVeshei : Form
    {
        public DeleteSpisokVeshei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metveshi metclient = new Mapping.Metveshi();
                metclient.Delete(Program.Pole.id);
                this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
