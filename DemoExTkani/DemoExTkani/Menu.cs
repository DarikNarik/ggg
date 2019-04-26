using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExTkani
{
    public partial class Menu : Form
    {
        public Menu(string who) 
        {
            InitializeComponent();
            Userrr = who; 
        }
        string Userrr;

      
        private void тканиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Tkani = new Tkani();
            Tkani.MdiParent = this;
            Tkani.Show();
        }

        private void ТканиИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TkaniIzd = new TkaniIzd();
            TkaniIzd.MdiParent = this;
            TkaniIzd.Show();
        }

        private void складТканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SkladTkani = new SkladTkani();
            SkladTkani.MdiParent = this;
            SkladTkani.Show();
        }

        private void фурнитураToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Furnitura = new Furnitura();
            Furnitura.MdiParent = this;
            Furnitura.Show();
        }

        private void фурнитураИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FurnituraIzd = new FurnituraIzd();
            FurnituraIzd.MdiParent = this;
            FurnituraIzd.Show();
        }

        private void складФурнитурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SkladFurnitura = new SkladFurnitura();
            SkladFurnitura.MdiParent = this;
            SkladFurnitura.Show();
        }

        private void изделияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Izdelia = new Izdelia();
            Izdelia.MdiParent = this;
            Izdelia.Show();
        }

        private void заказныеИзделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ZakazIzd = new ZakazIzd();
            ZakazIzd.MdiParent = this;
            ZakazIzd.Show();
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Zakaz = new Zakaz();
            Zakaz.MdiParent = this;
            Zakaz.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Auth = new Log(Userrr);
            Auth.Show();        
        }
    }
}
