namespace Project2Client
{
    partial class EngineerManagementForm
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
            this.engNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateJoinedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s7110008DataSet = new Project2Client.s7110008DataSet();
            this.engineerTableAdapter = new Project2Client.s7110008DataSetTableAdapters.EngineerTableAdapter();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engNoDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.miDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.dateJoinedDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.engineerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // engNoDataGridViewTextBoxColumn
            // 
            this.engNoDataGridViewTextBoxColumn.DataPropertyName = "engNo";
            this.engNoDataGridViewTextBoxColumn.HeaderText = "engNo";
            this.engNoDataGridViewTextBoxColumn.Name = "engNoDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // miDataGridViewTextBoxColumn
            // 
            this.miDataGridViewTextBoxColumn.DataPropertyName = "Mi";
            this.miDataGridViewTextBoxColumn.HeaderText = "Mi";
            this.miDataGridViewTextBoxColumn.Name = "miDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // dateJoinedDataGridViewTextBoxColumn
            // 
            this.dateJoinedDataGridViewTextBoxColumn.DataPropertyName = "dateJoined";
            this.dateJoinedDataGridViewTextBoxColumn.HeaderText = "dateJoined";
            this.dateJoinedDataGridViewTextBoxColumn.Name = "dateJoinedDataGridViewTextBoxColumn";
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "cName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // engineerBindingSource
            // 
            this.engineerBindingSource.DataMember = "Engineer";
            this.engineerBindingSource.DataSource = this.s7110008DataSet;
            // 
            // s7110008DataSet
            // 
            this.s7110008DataSet.DataSetName = "s7110008DataSet";
            this.s7110008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // engineerTableAdapter
            // 
            this.engineerTableAdapter.ClearBeforeFill = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 63);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(93, 63);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Must Save to Commit Delete";
            // 
            // EngineerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EngineerManagementForm";
            this.Text = "EngineerManagementForm";
            this.Load += new System.EventHandler(this.EngineerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private s7110008DataSet s7110008DataSet;
        private System.Windows.Forms.BindingSource engineerBindingSource;
        private s7110008DataSetTableAdapters.EngineerTableAdapter engineerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn engNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateJoinedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
    }
}