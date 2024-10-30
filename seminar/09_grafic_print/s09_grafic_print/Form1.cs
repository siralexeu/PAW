namespace s09_grafic_print {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listStud.Add(new Student(123, "Popa Ion",
                new int[] { 6, 7, 8 }, DateTime.Now));
        }

        List<Student> listStud = new List<Student>() {
            new Student(134, "Ion Ana",
                new int[] { 8, 8, 9 }, DateTime.Now),
            new Student(123, "Andreescu Ioana",
                new int[] { 5, 6, 7 }, new DateTime(2024,10, 5)),
            new Student(154, "Dumitru Ana Maria",
                new int[] { 10, 10, 10 }, new DateTime(2024,10, 5)),
            new Student(210, "Popa Ioana",
                new int[] { 3, 5, 5 }, new DateTime(2024,9, 6)),
            new Student(354, "Ducu Daria",
                new int[] { 7, 2, 1 }, new DateTime(2024,10, 5)),
            new Student(111, "Popescu Doru",
                new int[] { 1, 2, 1 }, new DateTime(2024,10, 5)),
            new Student(345, "Popa Ionel",
                new int[] { 2, 2, 2 }, new DateTime(2024,10, 5)),
            new Student(678, "Alani Rafael",
                new int[] { 3, 3, 3 }, new DateTime(2024,10, 5)),
            new Student(543, "Vasile Dana",
                new int[] { 6, 7, 8 }, new DateTime(2024,10, 5)),
            new Student(343, "Muresan Andreea",
                new int[] { 5, 6, 4, 8 }, new DateTime(2024,10, 5)),
            new Student(212, "Iancu Valeria",
                new int[] { 3,4, 4 }, new DateTime(2024,10, 5)),
            new Student(222, "Lupu Vlad",
                new int[] { 5, 5, 5 }, new DateTime(2024,10, 5)),
            new Student(443, "Marinescu Florin",
                new int[] { 9, 9, 9 }, new DateTime(2024,10, 5))
        };

        private void restantieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Student> lstRestantieri = listStud.Where(x => x.Media < 5).ToList();
            foreach (Student student in lstRestantieri)
                tbMes.Text += "\r\n " + student + $"  cu media  {student.Media:0.00}    ";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Student> lstPromovati = listStud.Where(x => x.Media >= 5).ToList();
            Graphics g = e.Graphics;
            String str; float y = 0;
            foreach (Student s in lstPromovati)
            {
                str = $"{s.Nume}   {s.Media:0.00} ";
                g.DrawString(str, Font, Brushes.DeepPink, 10, y += 13);
            }
        }

        private void previewPromovatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void promovatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previewPromovatiToolStripMenuItem.PerformClick();
        }

        private void graficFrecventaNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] contoare = new int[10];
            foreach (Student crt in listStud)
            {
                contoare[(int)crt - 1]++;
            }
            for (int i = 0; i < contoare.Length; i++)
                tbMes.Text += $"\r\n" + contoare[i];
            Form2 desen = new Form2();
            desen.contoare2 = contoare;
            desen.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}