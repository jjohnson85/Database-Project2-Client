﻿using System;
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
    public partial class FaultMangmentForm : Form
    {

        private string select;
        public FaultMangmentForm()
        {
            InitializeComponent();
        }
        
        
        //Save
        private void button1_Click(object sender, EventArgs e)
        {
            //Get text from combo box to use in swictch to select table to display
            select = comboBox1.Text;
            switch (select)
            {
                case "Mechanical Fault":
                    this.Validate();
                    this.bindingSource2.EndEdit();
                    this.mechFaultTableAdapter.Update(this.s7110008DataSet.MechFault);
                    break;
                case "Electrical Fault":
                    this.Validate();
                    this.bindingSource3.EndEdit();
                    this.electFaultTableAdapter.Update(this.s7110008DataSet.ElectFault);
                    break;
                case "Other Fault":
                    this.Validate();
                    this.bindingSource1.EndEdit();
                    this.otherFaultTableAdapter.Update(this.s7110008DataSet.OtherFault);
                    break;
                default:
                    break;
            }
        }

        //Delete
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FaultMangmentForm_Load(object sender, EventArgs e)
        {
            this.otherFaultTableAdapter.Fill(this.s7110008DataSet.OtherFault);
            this.mechFaultTableAdapter.Fill(this.s7110008DataSet.MechFault);
            this.electFaultTableAdapter.Fill(this.s7110008DataSet.ElectFault);
        }

        //Change fault-type table displayed
        private void button3_Click(object sender, EventArgs e)
        {
            select = comboBox1.Text;
            switch (select)
            {
                case "Mechanical Fault":
                    this.dataGridView1.DataSource = this.bindingSource2;
                    break;
                case "Electrical Fault":
                    this.dataGridView1.DataSource = this.bindingSource3;
                    break;
                case "Other Fault":
                    this.dataGridView1.DataSource = this.bindingSource1;
                    break;
                default:
                    break;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
