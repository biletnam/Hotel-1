using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.Reserv
{
    public partial class DeleteReserv : Form
    {
        public DeleteReserv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metrezerv metclient = new Mapping.Metrezerv();
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
