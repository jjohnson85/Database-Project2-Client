namespace Project2Client
{
    partial class InitEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CManageButton = new System.Windows.Forms.Button();
            this.RepairsManageButton = new System.Windows.Forms.Button();
            this.FManageButton = new System.Windows.Forms.Button();
            this.EquipManageButton = new System.Windows.Forms.Button();
            this.EngManagmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CManageButton
            // 
            this.CManageButton.Location = new System.Drawing.Point(64, 51);
            this.CManageButton.Name = "CManageButton";
            this.CManageButton.Size = new System.Drawing.Size(152, 53);
            this.CManageButton.TabIndex = 0;
            this.CManageButton.Text = "Company Management";
            this.CManageButton.UseVisualStyleBackColor = true;
            this.CManageButton.Click += new System.EventHandler(this.CManageButton_Click);
            // 
            // RepairsManageButton
            // 
            this.RepairsManageButton.Location = new System.Drawing.Point(63, 110);
            this.RepairsManageButton.Name = "RepairsManageButton";
            this.RepairsManageButton.Size = new System.Drawing.Size(152, 53);
            this.RepairsManageButton.TabIndex = 1;
            this.RepairsManageButton.Text = "Repairs Management";
            this.RepairsManageButton.UseVisualStyleBackColor = true;
            this.RepairsManageButton.Click += new System.EventHandler(this.EngManageButton_Click);
            // 
            // FManageButton
            // 
            this.FManageButton.Location = new System.Drawing.Point(64, 169);
            this.FManageButton.Name = "FManageButton";
            this.FManageButton.Size = new System.Drawing.Size(152, 53);
            this.FManageButton.TabIndex = 2;
            this.FManageButton.Text = "Fault Management";
            this.FManageButton.UseVisualStyleBackColor = true;
            this.FManageButton.Click += new System.EventHandler(this.FManageButton_Click);
            // 
            // EquipManageButton
            // 
            this.EquipManageButton.Location = new System.Drawing.Point(63, 287);
            this.EquipManageButton.Name = "EquipManageButton";
            this.EquipManageButton.Size = new System.Drawing.Size(152, 53);
            this.EquipManageButton.TabIndex = 3;
            this.EquipManageButton.Text = "Equipment Management";
            this.EquipManageButton.UseVisualStyleBackColor = true;
            this.EquipManageButton.Click += new System.EventHandler(this.EquipManageButton_Click);
            // 
            // EngManagmentButton
            // 
            this.EngManagmentButton.Location = new System.Drawing.Point(63, 228);
            this.EngManagmentButton.Name = "EngManagmentButton";
            this.EngManagmentButton.Size = new System.Drawing.Size(152, 53);
            this.EngManagmentButton.TabIndex = 4;
            this.EngManagmentButton.Text = "Engineer Management";
            this.EngManagmentButton.UseVisualStyleBackColor = true;
            this.EngManagmentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InitEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 365);
            this.Controls.Add(this.EngManagmentButton);
            this.Controls.Add(this.EquipManageButton);
            this.Controls.Add(this.FManageButton);
            this.Controls.Add(this.RepairsManageButton);
            this.Controls.Add(this.CManageButton);
            this.Name = "InitEntryForm";
            this.Text = "Select Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CManageButton;
        private System.Windows.Forms.Button RepairsManageButton;
        private System.Windows.Forms.Button FManageButton;
        private System.Windows.Forms.Button EquipManageButton;
        private System.Windows.Forms.Button EngManagmentButton;
    }
}

