using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Data.SqlClient;


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

            listView1.AllowDrop = true; //dragam fisierul produse.txt peste listView1
            listView1.DragEnter += ListView1_DragEnter;
            listView1.DragDrop += ListView1_DragDrop;
            /*lstProdus.AddRange(new List<Produs>() { //le-am adaugat mai jos printr-un buton
                new Produs("Anvelope", 230, new DateTime(2024, 1, 1)),
                new Produs("Baterii", 150, new DateTime(2024, 12, 31)),
                new Produs("Medicamente", 50, new DateTime(2023, 10, 5)),
                new Produs("Laptopuri", 75, new DateTime(2024, 9, 1)),
                new Produs("Telefoane", 200, new DateTime(2024, 11, 15)),
                new Produs("Monitoare", 90, new DateTime(2024, 8, 20)),
                new Produs("Televizoare", 45, new DateTime(2024, 7, 30)),
                new Produs("Camere foto", 85, new DateTime(2024, 6, 2)),
                new Produs("Frigidere", 90, new DateTime(2023, 8, 10)),
                new Produs("Canapele", 70, new DateTime(2023, 11, 12)),
            });*/
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

                    tbMes.Text += "\r\n Forma s-a inchis cu OK.";
                }
                else
                {
                    tbMes.Text += "\r\n Forma s-a inchis cu Cancel.";
                }

            }
            else
            {
                tbMes.Text = "\r\nNu ati selectat niciun produs. Va rugam selectati un produs pentru a-l actualiza.";
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
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
            else
            {
                tbMes.Text = "\r\nNu ati selectat niciun produs. Va rugam selectati un produs pentru a-l sterge.";
            }
        }
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                updateToolStripMenuItem_Click(sender, e);
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                btnProdus_Click_Click(sender, e);
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
                insertToolStripMenuItem_Click(sender, e);

        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
                graficToolStripMenuItem_Click(sender, e);

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
                tbMes.Text += $"\r\n Au fost citite {lstProdus.Count} produse din fisier.";
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
            tbMes.Text += $"\r\n Au fost salvate {lstProdus.Count} produse in fisier.";

        }
        private void btnProdus_Click_1(object sender, EventArgs e)
        { // doar pt afisare, nu merge delete, update, insert daca vreau sa le salvez in fisier dupa, tot 10 imi saleaza
            Produs produs1 = new Produs("Anvelope", 230, new DateTime(2024, 1, 1));
            Produs produs2 = new Produs("Baterii", 150, new DateTime(2024, 3, 31));
            Produs produs3 = new Produs("Medicamente", 50, new DateTime(2023, 10, 5));
            Produs produs4 = new Produs("Laptopuri", 75, new DateTime(2024, 9, 1));
            Produs produs5 = new Produs("Telefoane", 200, new DateTime(2024, 11, 15));
            Produs produs6 = new Produs("Monitoare", 90, new DateTime(2024, 8, 20));
            Produs produs7 = new Produs("Televizoare", 45, new DateTime(2024, 7, 30));
            Produs produs8 = new Produs("Camere foto", 85, new DateTime(2024, 6, 2));
            Produs produs9 = new Produs("Frigidere", 90, new DateTime(2023, 8, 10));
            Produs produs10 = new Produs("Canapele", 70, new DateTime(2023, 11, 12));

            lstProdus.AddRange(new List<Produs>() {
                produs1, produs2, produs3, produs4, produs5, produs6,
                produs7, produs8, produs9, produs10
            });

            foreach (Produs produs in lstProdus)
            {
                ListViewItem itm = new ListViewItem(new string[] { produs.Nume, produs.LotFabricatie.ToString(), produs.FisaConsum.ToShortDateString() });
                listView1.Items.Add(itm);
            }
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
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previewToolStripMenuItem.PerformClick();
        }
        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lotF = lstProdus.Select(prod => prod.LotFabricatie).Distinct().ToList();
            Form3 form3 = new Form3();
            form3.lot = lotF;
            form3.Show();
        }
        private void ListView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void ListView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".txt")
                    {
                        string[] lines = File.ReadAllLines(file);
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 3)
                            {
                                string numeProdus = parts[0].Trim();
                                int lotFabricatie;
                                DateTime fisaConsum;
                                if (int.TryParse(parts[1].Trim(), out lotFabricatie) &&
                                    DateTime.TryParse(parts[2].Trim(), out fisaConsum))
                                {
                                    bool exists = false;
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.Text == numeProdus &&
                                            item.SubItems[1].Text == lotFabricatie.ToString() &&
                                            item.SubItems[2].Text == fisaConsum.ToShortDateString())
                                        {
                                            exists = true;
                                            break;
                                        }
                                    }
                                    if (!exists)
                                    {
                                        Produs produs = new Produs(numeProdus, lotFabricatie, fisaConsum);
                                        lstProdus.Add(produs);
                                        ListViewItem itm = new ListViewItem(numeProdus);
                                        itm.SubItems.Add(lotFabricatie.ToString());
                                        itm.SubItems.Add(fisaConsum.ToShortDateString());
                                        listView1.Items.Add(itm);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(lstProdus); 
            form4.ShowDialog();
        }
        private void frameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new dbProductieEntities())
            {
                foreach (var row in context.tblProdus)
                {
                    tbMes.Text += $" \r\n{row.numeProdus} \t {row.lotFabricatie} \t {row.fisaConsum}";
                    if (row.lotFabricatie <= 200) row.lotFabricatie += 10;
                }
                context.SaveChanges();
            }
        }
        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strComanda = "SELECT * FROM tblProdus";
            SqlConnection myCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dbProductie;Integrated Security=True");
            myCon.Open();
            SqlCommand myCmd = new SqlCommand(strComanda, myCon);
            SqlDataReader myRdr = null;
            myRdr = myCmd.ExecuteReader();
            tbMes.Clear();
            while (myRdr.Read())
            {
                tbMes.Text += $" \r\n{myRdr["numeProdus"]} \t {myRdr["lotFabricatie"]} \t {myRdr["fisaConsum"]}";
            }
            myRdr.Close();
            myCon.Close();
        }
    }
}
