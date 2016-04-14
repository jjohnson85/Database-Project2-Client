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
    public partial class EngManagementForm : Form
    {
        private string select;
        private int engNum;

        public EngManagementForm()
        {
            InitializeComponent();
        }

        private void EngManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7110008DataSet1.RepairsOF' table. You can move, or remove it, as needed.
            this.repairsOFTableAdapter.Fill(this.s7110008DataSet1.RepairsOF);
            // TODO: This line of code loads data into the 's7110008DataSet1.RepairsMF' table. You can move, or remove it, as needed.
            this.repairsMFTableAdapter.Fill(this.s7110008DataSet1.RepairsMF);
            // TODO: This line of code loads data into the 's7110008DataSet.Engineer' table. You can move, or remove it, as needed.
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);
            // TODO: This line of code loads data into the 's7110008DataSet.RepairsEF' table. You can move, or remove it, as needed.
            this.repairsEFTableAdapter.Fill(this.s7110008DataSet.RepairsEF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = comboBox2.Text;
            switch (select)
            {
                case "Mechanical Repairs":
                    this.dataGridView1.DataSource = this.repairsMFBindingSource;
                    break;
                case "Electrical Repairs":
                    this.dataGridView1.DataSource = this.repairsEFBindingSource;
                    break;
                case "Other Repairs":
                    this.dataGridView1.DataSource = this.repairsOFBindingSource;
                    break;
                default:
                    break;
            }
        }
    }
}
