using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.Prikreplenie
{
    public partial class DeletePrik : Form
    {
        public DeletePrik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metveshinomera metclient = new Mapping.Metveshinomera();
                metclient.Delete(Program.Pole.id);
                this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
