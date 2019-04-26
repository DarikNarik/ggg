using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoExTkani
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        string Userrr;

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new HashSet<char>() { '!', '@', '#', '$', '%', '^'};
            try
            {
                Boolean a = false;
                Boolean b = false;
                Boolean c = false;
                if (textBox2.Text.Length >=6)
                {
                    for (int i = 0; i <textBox2.Text.Length; i++)
                    {
                        char y = textBox2.Text[i];
                        char n = textBox2.Text[i];
                        if (char.IsDigit(n))
                        {
                            a = true;
                        }
                        if (char.IsLower(n))
                        {
                            b = true;
                        }
                        if (x.Contains(y))
                        {
                            c = true;
                        }
                    }
                }
                if ((a == true) && (b == true) && (c == true) && (textBox1.Text != ""))
                {
                    Userrr = "";
                    using (SqlConnection connection = new SqlConnection())
                    {
                        connection.ConnectionString = @"Data Source=DESKTOP-GGQU1NN;Initial Catalog=DemoEx;Integrated Security=True";
                        connection.Open();
                        SqlCommand con = new SqlCommand("Insert into Пользователь(Логин,Пароль,Роль) values (@login,@password,'Заказчик')", connection);
                        con.Parameters.AddWithValue("@login", textBox1.Text);
                        con.Parameters.AddWithValue("@password", textBox2.Text);
                        con.ExecuteNonQuery();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неподходящий пароль или такой пользователь уже зарегестрирован.");
                }
            }
            catch
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Userrr = "Заказчик";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form login = new Log(Userrr);
            login.Show();
        }
    }
}
