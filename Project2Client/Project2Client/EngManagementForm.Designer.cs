namespace Project2Client
{
    partial class EngManagementForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.engineerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s7110008DataSet = new Project2Client.s7110008DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repairsOFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s7110008DataSet1 = new Project2Client.s7110008DataSet();
            this.repairsEFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsEFTableAdapter = new Project2Client.s7110008DataSetTableAdapters.RepairsEFTableAdapter();
            this.engineerTableAdapter = new Project2Client.s7110008DataSetTableAdapters.EngineerTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.repairsMFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairsMFTableAdapter = new Project2Client.s7110008DataSetTableAdapters.RepairsMFTableAdapter();
            this.repairsOFTableAdapter = new Project2Client.s7110008DataSetTableAdapters.RepairsOFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsOFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsEFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsMFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.engineerBindingSource;
            this.comboBox1.DisplayMember = "engNo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // repairsOFBindingSource
            // 
            this.repairsOFBindingSource.DataMember = "FK__RepairsOF__engNo__544C7222";
            this.repairsOFBindingSource.DataSource = this.engineerBindingSource;
            // 
            // s7110008DataSet1
            // 
            this.s7110008DataSet1.DataSetName = "s7110008DataSet";
            this.s7110008DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairsEFBindingSource
            // 
            this.repairsEFBindingSource.DataMember = "FK__RepairsEF__engNo__581D0306";
            this.repairsEFBindingSource.DataSource = this.engineerBindingSource;
            // 
            // repairsEFTableAdapter
            // 
            this.repairsEFTableAdapter.ClearBeforeFill = true;
            // 
            // engineerTableAdapter
            // 
            this.engineerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Electrical Repairs",
            "Mechanical Repairs",
            "Other Repairs"});
            this.comboBox2.Location = new System.Drawing.Point(139, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Make Repair";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // repairsMFBindingSource
            // 
            this.repairsMFBindingSource.DataMember = "FK__RepairsMF__engNo__5BED93EA";
            this.repairsMFBindingSource.DataSource = this.engineerBindingSource;
            // 
            // repairsMFTableAdapter
            // 
            this.repairsMFTableAdapter.ClearBeforeFill = true;
            // 
            // repairsOFTableAdapter
            // 
            this.repairsOFTableAdapter.ClearBeforeFill = true;
            // 
            // EngManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EngManagementForm";
            this.Text = "EngManagementForm";
            this.Load += new System.EventHandler(this.EngManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.engineerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsOFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7110008DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsEFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsMFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private s7110008DataSet s7110008DataSet;
        private System.Windows.Forms.BindingSource repairsEFBindingSource;
        private s7110008DataSetTableAdapters.RepairsEFTableAdapter repairsEFTableAdapter;
        private System.Windows.Forms.BindingSource engineerBindingSource;
        private s7110008DataSetTableAdapters.EngineerTableAdapter engineerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private s7110008DataSet s7110008DataSet1;
        private System.Windows.Forms.BindingSource repairsMFBindingSource;
        private s7110008DataSetTableAdapters.RepairsMFTableAdapter repairsMFTableAdapter;
        private System.Windows.Forms.BindingSource repairsOFBindingSource;
        private s7110008DataSetTableAdapters.RepairsOFTableAdapter repairsOFTableAdapter;
    }
}