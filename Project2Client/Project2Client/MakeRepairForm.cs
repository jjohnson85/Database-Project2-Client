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
    public partial class MakeRepairForm : Form
    {
        private int EngNo;
        public MakeRepairForm()
        {
            InitializeComponent(0);
        }

        public MakeRepairForm(int engNo)
        {
            EngNo = engNo;
            InitializeComponent(engNo);
        }

        private void MakeRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRepairFault_Click(object sender, EventArgs e)
        {

        }

        private void tableSelecter_Select(object sender, EventArgs e)
        {
            switch( tableSelecter.Text )
            {
                case "Electrical Faults": 
                    this.faultViewerSource.DataMember = "ElectFault";
                    this.faultViewer.Update();
                    break;
                case "Mechanical Faults": 
                    this.faultViewerSource.DataMember = "MechFault";
                    this.faultViewer.Update();
                    break;
                case "Other Faults":
                    this.faultViewerSource.DataMember = "OtherFault";
                    this.faultViewer.Update();
                    break;
            }
        }


    }
}
