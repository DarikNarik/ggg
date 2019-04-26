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
    public partial class Log : Form
    {
        public Log(string who)
        {
            InitializeComponent();
            Userrr = who;
        }
        string Userrr;
        string errror;

        private void Log_Load(object sender, EventArgs e)
        {
            if (Userrr == "Заказчик")
            {
                button3.Visible = true;
                errror = "Введен неверный логин или пароль. Попробуйте ввести данные заново или зарегестрируйтесь";
            }
            else
            {
                button3.Visible = false;
                errror = "Введен неверный логин или пароль. Попробуйте ввести данные заново";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms["Auth"];
            ifrm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=DESKTOP-GGQU1NN;Initial Catalog=DemoEx;Integrated Security=True";
                connection.Open();
                SqlCommand con = new SqlCommand("Select * from Пользователь", connection);
                con.CommandText = "Select * from Пользователь where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'";
                SqlDataReader reader = con.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string a = reader["Роль"].ToString();
                        if ((a == "Менеджер") && (Userrr == "Менеджер"))
                        {
                            Form Menu = new Menu(Userrr);
                            Menu.Show();
                            this.Close();
                        }
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else 
                {
                    MessageBox.Show(errror);
                    textBox2.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Reg = new Reg();
            Reg.Show();
            this.Close();
        }
    }
}
