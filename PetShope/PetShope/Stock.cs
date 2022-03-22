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
    public partial class Stock : Form
    {
        public Form ReturnForm;
        public Stock()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.dataSet1.Stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stockBindingSource.EndEdit();
            stockTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
        }
    }
}
