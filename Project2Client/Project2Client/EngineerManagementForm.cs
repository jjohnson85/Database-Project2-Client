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
            // TODO: This line of code loads data into the 's7110008DataSet.Engineer' table. You can move, or remove it, as needed.
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.engineerBindingSource.EndEdit();
            this.engineerTableAdapter.Update(this.s7110008DataSet.Engineer);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.engineerBindingSource.RemoveCurrent();
        }
    }
}
