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
    public partial class TkaniIzd : Form
    {
        public TkaniIzd()
        {
            InitializeComponent();
        }

        private void TkaniIzd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Ткани_изделия". При необходимости она может быть перемещена или удалена.
            this.ткани_изделияTableAdapter.Fill(this.demoExDataSet1.Ткани_изделия);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тканиИзделияBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet1);
        }
    }
}
