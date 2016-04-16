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
    public partial class EquipManagmentForm : Form
    {
        public EquipManagmentForm()
        {
            InitializeComponent();
        }

        private void EquipManagmentForm_Load(object sender, EventArgs e)
        {
            //Fill table adapter
            this.equipmentTableAdapter.Fill(this.s7110008DataSet.Equipment);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Save by ending edit and updating equipment table adapter
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.equipmentTableAdapter.Update(this.s7110008DataSet.Equipment);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Delete currently selected row
            //Must save to commit delete
            this.Validate();
            this.equipmentBindingSource.RemoveCurrent();
        }
    }
}
