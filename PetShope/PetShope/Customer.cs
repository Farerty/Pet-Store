using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Customer : Form
    {
        public Form ReturnForm;
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            customerTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerBindingSource.RemoveCurrent();
        }
    }
}
