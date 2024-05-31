using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Productie
{
    public partial class Form3 : Form
    {
        public List<int> lot { get; set; }

        public Form3()
        {
            InitializeComponent();          
        }
        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            if (lot == null || lot.Count == 0)
                return;

            Graphics g = e.Graphics;
            Pen creion = new Pen(Brushes.Black, 0);
            Brush[] culori = new Brush[]
            {
                Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Green, Brushes.Gold,
                Brushes.Ivory, Brushes.Khaki, Brushes.Magenta, Brushes.Lime, Brushes.Orange
            };

            int latime = ClientRectangle.Width;
            int inaltime = ClientRectangle.Height;
            int nrlot = lot.Count;
            int latBloc = latime / nrlot;

            int maxLotFabricatie = lot.Max();
            int inaltimeBloc = inaltime / maxLotFabricatie;

            for (int i = 0; i < nrlot; i++)
            {
                int x = i * latBloc;
                int y = inaltime - lot[i] * inaltimeBloc; 
                int latBlocCorectat = latBloc - 1; 

                g.FillRectangle(culori[i % culori.Length], x, y, latBlocCorectat, lot[i] * inaltimeBloc);
                g.DrawRectangle(creion, x, y, latBlocCorectat, lot[i] * inaltimeBloc);

                string lotText = lot[i].ToString();
                SizeF textSize = g.MeasureString(lotText, this.Font);
                float textX = x + (latBlocCorectat - textSize.Width) / 2; 
                float textY = y - textSize.Height - 2; 
                g.DrawString(lotText, this.Font, Brushes.Black, textX, textY);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
