using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Client
{
    public partial class MakeRepairForm2 : Form
    {
        private string date;
        private int fault;
        private int hours;
        private int engNo;
        private DataTable data;

        public MakeRepairForm2()
        {
            InitializeComponent();
            this.engNo = 0;
            this.Text = "An Engineer is repairing a fault";
        }

        public MakeRepairForm2(int EngNo)
        {
            InitializeComponent();
            this.engNo = EngNo;
            this.Text = "Engineer " + EngNo.ToString() + " is repairing fault ";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.hours = -1;
            this.MechFaultTableAdapter = new s7110008DataSetTableAdapters.MechFaultTableAdapter();
            this.OtherFaultTableAdapter = new s7110008DataSetTableAdapters.OtherFaultTableAdapter();
            this.ElectFaultTableAdapter = new s7110008DataSetTableAdapters.ElectFaultTableAdapter();
            this.RepairsEFTableAdapter = new s7110008DataSetTableAdapters.RepairsEFTableAdapter();
            this.RepairsOFTableAdapter = new s7110008DataSetTableAdapters.RepairsOFTableAdapter();
            this.RepairsMFTableAdapter = new s7110008DataSetTableAdapters.RepairsMFTableAdapter();
            this.MechFaultTableAdapter.Fill(this.dataSet.MechFault);
            this.ElectFaultTableAdapter.Fill(this.dataSet.ElectFault);
            this.OtherFaultTableAdapter.Fill(this.dataSet.OtherFault);
            this.RepairsEFTableAdapter.Fill(this.dataSet.RepairsEF);
            this.RepairsMFTableAdapter.Fill(this.dataSet.RepairsMF);
            this.RepairsOFTableAdapter.Fill(this.dataSet.RepairsOF);
            this.components = new System.ComponentModel.Container();
            this.faultIDSource = new BindingSource(this.components);
            this.faultViewerSource = new BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.faultViewerSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultIDSource)).BeginInit();
            this.faultViewer.DataSource = this.faultViewerSource;
            this.faultViewerSource.DataSource = this.dataSet;
            ((System.ComponentModel.ISupportInitialize)(this.faultViewerSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultIDSource)).EndInit();
        }

        private void tableName_TextChange(object sender, EventArgs e)
        {
            switch (tableName.Text)
            {
                case "Electrical":
                    this.faultViewerSource.DataMember = "ElectFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultID.DisplayMember = "eFaultID";
                    this.faultID.DataSource = this.faultViewerSource;
                    this.faultViewer.DataSource = this.faultViewerSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                case "Mechanical":
                    this.faultViewerSource.DataMember = "MechFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultID.DisplayMember = "mFaultID";
                    this.faultID.DataSource = this.faultViewerSource;
                    this.faultViewer.DataSource = this.faultViewerSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                case "Other":
                    this.faultViewerSource.DataMember = "OtherFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultID.DisplayMember = "oFaultID";
                    this.faultID.DataSource = this.faultViewerSource;
                    this.faultViewer.DataSource = this.faultViewerSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
            }
        }

        private void hoursRepairing_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(hoursRepairing.Text, out hours))
            {
                this.hours = -1;
                this.hoursRepairing.Text = "";
            }
        }

        private void commitRepair_Click(object sender, EventArgs e)
        {
            if (this.hours == -1)
                MessageBox.Show("Enter number of hours worked.");
            else
            {
                Int32.TryParse(this.faultID.Text,out fault);
                switch( tableName.Text )
                {
                    case "Mechanical":
                        this.dataSet.RepairsMF.Rows.Add(engNo, date, hours, fault);
                        this.RepairsMFTableAdapter.Update(this.dataSet.RepairsMF);
                        break;
                    case "Electrical":
                        this.dataSet.RepairsEF.Rows.Add(engNo, date, hours, fault);
                        this.RepairsEFTableAdapter.Update(this.dataSet.RepairsEF);
                        break;
                    case "Other":
                        this.dataSet.RepairsOF.Rows.Add(engNo, date, hours, fault);
                        this.RepairsOFTableAdapter.Update(this.dataSet.RepairsOF);
                        break;
                }
                MessageBox.Show("Successful Update");
            }
                
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Regex fmt = new Regex("\\d\\d/\\d\\d/\\d\\d\\d\\d\\w*");
            string test = textBox1.Text;
            if (fmt.IsMatch(test))
                date = test;
            else
            {
                textBox1.Text = "mm/dd/yyyy";
                this.textBox1.Focus();
            }
        }
    }
}