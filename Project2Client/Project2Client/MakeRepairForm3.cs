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

        public MakeRepairForm2()
        {
            InitializeComponent();
            this.engNo = 0;
            this.Text = "An Engineer is repairing a fault";
        }

        public MakeRepairForm2(int EngNo)
        {
            //Make a form with fancy title dependent on caller.
            InitializeComponent();
            this.engNo = EngNo;
            this.Text = "Engineer " + EngNo.ToString() + " is repairing fault ";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Do all the necessary initialization stuff;
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
                //Display Electrical Fault table
                case "Electrical":
                    this.faultViewerSource.DataMember = "ElectFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultID.DisplayMember = "eFaultID";
                    this.faultID.DataSource = this.faultViewerSource;
                    this.faultViewer.DataSource = this.faultViewerSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                //Display Mechanical Fault table
                case "Mechanical":
                    this.faultViewerSource.DataMember = "MechFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultID.DisplayMember = "mFaultID";
                    this.faultID.DataSource = this.faultViewerSource;
                    this.faultViewer.DataSource = this.faultViewerSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                //Display Other Fault table
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
            //Prevent non digits from being entered;
            int old = hours;

            if (hoursRepairing.Text.Length > 0 && !Int32.TryParse(hoursRepairing.Text, out hours))
            {
                if (old == 0)
                    this.hoursRepairing.Text = "";
                else
                {
                    this.hoursRepairing.Text = old.ToString();
                    this.hoursRepairing.SelectionStart = this.hoursRepairing.Text.Length;
                    this.hoursRepairing.SelectionLength = 0;
                    this.hours = old;
                }
            }
            else
            {
                old = 0;
            }
        }

        private void commitRepair_Click(object sender, EventArgs e)
        {
            validate_Date();
            //Validate hours
            if (this.hours == -1)
                MessageBox.Show("Enter number of hours worked.");
            else
            {
                //Commit repair
                Int32.TryParse(this.faultID.Text,out fault);
                switch( tableName.Text )
                {
                    case "Mechanical":
                        if ((this.dataSet.RepairsMF.Select("faultID = " + fault.ToString())).Length == 0)
                        {
                            this.dataSet.RepairsMF.Rows.Add(engNo, date, hours, fault);
                            this.RepairsMFTableAdapter.Update(this.dataSet.RepairsMF);
                            MessageBox.Show("Successful Update");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update Unsuccessful: Mechanical Fault#" + fault.ToString() + " has already been repaired.");
                        }
                        break;
                    case "Electrical":
                        if (this.dataSet.RepairsEF.Select("faultID = " + fault.ToString()).Length == 0)
                        {
                            this.dataSet.RepairsEF.Rows.Add(engNo, date, hours, fault);
                            this.RepairsEFTableAdapter.Update(this.dataSet.RepairsEF);
                            MessageBox.Show("Successful Update");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update Unsuccessful: Electrical Fault#" + fault.ToString() + " has already been repaired.");
                        }
                        break;
                    case "Other":
                        if (this.dataSet.RepairsOF.Select("faultID = " + fault.ToString()).Length == 0)
                        {
                            this.dataSet.RepairsOF.Rows.Add(engNo, date, hours, fault);
                            this.RepairsOFTableAdapter.Update(this.dataSet.RepairsOF);
                            MessageBox.Show("Successful Update");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update Unsuccessful: Other Fault#" + fault.ToString() + " has already been repaired.");
                        }
                        break;
                }
            }
                
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            validate_Date();
        }

        private void validate_Date()
        {
            //Check date for proper formatting
            Regex fmt = new Regex("\\d\\d/\\d\\d/\\d\\d\\d\\d\\w*");
            string test = textBox1.Text;
            if (fmt.IsMatch(test))
                date = test;
            else
            {
                textBox1.Text = "mm/dd/yyyy";
                this.textBox1.Focus();
                this.textBox1.SelectionStart = 0;
                this.textBox1.SelectionLength = this.textBox1.Text.Length;
            }
        }
    }
}