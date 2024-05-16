using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Productie
{
    public partial class Form3 : Form
    {
        private Dictionary<int, int> lot;

        public Form3(Dictionary<int, int> lot)
        {
            InitializeComponent();
            this.lot = lot;  
            this.Paint += new PaintEventHandler(Form3_Paint);
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            if (lot == null || lot.Count == 0)
                return;

            Graphics g = e.Graphics;
            Pen creion = new Pen(Brushes.Red, 2);
            Brush[] culori = new Brush[] { Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.SpringGreen,Brushes.Purple, 
                Brushes.Brown, Brushes.Black, Brushes.Orange,Brushes.Pink, Brushes.DarkGray, Brushes.Gold, Brushes.Magenta};

            Rectangle clientRect = this.ClientRectangle;
            int vl = clientRect.X + 10, vr = clientRect.Width - 10;
            int vt = clientRect.Y + 10, vb = clientRect.Height - 10;
            g.DrawRectangle(creion, vl, vt, vr - vl, vb - vt);

            int max = lot.Values.Max(); 
            float scara = max > 0 ? (vb - vt) / (float)max : 0;
            int lat = lot.Count > 0 ? (vr - vl) / lot.Count : 0; 

            int x = vl;
            foreach (var entry in lot)
            {
                int height = (int)(entry.Value * scara);
                g.FillRectangle(culori[entry.Key % culori.Length], x, vb - height, lat, height);
                x += lat;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
