using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.dopuslugi
{
    public partial class DeleteDopUslugi : Form
    {
        public DeleteDopUslugi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metdopuslugi metclient = new Mapping.Metdopuslugi();
                metclient.Delete(Program.Pole.id);
                this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
