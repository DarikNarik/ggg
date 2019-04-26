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
    public partial class ZakazIzd : Form
    {
        public ZakazIzd()
        {
            InitializeComponent();
        }

        private void ZakazIzd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Заказанные_изделия". При необходимости она может быть перемещена или удалена.
            this.заказанные_изделияTableAdapter.Fill(this.demoExDataSet1.Заказанные_изделия);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказанныеИзделияBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet1);
        }
    }
}
