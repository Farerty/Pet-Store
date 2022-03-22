﻿using System;
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
    public partial class Provider_Purchase : Form
    {
        public Form ReturnForm;
        public Provider_Purchase()
        {
            InitializeComponent();
        }

        private void provider_PurchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provider_PurchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Provider_Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Provider_Purchase". При необходимости она может быть перемещена или удалена.
            this.provider_PurchaseTableAdapter.Fill(this.dataSet1.Provider_Purchase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            provider_PurchaseBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provider_PurchaseBindingSource.EndEdit();
            provider_PurchaseTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            provider_PurchaseBindingSource.RemoveCurrent();
        }
    }
}
