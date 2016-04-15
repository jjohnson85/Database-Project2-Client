namespace Project2Client
{
    partial class CMangamentForm
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEngineerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s7110008DataSet = new Project2Client.s7110008DataSet();
            this.companyTableAdapter = new Project2Client.s7110008DataSetTableAdapters.CompanyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.eINDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.totalEngineerDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.phone3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // eINDataGridViewTextBoxColumn
            // 
            this.eINDataGridViewTextBoxColumn.DataPropertyName = "EIN";
            this.eINDataGridViewTextBoxColumn.HeaderText = "EIN";
            this.eINDataGridViewTextBoxColumn.Name = "eINDataGridViewTextBoxColumn";
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            // 
            // totalEngineerDataGridViewTextBoxColumn
            // 
            this.totalEngineerDataGridViewTextBoxColumn.DataPropertyName = "totalEngineer";
            this.totalEngineerDataGridViewTextBoxColumn.HeaderText = "totalEngineer";
            this.totalEngineerDataGridViewTextBoxColumn.Name = "totalEngineerDataGridViewTextBoxColumn";
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "phone1";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "phone2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "phone2";
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            // 
            // phone3DataGridViewTextBoxColumn
            // 
            this.phone3DataGridViewTextBoxColumn.DataPropertyName = "phone3";
            this.phone3DataGridViewTextBoxColumn.HeaderText = "phone3";
            this.phone3DataGridViewTextBoxColumn.Name = "phone3DataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.s7110008DataSet;
            // 
            // s7110008DataSet
            // 
            this.s7110008DataSet.DataSetName = "s7110008DataSet";
            this.s7110008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Must Save to Commit Delete";
            // 
            // CMangamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CMangamentForm";
            this.Text = "Company Management Form";
            this.Load += new System.EventHandler(this.CMangamentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private s7110008DataSet s7110008DataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private s7110008DataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEngineerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}