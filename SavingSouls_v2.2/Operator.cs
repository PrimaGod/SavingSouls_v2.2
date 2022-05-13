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
    public partial class Operator : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog = SavingSouls_DB; Persist Security Info=True;User ID = pro-41; Password=pro_41student";

        public Operator()
        {
            InitializeComponent();
        }

        void o()
        {
            string connectionString = (conStr);
            string sql = "SELECT * FROM Происшествия";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                

            }
        }

        private void Operator_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 250);
            o();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProblem newAddProblem = new AddProblem();
            newAddProblem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o();
        }
    }
}
