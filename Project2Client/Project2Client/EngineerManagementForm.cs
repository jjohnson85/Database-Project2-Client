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
    public partial class EngineerManagementForm : Form
    {
        public EngineerManagementForm()
        {
            InitializeComponent();
        }

        private void EngineerManagementForm_Load(object sender, EventArgs e)
        {
            //Fill table adapter
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Save by ending edit and updating tables
            this.Validate();
            this.engineerBindingSource.EndEdit();
            this.engineerTableAdapter.Update(this.s7110008DataSet.Engineer);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Delete by removing currently selected row from table/binding source
            //Must save to commit this change
            this.Validate();
            this.engineerBindingSource.RemoveCurrent();
        }
    }
}
