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
    public partial class InfGroup : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog = SavingSouls_DB; Persist Security Info=True;User ID = pro-41; Password=pro_41student";
        public InfGroup()
        {
            InitializeComponent();
        }
        void Loading(string sql) //Способ загрузки таблиц
        {
            string connectionString = (conStr);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfGroup_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 250);
            Loading("SELECT * FROM[Состав оперативных групп]");
            this.dataGridView1.Columns["id"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM [Состав оперативных групп] ORDER BY [ФИО]");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM [Состав оперативных групп] ORDER BY [Стаж]");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM [Состав оперативных групп] ORDER BY [Позывной группы]");
        }
    }
}
