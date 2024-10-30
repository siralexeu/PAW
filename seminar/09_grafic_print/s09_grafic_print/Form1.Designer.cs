namespace s09_grafic_print {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbMes = new TextBox();
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            previewPromovatiToolStripMenuItem = new ToolStripMenuItem();
            rapoarteToolStripMenuItem = new ToolStripMenuItem();
            restantieriToolStripMenuItem = new ToolStripMenuItem();
            promovatiToolStripMenuItem = new ToolStripMenuItem();
            graficFrecventaNoteToolStripMenuItem = new ToolStripMenuItem();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbMes
            // 
            tbMes.Dock = DockStyle.Bottom;
            tbMes.Location = new Point(0, 521);
            tbMes.Margin = new Padding(6);
            tbMes.Multiline = true;
            tbMes.Name = "tbMes";
            tbMes.ScrollBars = ScrollBars.Vertical;
            tbMes.Size = new Size(1486, 439);
            tbMes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, rapoarteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 44);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { previewPromovatiToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(89, 36);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // previewPromovatiToolStripMenuItem
            // 
            previewPromovatiToolStripMenuItem.Name = "previewPromovatiToolStripMenuItem";
            previewPromovatiToolStripMenuItem.Size = new Size(344, 44);
            previewPromovatiToolStripMenuItem.Text = "Preview Promovati";
            previewPromovatiToolStripMenuItem.Click += previewPromovatiToolStripMenuItem_Click;
            // 
            // rapoarteToolStripMenuItem
            // 
            rapoarteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restantieriToolStripMenuItem, promovatiToolStripMenuItem, graficFrecventaNoteToolStripMenuItem });
            rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            rapoarteToolStripMenuItem.Size = new Size(129, 36);
            rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // restantieriToolStripMenuItem
            // 
            restantieriToolStripMenuItem.Name = "restantieriToolStripMenuItem";
            restantieriToolStripMenuItem.Size = new Size(378, 44);
            restantieriToolStripMenuItem.Text = "Restantieri";
            restantieriToolStripMenuItem.Click += restantieriToolStripMenuItem_Click;
            // 
            // promovatiToolStripMenuItem
            // 
            promovatiToolStripMenuItem.Name = "promovatiToolStripMenuItem";
            promovatiToolStripMenuItem.Size = new Size(378, 44);
            promovatiToolStripMenuItem.Text = "Promovati";
            promovatiToolStripMenuItem.Click += promovatiToolStripMenuItem_Click;
            // 
            // graficFrecventaNoteToolStripMenuItem
            // 
            graficFrecventaNoteToolStripMenuItem.Name = "graficFrecventaNoteToolStripMenuItem";
            graficFrecventaNoteToolStripMenuItem.Size = new Size(378, 44);
            graficFrecventaNoteToolStripMenuItem.Text = "Grafic Frecventa Note";
            graficFrecventaNoteToolStripMenuItem.Click += graficFrecventaNoteToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(tbMes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem previewPromovatiToolStripMenuItem;
        private ToolStripMenuItem rapoarteToolStripMenuItem;
        private ToolStripMenuItem restantieriToolStripMenuItem;
        private ToolStripMenuItem promovatiToolStripMenuItem;
        private ToolStripMenuItem graficFrecventaNoteToolStripMenuItem;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}