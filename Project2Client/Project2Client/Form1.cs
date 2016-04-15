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
    public partial class InitEntryForm : Form
    {
        public InitEntryForm()
        {
            InitializeComponent();
        }


        private void CManageButton_Click(object sender, EventArgs e)
        {
            CMangamentForm CForm = new CMangamentForm();
            CForm.ShowDialog();
        }

        private void EngManageButton_Click(object sender, EventArgs e)
        {
            RepairsManagementForm EForm = new RepairsManagementForm();
            EForm.ShowDialog();
        }

        private void FManageButton_Click(object sender, EventArgs e)
        {
            FaultMangmentForm FForm = new FaultMangmentForm();
            FForm.ShowDialog();
        }

        private void EquipManageButton_Click(object sender, EventArgs e)
        {
            EquipManagmentForm EQForm = new EquipManagmentForm();
            EQForm.ShowDialog();
        }
    }
}
