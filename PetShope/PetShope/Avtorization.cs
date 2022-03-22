using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Avtorization : Form
    {
        bool flag = false;
        public Avtorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nick = textBox1.Text;
            string pass = textBox2.Text;
            string myConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=Зоомагазин; Integrated Security=True";
            string mySelectQuery = "SELECT [login] FROM [Зоомагазин] WHERE [login] = '" + nick + "'and [password]='" + pass + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
            {

                DataTable table = new DataTable();
                //dataAdapter.Fill(table);
                if (table.Rows.Count == 0) //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    MessageBox.Show("have");
                    flag = true;
                }
                else
                {
                    MessageBox.Show("have't");
                }
            }
            if(flag == true)
            {
                this.Hide();
                new Form1() { ReturnForm = this }.Show();
            }

        }
    }
}
