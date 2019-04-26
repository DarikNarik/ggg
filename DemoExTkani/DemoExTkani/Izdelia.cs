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
    public partial class Izdelia : Form
    {
        public Izdelia()
        {
            InitializeComponent();
        }

        private void Izdelia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Изделия". При необходимости она может быть перемещена или удалена.
            this.изделияTableAdapter.Fill(this.demoExDataSet1.Изделия);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изделияBindingSource.EndEdit();
        }
    }
}
