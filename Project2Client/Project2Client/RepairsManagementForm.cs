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
    public partial class RepairsManagementForm : Form
    {
        private int engNum;

        public RepairsManagementForm()
        {
            InitializeComponent();
        }

        private void EngManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7110008DataSet.AllRepairs' table. You can move, or remove it, as needed.
            this.allRepairsTableAdapter.Fill(this.s7110008DataSet.AllRepairs);
            this.engineerTableAdapter.Fill(this.s7110008DataSet.Engineer);

            try
            {
                allRepairsBindingSource.Filter = "engNo =" + comboBox1.Text;
            }
            catch (Exception ex)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MakeRepair_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.Text, out engNum))
            {
                MakeRepairForm Repairer = new MakeRepairForm(engNum);
                Repairer.ShowDialog();
            }
            else
            {
                comboBox1.Text = "Bad Value";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                allRepairsBindingSource.Filter = "engNo =" + comboBox1.Text;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
