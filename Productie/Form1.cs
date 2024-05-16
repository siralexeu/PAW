using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace Productie
{

    public partial class Form1 : Form
    {
        Produs p1 = new Produs(); // Definirea obiectului p1 de tip Produs
        List<Produs> lstProdus = new List<Produs>(); // Inițializarea listei de produse
        Control[] vectControl;
        

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);

            lstProdus = new List<Produs>() {
                new Produs("Anvelope", 230, new DateTime(2025, 1, 1)),
                new Produs("Baterii", 150, new DateTime(2024, 12, 31)),
                new Produs("Medicamente", 50, new DateTime(2023, 10, 5)),
                new Produs("Laptopuri", 75, new DateTime(2024, 9, 1)),
                new Produs("Telefoane", 200, new DateTime(2024, 11, 15)),
                new Produs("Monitoare", 90, new DateTime(2024, 8, 20)),
                new Produs("Tastaturi", 120, new DateTime(2025, 2, 10)),
                new Produs("Tablete", 45, new DateTime(2024, 7, 30)),
                new Produs("Imprimante", 60, new DateTime(2025, 3, 5)),
                new Produs("Scannere", 40, new DateTime(2024, 4, 18)),
                new Produs("Camere foto", 85, new DateTime(2024, 6, 2)),
                new Produs("Placi video", 20, new DateTime(2024, 10, 15))
            };
        }
        private void btnProdus_Click_Click(object sender, EventArgs e)
        {
            tbMes.Text += "\r\n " + p1;
            p1 = new Produs("Laptop", 14, DateTime.Now);
            tbMes.Text += "\r\n " + p1;

            p1.LotFabricatie = 15;
            p1.FisaConsum = DateTime.Parse("17.03.2024");

            Produs p2 = new Produs(p1);
            tbMes.Text += "\r\n " + p2;

            p2.LotFabricatie = 20;
            p2.FisaConsum = DateTime.Parse("20.03.2024");

            tbMes.Text += "\r\n " + p2;
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 macheta = new Form2();
            DialogResult r;
            r = macheta.ShowDialog();
            if (r == DialogResult.OK)
            {
                string numeProdus = macheta.tbProdus.Text;
                int lotFabricatie = int.Parse(macheta.tbLot.Text);
                DateTime fisaConsum = DateTime.Parse(macheta.tbFisa.Text);

                Produs produsNou = new Produs(numeProdus, lotFabricatie, fisaConsum);

                lstProdus.Add(produsNou);

                ListViewItem itm = new ListViewItem(numeProdus);
                itm.SubItems.Add(lotFabricatie.ToString());
                itm.SubItems.Add(fisaConsum.ToShortDateString());
                listView1.Items.Add(itm);

                tbMes.Text += "\r\n Forma s-a inchis cu OK.";
            }
            else
            {
                tbMes.Text += "\r\n Forma s-a inchis cu Cancel.";
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                int pozitie = itm.Index;
                Form2 macheta = new Form2();
                DialogResult r;

                macheta.tbProdus.Text = itm.Text;
                macheta.tbLot.Text = itm.SubItems[1].Text;
                macheta.tbFisa.Text = itm.SubItems[2].Text;

                r = macheta.ShowDialog();
                if (r == DialogResult.OK)
                {
                    itm.Text = macheta.tbProdus.Text;
                    itm.SubItems[1].Text = macheta.tbLot.Text;
                    itm.SubItems[2].Text = macheta.tbFisa.Text;

                    Produs produsSelectat = lstProdus[pozitie];
                    produsSelectat.Nume = macheta.tbProdus.Text;
                    produsSelectat.LotFabricatie = int.Parse(macheta.tbLot.Text);
                    produsSelectat.FisaConsum = DateTime.Parse(macheta.tbFisa.Text);
                }
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);

                int index = item.Index;
                if (index >= 0 && index < lstProdus.Count)
                {
                    lstProdus.RemoveAt(index);
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnProdus_Click_Click(sender, e);
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
                exitToolStripMenuItem1_Click(sender, e);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "produs.dat";

            if (File.Exists(fileName))
            {
                FileStream fisProd = new FileStream("produs.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                lstProdus = (List<Produs>)bf.Deserialize(fisProd);
                fisProd.Close();

                listView1.Items.Clear();

                foreach (Produs prod in lstProdus)
                {
                    ListViewItem itm = new ListViewItem(prod.Nume.ToString());
                    //itm.SubItems.Add(prod.Nume);
                    itm.SubItems.Add(prod.LotFabricatie.ToString());
                    itm.SubItems.Add(prod.FisaConsum.ToShortDateString());
                    listView1.Items.Add(itm);
                }
                tbMes.Text += $"\r\n Au fost citite {lstProdus.Count} produse";
            }
            else
            {
                MessageBox.Show("Fisierul 'produs.dat' nu există.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisProd = new FileStream("produs.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisProd, lstProdus);
            fisProd.Close();
            tbMes.Text += $"\r\n Au fost salvate {lstProdus.Count} produse";

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pos = 10;
            Graphics g = e.Graphics; 
            foreach (Produs prod in lstProdus)
            {
                string line = $"Produs: {prod.Nume}, Lot: {prod.LotFabricatie}, Data Consum: {prod.FisaConsum.ToShortDateString()}";
                g.DrawString(line, new Font("Calibri", 12), Brushes.DarkBlue, new PointF(100, pos)); 
                pos += 20;
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printDocument1.Print();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lot = new Dictionary<int, int>();
            foreach (Produs prod in lstProdus)
            {
                if (!lot.ContainsKey(prod.LotFabricatie))
                    lot[prod.LotFabricatie] = 0;
                lot[prod.LotFabricatie] += 1;  // Sumați 1 pentru fiecare produs în lot, sau adăugați mărimea lotului dacă este disponibilă
            }


            Form3 grafic = new Form3(lot);
            grafic.ShowDialog();
        }
    }
}
