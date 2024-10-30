namespace Restaurant {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbMes = new System.Windows.Forms.TextBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnAch = new System.Windows.Forms.Button();
            this.lblIdMasa = new System.Windows.Forms.Label();
            this.tbMasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPreparat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMasa = new System.Windows.Forms.Label();
            this.tbIdMasaAchita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMes
            // 
            this.tbMes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMes.Location = new System.Drawing.Point(0, 1044);
            this.tbMes.Margin = new System.Windows.Forms.Padding(6);
            this.tbMes.Multiline = true;
            this.tbMes.Name = "tbMes";
            this.tbMes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMes.Size = new System.Drawing.Size(1662, 181);
            this.tbMes.TabIndex = 0;
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(284, 131);
            this.btnCom.Margin = new System.Windows.Forms.Padding(6);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(334, 167);
            this.btnCom.TabIndex = 1;
            this.btnCom.Text = "COMANDA";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnAch
            // 
            this.btnAch.Location = new System.Drawing.Point(1098, 131);
            this.btnAch.Margin = new System.Windows.Forms.Padding(6);
            this.btnAch.Name = "btnAch";
            this.btnAch.Size = new System.Drawing.Size(342, 167);
            this.btnAch.TabIndex = 2;
            this.btnAch.Text = "ACHITA";
            this.btnAch.UseVisualStyleBackColor = true;
            this.btnAch.Click += new System.EventHandler(this.btnAch_Click);
            // 
            // lblIdMasa
            // 
            this.lblIdMasa.AutoSize = true;
            this.lblIdMasa.Location = new System.Drawing.Point(284, 394);
            this.lblIdMasa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdMasa.Name = "lblIdMasa";
            this.lblIdMasa.Size = new System.Drawing.Size(0, 25);
            this.lblIdMasa.TabIndex = 3;
            // 
            // tbMasa
            // 
            this.tbMasa.Location = new System.Drawing.Point(402, 388);
            this.tbMasa.Margin = new System.Windows.Forms.Padding(6);
            this.tbMasa.Name = "tbMasa";
            this.tbMasa.Size = new System.Drawing.Size(236, 31);
            this.tbMasa.TabIndex = 4;
            this.tbMasa.TextChanged += new System.EventHandler(this.tbMasa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Masa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 502);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preparat:";
            // 
            // cbPreparat
            // 
            this.cbPreparat.FormattingEnabled = true;
            this.cbPreparat.Location = new System.Drawing.Point(402, 496);
            this.cbPreparat.Margin = new System.Windows.Forms.Padding(6);
            this.cbPreparat.Name = "cbPreparat";
            this.cbPreparat.Size = new System.Drawing.Size(236, 33);
            this.cbPreparat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 600);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantitate:";
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(402, 596);
            this.nudCantitate.Margin = new System.Windows.Forms.Padding(6);
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(240, 31);
            this.nudCantitate.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(256, 702);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 98);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(514, 702);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 98);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(1094, 387);
            this.lblMasa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(71, 25);
            this.lblMasa.TabIndex = 14;
            this.lblMasa.Text = "Masa:";
            this.lblMasa.Visible = false;
            // 
            // tbIdMasaAchita
            // 
            this.tbIdMasaAchita.Location = new System.Drawing.Point(1200, 381);
            this.tbIdMasaAchita.Margin = new System.Windows.Forms.Padding(6);
            this.tbIdMasaAchita.Name = "tbIdMasaAchita";
            this.tbIdMasaAchita.Size = new System.Drawing.Size(236, 31);
            this.tbIdMasaAchita.TabIndex = 13;
            this.tbIdMasaAchita.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1082, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 12;
            this.label5.Visible = false;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(1488, 377);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(150, 44);
            this.btnCalcul.TabIndex = 15;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1225);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.tbIdMasaAchita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPreparat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMasa);
            this.Controls.Add(this.lblIdMasa);
            this.Controls.Add(this.btnAch);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.tbMes);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnAch;
        private System.Windows.Forms.Label lblIdMasa;
        private System.Windows.Forms.TextBox tbMasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPreparat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbIdMasaAchita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcul;
        public System.Windows.Forms.Label lblMasa;
    }
}

