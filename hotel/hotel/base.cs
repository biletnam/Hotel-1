using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        RabotaSFailami rsf = new RabotaSFailami();
        public Form1()
        {
            InitializeComponent();
            hotel.Program.Pole.pole = rsf.outFile(Application.StartupPath.ToString() + "\\settings\\DataSource.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuClient_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.clients.VisibleClient visibleclient = new vnesenieinfBD.clients.VisibleClient();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuHelp_Click(object sender, EventArgs e)
        {
            Oprogram oprogram = new Oprogram();
            oprogram.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.dopuslugi.VisibleDopUslugi visibleclient = new vnesenieinfBD.dopuslugi.VisibleDopUslugi();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuNomera_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.nomera.VisibleNomer visibleclient = new vnesenieinfBD.nomera.VisibleNomer();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuVeshi_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.veshi.SpisokVeshi.VisibleSpisokVeshei visibleclient = new vnesenieinfBD.veshi.SpisokVeshi.VisibleSpisokVeshei();
            visibleclient.ShowDialog();
        }

        private void toolStripMenurezerv_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.veshi.Reserv.VisibleReserv visibleclient = new vnesenieinfBD.veshi.Reserv.VisibleReserv();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuVeshinomer_Click(object sender, EventArgs e)
        {
            vnesenieinfBD.veshi.Prikreplenie.VisiblePrikreplenie visibleclient = new vnesenieinfBD.veshi.Prikreplenie.VisiblePrikreplenie();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuFirma_Click(object sender, EventArgs e)
        {
            Settings.Firma visibleclient = new Settings.Firma();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuBron_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.bron visibleclient = new RabotaSKlientomi.bron();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuZakaz_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.OformlenieVNomer visibleclient = new RabotaSKlientomi.OformlenieVNomer();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.DopUslugi visibleclient = new RabotaSKlientomi.DopUslugi();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.Viezd visibleclient = new RabotaSKlientomi.Viezd();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuStrokaBD_Click(object sender, EventArgs e)
        {
            Settings.Stroka visibleclient = new Settings.Stroka();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RabotaOtel.Porcha visibleclient = new RabotaOtel.Porcha ();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            RabotaOtel.Popolnenie visibleclient = new RabotaOtel.Popolnenie();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Otchet.Otchet visibleclient = new Otchet.Otchet();
            visibleclient.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.KlientBank v2 = new RabotaSKlientomi.KlientBank();
            v2.ShowDialog();
        }
    }
}
