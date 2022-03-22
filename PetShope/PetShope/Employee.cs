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
    public partial class Employee : Form
    {
        public Form ReturnForm;
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            employeeTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeeBindingSource.RemoveCurrent();
        }
    }
}
