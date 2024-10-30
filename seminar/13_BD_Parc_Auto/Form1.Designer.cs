namespace _13_BD_Parc_Auto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toneKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCamioaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbParcAutoDataSet = new _13_BD_Parc_Auto.dbParcAutoDataSet();
            this.tblCamioaneTableAdapter = new _13_BD_Parc_Auto.dbParcAutoDataSetTableAdapters.tblCamioaneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamioaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbParcAutoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.capacitateDataGridViewTextBoxColumn,
            this.toneKmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCamioaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 659);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // capacitateDataGridViewTextBoxColumn
            // 
            this.capacitateDataGridViewTextBoxColumn.DataPropertyName = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.HeaderText = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.capacitateDataGridViewTextBoxColumn.Name = "capacitateDataGridViewTextBoxColumn";
            this.capacitateDataGridViewTextBoxColumn.Width = 120;
            // 
            // toneKmDataGridViewTextBoxColumn
            // 
            this.toneKmDataGridViewTextBoxColumn.DataPropertyName = "ToneKm";
            this.toneKmDataGridViewTextBoxColumn.HeaderText = "ToneKm";
            this.toneKmDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.toneKmDataGridViewTextBoxColumn.Name = "toneKmDataGridViewTextBoxColumn";
            this.toneKmDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblCamioaneBindingSource
            // 
            this.tblCamioaneBindingSource.DataMember = "tblCamioane";
            this.tblCamioaneBindingSource.DataSource = this.dbParcAutoDataSet;
            // 
            // dbParcAutoDataSet
            // 
            this.dbParcAutoDataSet.DataSetName = "dbParcAutoDataSet";
            this.dbParcAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCamioaneTableAdapter
            // 
            this.tblCamioaneTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 887);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamioaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbParcAutoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbParcAutoDataSet dbParcAutoDataSet;
        private System.Windows.Forms.BindingSource tblCamioaneBindingSource;
        private dbParcAutoDataSetTableAdapters.tblCamioaneTableAdapter tblCamioaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toneKmDataGridViewTextBoxColumn;
    }
}

