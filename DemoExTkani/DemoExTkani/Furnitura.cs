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
    public partial class Furnitura : Form
    {
        public Furnitura()
        {
            InitializeComponent();
        }

        private void Furnitura_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.demoExDataSet1.Фурнитура);

        }
    }
}
