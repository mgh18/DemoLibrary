using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA;
using BI;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            users u = new users();
            DataTable dt = u.Select();
            dataGridView1.DataSource = dt;
            comboBox1.Text = "Choose...";
            comboBox3.Text = "Choose...";
            comboBox2.Text = "Choose...";
            comboBox4.Text = "Choose...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users u = new users();
            u.id = int.Parse(textBox3.Text);
            u.username = textBox1.Text;
            u.pas = textBox2.Text;
            u.p1 = Convert.ToBoolean(comboBox1.Text);
            u.p2 = Convert.ToBoolean(comboBox2.Text);
            u.p3 = Convert.ToBoolean(comboBox3.Text);
            u.p4 = Convert.ToBoolean(comboBox4.Text);
            u.insert();
            Form3_Load(null, null);
        }
    }
}
