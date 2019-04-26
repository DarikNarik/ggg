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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.demoExDataSet1.Заказ);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet1);
        }
    }
}
