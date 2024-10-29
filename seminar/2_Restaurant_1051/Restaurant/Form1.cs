using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant {
    public partial class Form1 : Form {
        List<Preparat> meniu = new List<Preparat>();
        List<Comanda> lstComenzi= new List<Comanda>();
        Control[] vectControl;

        Preparat p1 = new Preparat("Cafea", 16);
        Preparat p2 = new Preparat("Cascaval pane", 12);

        public Form1() {
            InitializeComponent();

            meniu.Add(p1); meniu.Add(p2);
            meniu.Add(new Preparat("Supa de legume", 22));

            Preparat[] vp = new Preparat[] {
                new Preparat("Ciorba de burta", 23),
                new Preparat("Ciorba de perisoare", 24),
                new Preparat("Supa cu galuste", 21) 
            };

            meniu.AddRange(vp);

            cbPreparat.DataSource = meniu.Select(x => x.Denumire).ToList();

            tbMes.Text += $"\r\nA fost initializat meniul cu {meniu.Count} preparate";

            vectControl = new Control[] { tbMasa, cbPreparat, nudCantitate, btnOK, btnCancel,label1, label2, label3 };
            foreach (Control c in vectControl) { c.Visible = false; }
        }

        private void btnCom_Click(object sender, EventArgs e) {
            foreach (Control c in vectControl) { c.Visible = true; }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            int idMasa = int.Parse(tbMasa.Text);
            float pret = meniu.First(x => x.Denumire == cbPreparat.Text).Pret;
            /*foreach (Preparat crt in meniu) {
                if (crt.Denumire == cbPreparat.Text) {
                    pret = crt.Pret;
                    break;
                }
            }*/
            Preparat p = new Preparat(cbPreparat.Text, pret);
            int cant = (int)nudCantitate.Value;

            Comanda cda = new Comanda(idMasa, p, cant);
            lstComenzi.Add(cda);
            tbMes.Text += $"\r\nS-a preluat o comanda de {cda.Valoare} lei.";

            foreach(Control c in vectControl) { c.Visible = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            foreach (Control c in vectControl) { c.Visible = false; }
        }

        private void btnAch_Click(object sender, EventArgs e) {
            lblIdMasa.Visible = true; tbIdMasaAchita.Visible= true;

            
        }

        private void btnCalcul_Click(object sender, EventArgs e) {
            int idMasa = int.Parse(tbIdMasaAchita.Text);
            NotaPlata np = new NotaPlata();
            np.idMasaAchita= idMasa;
            foreach (Comanda c in lstComenzi) {
                if(c.IdMasa== idMasa) {
                    np.lstComenziMasa.Add(c);
                }
            }
            DialogResult results = MessageBox.Show($"Platesti suma de {np.TotalNota} lei?",
                                                   "Confirmare plata",
                                                   MessageBoxButtons.YesNo);
        }

        private void nudCantitate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPreparat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }  
}
