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
    public partial class CMangamentForm : Form
    {
        public CMangamentForm()
        {
            InitializeComponent();
        }

        private void CMangamentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7110008DataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.s7110008DataSet.Company);

        }

        //Save -- Must save after delete to commit change to DB
        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.companyTableAdapter.Update(this.s7110008DataSet.Company);
        }

        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.RemoveCurrent();
        }
    }
}
