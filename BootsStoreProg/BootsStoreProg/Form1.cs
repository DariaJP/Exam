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

namespace BootsStoreProg
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-COOVE4V\SQLEXPRESS;Initial Catalog=BootsStore; Integrated Security=True;");
            con.Open();

            try
            {
                string com = ("SELECT * FROM users WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand check = new SqlCommand(com, con);
                
                if (check.ExecuteScalar() != null)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Введены неправильные данные");
                }
            }
            finally { }
        }
    }
}
