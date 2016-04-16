namespace Project2Client
{
    partial class MakeRepairForm
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
        private void InitializeComponent(int EngNo)
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet = new s7110008DataSet();
            this.faultViewerSource = new System.Windows.Forms.BindingSource(this.components);
            this.mechFaultAdapter = new s7110008DataSetTableAdapters.MechFaultTableAdapter();
            this.otherFaultAdapter = new s7110008DataSetTableAdapters.OtherFaultTableAdapter();
            this.electFaultAdapter = new s7110008DataSetTableAdapters.ElectFaultTableAdapter();
            this.repairsEFTableAdapter = new s7110008DataSetTableAdapters.RepairsEFTableAdapter();
            this.repairsMFTableAdapter = new s7110008DataSetTableAdapters.RepairsMFTableAdapter();
            this.repairsOFTableAdapter = new s7110008DataSetTableAdapters.RepairsOFTableAdapter();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.faultNumberEntry = new System.Windows.Forms.TextBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.faultViewer = new System.Windows.Forms.DataGridView();
            this.tableSelecter = new System.Windows.Forms.ComboBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.buttonRepairFault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faultViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultViewerSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            //
            // faultViewerSource
            //
            this.faultViewerSource.DataMember = "MechFault";
            this.faultViewerSource.DataSource = this.dataSet;
            // 
            // s7110008DataSet
            // 
            this.dataSet.DataSetName = "s7110008DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // 
            // textBox1
            // 
            this.faultNumberEntry.BackColor = System.Drawing.Color.White;
            this.faultNumberEntry.Location = new System.Drawing.Point(81, 12);
            this.faultNumberEntry.Name = "faultNumberEntry";
            this.faultNumberEntry.Size = new System.Drawing.Size(127, 20);
            this.faultNumberEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(12, 15);
            this.selectLabel.Name = "Fault select label";
            this.selectLabel.Size = new System.Drawing.Size(63, 13);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Select Fault";
            // 
            // dataGridView1
            // 
            this.faultViewer.DataSource = this.faultViewerSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faultViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.faultViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.faultViewer.DefaultCellStyle = dataGridViewCellStyle2;
            this.faultViewer.Location = new System.Drawing.Point(13, 71);
            this.faultViewer.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faultViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.faultViewer.Size = new System.Drawing.Size(517, 147);
            this.faultViewer.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.tableSelecter.FormattingEnabled = true;
            this.tableSelecter.Items.AddRange(new object[] {
            "Electrical Faults",
            "Mechanical Faults",
            "Other Faults"});
            this.tableSelecter.Location = new System.Drawing.Point(280, 12);
            this.tableSelecter.Name = "tableSelecter";
            this.tableSelecter.Size = new System.Drawing.Size(121, 21);
            this.tableSelecter.TabIndex = 3;
            this.tableSelecter.TextChanged += new System.EventHandler(tableSelecter_Select);
            // 
            // label2
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(214, 15);
            this.fromLabel.Name = "table select label";
            this.fromLabel.Size = new System.Drawing.Size(60, 13);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "From Table";
            // 
            // button1
            // 
            this.buttonRepairFault.Location = new System.Drawing.Point(433, 10);
            this.buttonRepairFault.Name = "Initiate Repair Button";
            this.buttonRepairFault.Size = new System.Drawing.Size(99, 23);
            this.buttonRepairFault.TabIndex = 5;
            this.buttonRepairFault.Text = "Repair Fault";
            this.buttonRepairFault.Click += new System.EventHandler(buttonRepairFault_Click);
            this.buttonRepairFault.UseVisualStyleBackColor = true;
            // 
            // MakeRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 303);
            this.Controls.Add(this.buttonRepairFault);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.tableSelecter);
            this.Controls.Add(this.faultViewer);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.faultNumberEntry);
            this.Name = "MakeRepairForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.MakeRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faultViewerSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private s7110008DataSet dataSet;
        private System.Windows.Forms.TextBox faultNumberEntry;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.DataGridView faultViewer;
        private System.Windows.Forms.ComboBox tableSelecter;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button buttonRepairFault;
        private System.Windows.Forms.BindingSource faultViewerSource;
        private s7110008DataSetTableAdapters.MechFaultTableAdapter mechFaultAdapter;
        private s7110008DataSetTableAdapters.OtherFaultTableAdapter otherFaultAdapter;
        private s7110008DataSetTableAdapters.ElectFaultTableAdapter electFaultAdapter;
        private s7110008DataSetTableAdapters.RepairsMFTableAdapter repairsMFTableAdapter;
        private s7110008DataSetTableAdapters.RepairsOFTableAdapter repairsOFTableAdapter;
        private s7110008DataSetTableAdapters.RepairsEFTableAdapter repairsEFTableAdapter;
    }
}