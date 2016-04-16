namespace Project2Client
{
    partial class MakeRepairForm2
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
            this.commitRepair = new System.Windows.Forms.Button();
            this.faultID = new System.Windows.Forms.ComboBox();
            this.tableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet = new Project2Client.s7110008DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursRepairing = new System.Windows.Forms.TextBox();
            this.faultViewer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // commitRepair
            // 
            this.commitRepair.Location = new System.Drawing.Point(306, 265);
            this.commitRepair.Name = "commitRepair";
            this.commitRepair.Size = new System.Drawing.Size(94, 23);
            this.commitRepair.TabIndex = 0;
            this.commitRepair.Text = "Make Repair";
            this.commitRepair.UseVisualStyleBackColor = true;
            this.commitRepair.Click += new System.EventHandler(this.commitRepair_Click);
            // 
            // faultID
            // 
            this.faultID.FormattingEnabled = true;
            this.faultID.Location = new System.Drawing.Point(82, 9);
            this.faultID.Name = "faultID";
            this.faultID.Size = new System.Drawing.Size(51, 21);
            this.faultID.TabIndex = 1;
            // 
            // tableName
            // 
            this.tableName.FormattingEnabled = true;
            this.tableName.Items.AddRange(new object[] {
            "Electrical",
            "Mechanical",
            "Other"});
            this.tableName.Location = new System.Drawing.Point(193, 9);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(104, 21);
            this.tableName.TabIndex = 2;
            this.tableName.TextChanged += new System.EventHandler(this.tableName_TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fault Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Fault";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "s7110008DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours Repairing Fault";
            // 
            // hoursRepairing
            // 
            this.hoursRepairing.Location = new System.Drawing.Point(129, 37);
            this.hoursRepairing.Name = "hoursRepairing";
            this.hoursRepairing.Size = new System.Drawing.Size(74, 20);
            this.hoursRepairing.TabIndex = 7;
            this.hoursRepairing.TextChanged += new System.EventHandler(this.hoursRepairing_TextChanged);
            // 
            // faultViewer
            // 
            this.faultViewer.AllowUserToAddRows = false;
            this.faultViewer.AllowUserToDeleteRows = false;
            this.faultViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faultViewer.Location = new System.Drawing.Point(16, 63);
            this.faultViewer.Name = "faultViewer";
            this.faultViewer.ReadOnly = true;
            this.faultViewer.Size = new System.Drawing.Size(384, 196);
            this.faultViewer.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "On (mm/dd/yyyy)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // MakeRepairForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.faultViewer);
            this.Controls.Add(this.hoursRepairing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.faultID);
            this.Controls.Add(this.commitRepair);
            this.Name = "MakeRepairForm2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commitRepair;
        private System.Windows.Forms.ComboBox faultID;
        private System.Windows.Forms.ComboBox tableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private s7110008DataSet dataSet;
        private System.Windows.Forms.BindingSource faultViewerSource;
        private s7110008DataSetTableAdapters.MechFaultTableAdapter MechFaultTableAdapter;
        private s7110008DataSetTableAdapters.OtherFaultTableAdapter OtherFaultTableAdapter;
        private s7110008DataSetTableAdapters.ElectFaultTableAdapter ElectFaultTableAdapter;
        private s7110008DataSetTableAdapters.RepairsEFTableAdapter RepairsEFTableAdapter;
        private s7110008DataSetTableAdapters.RepairsOFTableAdapter RepairsOFTableAdapter;
        private s7110008DataSetTableAdapters.RepairsMFTableAdapter RepairsMFTableAdapter;
        private System.Windows.Forms.TextBox hoursRepairing;
        private System.Windows.Forms.DataGridView faultViewer;
        private System.Windows.Forms.BindingSource faultIDSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}