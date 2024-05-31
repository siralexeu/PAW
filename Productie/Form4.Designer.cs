namespace Productie
{
    partial class Form4
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
            this.numeProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotFabricatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisaConsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProdusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbProductieDataSet = new Productie.dbProductieDataSet();
            this.tblProdusTableAdapter = new Productie.dbProductieDataSetTableAdapters.tblProdusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeProdusDataGridViewTextBoxColumn,
            this.lotFabricatieDataGridViewTextBoxColumn,
            this.fisaConsumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProdusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 632);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeProdusDataGridViewTextBoxColumn
            // 
            this.numeProdusDataGridViewTextBoxColumn.DataPropertyName = "numeProdus";
            this.numeProdusDataGridViewTextBoxColumn.HeaderText = "numeProdus";
            this.numeProdusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numeProdusDataGridViewTextBoxColumn.Name = "numeProdusDataGridViewTextBoxColumn";
            this.numeProdusDataGridViewTextBoxColumn.Width = 150;
            // 
            // lotFabricatieDataGridViewTextBoxColumn
            // 
            this.lotFabricatieDataGridViewTextBoxColumn.DataPropertyName = "lotFabricatie";
            this.lotFabricatieDataGridViewTextBoxColumn.HeaderText = "lotFabricatie";
            this.lotFabricatieDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lotFabricatieDataGridViewTextBoxColumn.Name = "lotFabricatieDataGridViewTextBoxColumn";
            this.lotFabricatieDataGridViewTextBoxColumn.Width = 150;
            // 
            // fisaConsumDataGridViewTextBoxColumn
            // 
            this.fisaConsumDataGridViewTextBoxColumn.DataPropertyName = "fisaConsum";
            this.fisaConsumDataGridViewTextBoxColumn.HeaderText = "fisaConsum";
            this.fisaConsumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fisaConsumDataGridViewTextBoxColumn.Name = "fisaConsumDataGridViewTextBoxColumn";
            this.fisaConsumDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblProdusBindingSource
            // 
            this.tblProdusBindingSource.DataMember = "tblProdus";
            this.tblProdusBindingSource.DataSource = this.dbProductieDataSet;
            // 
            // dbProductieDataSet
            // 
            this.dbProductieDataSet.DataSetName = "dbProductieDataSet";
            this.dbProductieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProdusTableAdapter
            // 
            this.tblProdusTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 810);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Productia4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductieDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbProductieDataSet dbProductieDataSet;
        private System.Windows.Forms.BindingSource tblProdusBindingSource;
        private dbProductieDataSetTableAdapters.tblProdusTableAdapter tblProdusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotFabricatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisaConsumDataGridViewTextBoxColumn;
    }
}