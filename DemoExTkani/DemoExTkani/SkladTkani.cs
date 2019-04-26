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
    public partial class SkladTkani : Form
    {
        public SkladTkani()
        {
            InitializeComponent();
        }

        private void SkladTkani_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet11.Склад_ткани". При необходимости она может быть перемещена или удалена.
            this.склад_тканиTableAdapter.Fill(this.demoExDataSet11.Склад_ткани);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складТканиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet11);
        }
    }
}
