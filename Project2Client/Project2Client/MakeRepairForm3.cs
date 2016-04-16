using System;
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
        private int hours;
        private int engNo;

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
                this.hoursRepairing.Text = "<type integer>";
            }
            this.hours = -1;
        }
    }
}