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
    public partial class ADDSpisokVeshei : Form
    {
        public ADDSpisokVeshei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleSpisokVeshei vc = new VisibleSpisokVeshei();
                Mapping.Metveshi d = new Mapping.Metveshi();
                d.ADD(textBox1.Text.ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
    }
}
