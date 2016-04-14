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
        private string engNum;
        public EngManagementForm()
        {
            InitializeComponent();
        }

        private void EngManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7110008DataSet.AllRepairs' table. You can move, or remove it, as needed.
            this.allRepairsTableAdapter.Fill(this.s7110008DataSet.AllRepairs);
            // TODO: This line of code loads data into the 's7110008DataSet.Engineer' table. You can move, or remove it, as needed.
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);
            // TODO: This line of code loads data into the 's7110008DataSet.AllRepairs' table. You can move, or remove it, as needed.
            this.allRepairsTableAdapter.Fill(this.s7110008DataSet.AllRepairs);
            //Fill table adapters
            this.repairsOFTableAdapter.Fill(this.s7110008DataSet.RepairsOF);
            this.repairsMFTableAdapter.Fill(this.s7110008DataSet.RepairsMF);
            this.repairsEFTableAdapter.Fill(this.s7110008DataSet.RepairsEF);
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            select = comboBox2.Text;
            //Switch on select string taken form combo box2, used to select the type of repair to display
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
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.engNum = this.comboBox1.Text;
                this.allRepairsBindingSource.Filter = "engNo =" + engNum;
            }
            catch( Exception ex )
            {

            }
        }
    }
}
