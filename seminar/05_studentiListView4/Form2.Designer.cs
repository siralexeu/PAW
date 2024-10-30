namespace _05_studentiListView {
    partial class Form2 {
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
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(154, 27);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(100, 20);
            this.tbMatricol.TabIndex = 0;
            this.tbMatricol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(154, 65);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(212, 20);
            this.tbNume.TabIndex = 1;
            this.tbNume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(154, 100);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(132, 20);
            this.tbData.TabIndex = 2;
            this.tbData.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(154, 140);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(212, 20);
            this.tbNote.TabIndex = 3;
            this.tbNote.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data inmatriculare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note(separate prin virgula)";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(66, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbMatricol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbMatricol;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbData;
        public System.Windows.Forms.TextBox tbNote;
        public System.Windows.Forms.Label label4;
    }
}