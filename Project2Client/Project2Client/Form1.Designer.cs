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
            this.EngManageButton = new System.Windows.Forms.Button();
            this.FManageButton = new System.Windows.Forms.Button();
            this.EquipManageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CManageButton
            // 
            this.CManageButton.Location = new System.Drawing.Point(64, 51);
            this.CManageButton.Name = "CManageButton";
            this.CManageButton.Size = new System.Drawing.Size(152, 53);
            this.CManageButton.TabIndex = 0;
            this.CManageButton.Text = "Company Managment";
            this.CManageButton.UseVisualStyleBackColor = true;
            this.CManageButton.Click += new System.EventHandler(this.CManageButton_Click);
            // 
            // EngManageButton
            // 
            this.EngManageButton.Location = new System.Drawing.Point(63, 110);
            this.EngManageButton.Name = "EngManageButton";
            this.EngManageButton.Size = new System.Drawing.Size(152, 53);
            this.EngManageButton.TabIndex = 1;
            this.EngManageButton.Text = "Engineer Managment";
            this.EngManageButton.UseVisualStyleBackColor = true;
            this.EngManageButton.Click += new System.EventHandler(this.EngManageButton_Click);
            // 
            // FManageButton
            // 
            this.FManageButton.Location = new System.Drawing.Point(64, 169);
            this.FManageButton.Name = "FManageButton";
            this.FManageButton.Size = new System.Drawing.Size(152, 53);
            this.FManageButton.TabIndex = 2;
            this.FManageButton.Text = "Fault Managment";
            this.FManageButton.UseVisualStyleBackColor = true;
            this.FManageButton.Click += new System.EventHandler(this.FManageButton_Click);
            // 
            // EquipManageButton
            // 
            this.EquipManageButton.Location = new System.Drawing.Point(64, 228);
            this.EquipManageButton.Name = "EquipManageButton";
            this.EquipManageButton.Size = new System.Drawing.Size(152, 53);
            this.EquipManageButton.TabIndex = 3;
            this.EquipManageButton.Text = "Equipment Managment";
            this.EquipManageButton.UseVisualStyleBackColor = true;
            this.EquipManageButton.Click += new System.EventHandler(this.EquipManageButton_Click);
            // 
            // InitEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 328);
            this.Controls.Add(this.EquipManageButton);
            this.Controls.Add(this.FManageButton);
            this.Controls.Add(this.EngManageButton);
            this.Controls.Add(this.CManageButton);
            this.Name = "InitEntryForm";
            this.Text = "Select Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CManageButton;
        private System.Windows.Forms.Button EngManageButton;
        private System.Windows.Forms.Button FManageButton;
        private System.Windows.Forms.Button EquipManageButton;
    }
}

