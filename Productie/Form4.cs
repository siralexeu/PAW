using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productie
{
    public partial class Form4 : Form
    {
        private List<Produs> lstProdus;
        public Form4(List<Produs> produse)
        {
            InitializeComponent();
            lstProdus = produse;
            dataGridView1.DataSource = new BindingList<Produs>(lstProdus);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProductieDataSet.tblProdus' table. You can move, or remove it, as needed.
            this.tblProdusTableAdapter.Fill(this.dbProductieDataSet.tblProdus);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tblProdusTableAdapter.Update(this.dbProductieDataSet.tblProdus);
        }
    }
}
