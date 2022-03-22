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
    public partial class Provider : Form
    {
        public Form ReturnForm;
        public Provider()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Provider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.dataSet1.Provider);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            providerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            providerBindingSource.EndEdit();
            providerTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            providerBindingSource.RemoveCurrent();
        }
    }
}
