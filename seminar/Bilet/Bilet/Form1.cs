using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bilet
{
    public partial class Form1 : Form
    {
        List<Bilet> lstBilete = new List<Bilet>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Bilet b1 = new Bilet(DateTime.Now, "Ploiesti","Buzau", 200);
            tbMes.Text += "\r\n " + b1 + " eficienta: "+b1.pretPerKm();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            DialogResult r = m.ShowDialog();
            if (r == DialogResult.OK)
            {
                string Id = m.tbId.Text;
                DateTime dataCursei = DateTime.Parse(m.tbData.Text);
                string statiePlecare = m.tbPlecare.Text;
                string destinatie = m.tbSosire.Text;
                double pret = double.Parse(m.tbPret.Text);

                Bilet nou = new Bilet(dataCursei, statiePlecare, destinatie, pret);
                lstBilete.Add(nou);

                ListViewItem itm = new ListViewItem(Id);
                itm.SubItems.Add(dataCursei.ToShortDateString());
                itm.SubItems.Add(statiePlecare.ToString());
                itm.SubItems.Add(destinatie.ToString());
                itm.SubItems.Add(pret.ToString());
                listView1.Items.Add(itm);

                tbMes.Text += "Preia datele din macheta";
            }
            else
            {
                tbMes.Text += " Nu preia datele din macheta";
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem itm = listView1.SelectedItems[0];
                int poz = itm.Index;

                Form2 m = new Form2();
                DialogResult r;
               
                m.tbId.Text = itm.Text;
                m.tbData.Text = itm.SubItems[1].Text;
                m.tbPlecare.Text = itm.SubItems[2].Text;
                m.tbSosire.Text = itm.SubItems[3].Text;
                m.tbPret.Text = itm.SubItems[4].Text;

                r = m.ShowDialog();
                if (r==DialogResult.OK)
                {
                    itm.SubItems[0].Text = m.tbId.Text;
                    itm.SubItems[1].Text = m.tbData.Text;
                    itm.SubItems[2].Text = m.tbPlecare.Text;
                    itm.SubItems[3].Text = m.tbSosire.Text;
                    itm.SubItems[4].Text = m.tbPret.Text;
                    Bilet b1 = lstBilete[poz];

                    b1.Id = m.tbId.Text;
                    b1.dataCursei = DateTime.Parse(m.tbData.Text);
                    b1.statiePlecare = m.tbPlecare.Text;
                    b1.destinatie = m.tbSosire.Text;
                    b1.pret = double.Parse(m.tbPret.Text);
                    lstBilete.Add(b1);
                }
            }
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updateToolStripMenuItem.PerformClick();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                int poz = itm.Index;
                listView1.Items.RemoveAt(poz);
                listView1.Refresh();
                lstBilete.Remove(lstBilete[poz]);

            }
        }     

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fis = new FileStream("bilete.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            lstBilete = (List<Bilet>)bf.Deserialize(fis);
            fis.Close();
            listView1.Items.Clear();
            foreach (Bilet crt in lstBilete)
            {
                ListViewItem itm = new ListViewItem(crt.Id.ToString());
                itm.SubItems.Add(crt.dataCursei.ToShortDateString());
                itm.SubItems.Add(crt.statiePlecare.ToString());
                itm.SubItems.Add(crt.destinatie.ToString());
                itm.SubItems.Add(crt.pret.ToString());
                listView1.Items.Add(itm);
            }
            tbMes.Text += $"\r\nAu fost citite {lstBilete.Count} inregistrari";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fis = new FileStream("bilete.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fis, lstBilete);
            fis.Close();
            tbMes.Text += $"\r\nAu fost salvate {lstBilete.Count} inregistrari";
        }

        
    }
}
