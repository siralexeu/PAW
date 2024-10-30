using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s09_grafic_print {
    internal class Student {

        public int Matricol { get; set; }
        public string Nume { get; set; }
        public DateTime DataInmatriculare { get; set; }
        public int[] Note { get; set; }
        public double Media { get => Note.Average(); }
        public Student(int _Matricol = 123, string _Nume = "anonim",
            int[] _Note = null, DateTime _DataInmatriculare = new DateTime()) {
            this.Matricol = _Matricol;
            this.Nume = _Nume;
            this.DataInmatriculare = _DataInmatriculare;
            // _Note.CopyTo(this.Note, 0);
            if (_Note != null) {
                this.Note = new int[_Note.Length];
                for (int i = 0; i < _Note.Length; i++) {
                    this.Note[i] = _Note[i];
                }
            }
        }
        public static explicit operator int(Student student) {
            //return (int)student.Media;
            return student.Note.Sum() / student.Note.Count();
        }

        public static Student operator +(Student student1, int nota) {
            int[] aux = student1.Note;
            student1.Note = new int[aux.Length + 1];
            for (int i = 0; i < aux.Length; i++) {
                student1.Note[i] = aux[i];
            }
            student1.Note[student1.Note.Length - 1] = nota;
            return student1;
        }

        public override string ToString() {
            string strStud = $"{Matricol} {Nume} {DataInmatriculare.ToShortDateString()} (";
            string strNote = "fara note";
            if (Note != null) strNote = string.Join(", ", this.Note);
            strStud = strStud + strNote + ")";
            return strStud;
        }

        public int this[int i] { get => Note[i]; set => Note[i] = value; }

        public Student(Student src) {
            this.Matricol = src.Matricol;
            this.Nume = src.Nume;
            this.DataInmatriculare = src.DataInmatriculare;
            this.Note = new int[src.Note.Length];
            for (int i = 0; i < src.Note.Length; i++) {
                Note[i] = src.Note[i];
            }

        }

    }
}
