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
    public partial class Tkani : Form
    {
        public Tkani()
        {
            InitializeComponent();
        }

        private void Tkani_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoExDataSet1.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.demoExDataSet1.Ткани);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = e.ColumnIndex.ToString();
            if (index == "5")
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                pictureBox1.Image = Image.FromFile(name);
            }
        }

        private void сохранитьToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.тканиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.demoExDataSet1);
        }
    }
}
