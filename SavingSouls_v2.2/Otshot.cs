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
    public partial class Otshot : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog = SavingSouls_DB; Persist Security Info=True;User ID = pro-41; Password=pro_41student";


        public Otshot()
        {
            InitializeComponent();
        }

        void LoadBD()
        {
            string connectionString = (conStr);
            string sql = "SELECT * FROM [Отчёт о выездах]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }
        }

        private void Otshot_Load(object sender, EventArgs e)
        {
            LoadBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Enter newEnter = new Enter();
            newEnter.Show();
        }
    }
}
