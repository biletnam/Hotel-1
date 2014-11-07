using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.nomera
{
    public partial class DeleteNomera : Form
    {
        public DeleteNomera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                Mapping.Metnomera metclient = new Mapping.Metnomera();
                metclient.Delete(Program.Pole.id);
                this.Close();
            }
            //catch { MessageBox.Show("Error"); }
        }
    }
}
