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
            // TODO: This line of code loads data into the 's7110008DataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.s7110008DataSet.Equipment);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.equipmentTableAdapter.Update(this.s7110008DataSet.Equipment);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.RemoveCurrent();
        }
    }
}
