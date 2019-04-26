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
    public partial class FurnituraIzd : Form
    {
        public FurnituraIzd()
        {
            InitializeComponent();
        }

        private void FurnituraIzd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Фурнитура_изделия". При необходимости она может быть перемещена или удалена.
            this.фурнитура_изделияTableAdapter.Fill(this.demoExDataSet1.Фурнитура_изделия);

        }
    }
}
