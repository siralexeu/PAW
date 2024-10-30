using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_studentiListView {
    public partial class Form1 : Form {
        Student s1 = new Student();
        List<Student> lstStudent = new List<Student>();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            tbMes.Text += "\r\n" + s1;
            s1 = new Student(345, "Popescu Ion", new int[] { 7, 5, 9 }, DateTime.Now);
            tbMes.Text += "\r\n" + s1;
            s1 = s1 + 8;
            tbMes.Text += "\r\n" + s1;
            s1[1] = 8;
            tbMes.Text += "\r\n" + s1;
            Student s2 = new Student(s1);
            s1[0] = 10;
            tbMes.Text += "\r\n" + s1;
            tbMes.Text += "\r\n" + s2;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 macheta = new Form2();
            DialogResult r = macheta.ShowDialog();
            if(r == DialogResult.OK)
            {
                s1.Matricol = int.Parse(macheta.tbMatricol.Text);
                s1.Nume = macheta.tbNume.Text;
                s1.DataInmatriculare = DateTime.Parse(macheta.tbData.Text);
                string[] noteCitite = macheta.tbNote.Text.Split(',');
                s1.Note = new int[noteCitite.Length];
                for (int i = 0; i < noteCitite.Length; i++)
                {
                    s1.Note[i] = int.Parse(noteCitite[i]);
                }
                lstStudent.Add(s1);

                ListViewItem itm = new ListViewItem(macheta.tbMatricol.Text);
                itm.SubItems.Add(macheta.tbNume.Text);
                itm.SubItems.Add(macheta.tbData.Text);
                itm.SubItems.Add(macheta.tbNote.Text);
                listView1.Items.Add(itm);
                tbMes.Text += "\r\nForma s-a inchis cu OK.";
            }
            else
            {
                tbMes.Text += "\r\nForma s-a inchis cu Cancel.";
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                int pozitie = itm.Index;
                Form2 macheta = new Form2();
                DialogResult r;
                macheta.tbMatricol.Text = itm.Text;
                macheta.tbNume.Text = itm.SubItems[1].Text;
                macheta.tbData.Text = itm.SubItems[2].Text;
                macheta.tbNote.Text = itm.SubItems[3].Text;
                r = macheta.ShowDialog();
                if(r == DialogResult.OK)
                {
                    itm.SubItems[0].Text = macheta.tbMatricol.Text;
                    itm.SubItems[1].Text = macheta.tbNume.Text;
                    itm.SubItems[2].Text = macheta.tbData.Text;
                    itm.SubItems[3].Text = macheta.tbNote.Text;

                    s1 = lstStudent[pozitie];

                    s1.Matricol = int.Parse(macheta.tbMatricol.Text);
                    s1.Nume = macheta.tbNume.Text;
                    s1.DataInmatriculare = DateTime.Parse(macheta.tbData.Text);
                    string[] strNote = macheta.tbNote.Text.Split(',');
                    s1.Note = new int[strNote.Length];
                    for (int i = 0; i < strNote.Length; i++)
                    {
                        s1.Note[i] = int.Parse(strNote[i]);
                    }
                }

            }
            else { tbMes.Text += "\r\nSelectati in listView linia de modificat."; 
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            updateToolStripMenuItem.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                int pozitie = itm.Index;
                listView1.Items.RemoveAt(pozitie);
                listView1.Refresh();
                //s1 = lstStudent[pozitie];
                lstStudent.Remove(lstStudent[pozitie]);
            }
            else tbMes.Text += "\r\nSelectati din listView linia de sters";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            FileStream fisStud = new FileStream("stud.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisStud, lstStudent);
            fisStud.Close();
            tbMes.Text += $"\r\nAu fost salvate {lstStudent.Count} inregistrari"; 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FileStream fisStud = new FileStream("stud.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter(); 
            lstStudent = (List<Student>)bf.Deserialize(fisStud);
            fisStud.Close();
            listView1.Items.Clear();
            foreach(Student student in lstStudent) 
            {
             ListViewItem itm = new ListViewItem(student.Matricol.ToString());
                itm.SubItems.Add(student.Nume);
                itm.SubItems.Add(student.DataInmatriculare.ToShortDateString());
                string strNote = null;
                if(student.Note!=null) strNote = string.Join(", ", student.Note);
                itm.SubItems.Add(strNote);
                listView1.Items.Add(itm);
            }
             tbMes.Text += $"\r\nAu fost citite {lstStudent.Count} inregistrari"; 
        }
    }
}
