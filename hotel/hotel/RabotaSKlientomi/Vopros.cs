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
    public partial class Vopros : Form
    {
        public Vopros()
        {
            InitializeComponent();
        }
        Mapping.DBjurnalnomera dbjn = new Mapping.DBjurnalnomera(hotel.Program.Pole.pole);
        Mapping.DBjurnaldopuslug dbjdu = new Mapping.DBjurnaldopuslug(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            Mapping.Metjurnalnomera metjn = new Mapping.Metjurnalnomera();
            Mapping.Metnomera metn= new Mapping.Metnomera();
            Mapping.Metjurnaldopuslug metdu = new Mapping.Metjurnaldopuslug();
            RabotaSKlientomi.SchetPdf schet = new RabotaSKlientomi.SchetPdf();
            saveFileDialog1.Filter = "PDF Document|*.pdf";
            saveFileDialog1.ShowDialog();
            schet.CozdSchetPdf(saveFileDialog1.FileName,hotel.Program.Pole.id);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mapping.Metjurnalnomera metjn = new Mapping.Metjurnalnomera();
            Mapping.Metnomera metn = new Mapping.Metnomera();
            Mapping.Metjurnaldopuslug metdu = new Mapping.Metjurnaldopuslug();
            RabotaSKlientomi.SchetPdf schet = new RabotaSKlientomi.SchetPdf();
            saveFileDialog1.Filter = "PDF Document|*.pdf";
            saveFileDialog1.ShowDialog();
            schet.CozdSchetPdf2(saveFileDialog1.FileName, hotel.Program.Pole.id);
            this.Close();
        }
    }
}
