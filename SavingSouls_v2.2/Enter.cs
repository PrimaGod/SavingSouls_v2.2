using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingSouls_v2._2
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            Operator newOperator = new Operator();
            newOperator.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group newGroup = new Group();
            newGroup.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Otshot newOtshot = new Otshot();
            newOtshot.Show();
            this.Visible = false;
        }
    }
}
