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
            this.components = new System.ComponentModel.Container();
            this.dataSet.DataSetName = "s7110008DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.faultIDSource = new BindingSource(this.components);
            this.faultViewerSource = new BindingSource(this.components);
            this.faultViewer.DataSource = this.faultViewerSource;
            this.faultViewerSource.DataSource = this.dataSet;
        }

        private void tableName_TextUpdate(object sender, EventArgs e)
        {
            switch( tableName.Text )
            {
                case "Electrical":
                    this.faultViewerSource.DataMember = "electFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultIDSource.DataMember = "eFaultID";
                    this.faultID.DataSource = faultIDSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                case "Mechanical":
                    this.faultViewerSource.DataMember = "mechFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultIDSource.DataMember = "mFaultID";
                    this.faultID.DataSource = faultIDSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
                case "Other":
                    this.faultViewerSource.DataMember = "otherFault";
                    this.faultIDSource.DataSource = this.faultViewerSource;
                    this.faultIDSource.DataMember = "oFaultID";
                    this.faultID.DataSource = faultIDSource;
                    this.faultID.Update();
                    this.faultViewer.Update();
                    break;
            }
        }

        private void hoursRepairing_TextChanged(object sender, EventArgs e)
        {
            if( !Int32.TryParse(hoursRepairing.Text,out hours) )
            {
                this.hoursRepairing.Text = "<type integer>";
            }
            this.hours = -1;
        }
    }
}
