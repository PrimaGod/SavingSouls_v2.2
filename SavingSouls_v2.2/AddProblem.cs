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

namespace SavingSouls_v2._2
{
    public partial class AddProblem : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog = SavingSouls_DB; Persist Security Info=True;User ID = pro-41; Password=pro_41student";
        public AddProblem()
        {
            InitializeComponent();
            this.Location = new Point(300, 250);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = (conStr);
            string sqlExpression = "INSERT INTO Происшествия ( Описание, Приоритет, Дата, Время,[Группа на выезд]) VALUES ('" + tb_OpisProblem.Text + "','" +cmB_Prioritet.Text + "','" + dateProis.Value + "','" + TimeProblem.Value + "','" + cmB_Group.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                this.Close();
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
