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
    public partial class SkladFurnitura : Form
    {
        public SkladFurnitura()
        {
            InitializeComponent();
        }

        private void SkladFurnitura_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Склад_фурнитуры". При необходимости она может быть перемещена или удалена.
            this.склад_фурнитурыTableAdapter.Fill(this.demoExDataSet1.Склад_фурнитуры);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();складФурнитурыBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet1);
        }
    }
}
