//using DemoLibrary;
using BI;
using DA;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            users u = new users();
            if (u.login(textBox1.Text, textBox2.Text.Trim()) == true)
            {
                u.permission(textBox1.Text);
                this.Visible = false;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Login!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}