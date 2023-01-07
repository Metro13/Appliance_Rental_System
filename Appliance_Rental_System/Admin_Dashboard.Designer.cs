namespace Appliance_Rental_System
{
    partial class Admin_Dashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddAppliance = new System.Windows.Forms.Button();
            this.CmdViewRentals = new System.Windows.Forms.Button();
            this.CmdManageAppliances = new System.Windows.Forms.Button();
            this.CmdViewCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose the Task you want to do today";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dashboard";
            // 
            // cmdAddAppliance
            // 
            this.cmdAddAppliance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAddAppliance.Location = new System.Drawing.Point(64, 141);
            this.cmdAddAppliance.Name = "cmdAddAppliance";
            this.cmdAddAppliance.Size = new System.Drawing.Size(128, 67);
            this.cmdAddAppliance.TabIndex = 11;
            this.cmdAddAppliance.Text = "Add Appliances";
            this.cmdAddAppliance.UseVisualStyleBackColor = true;
            // 
            // CmdViewRentals
            // 
            this.CmdViewRentals.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdViewRentals.Location = new System.Drawing.Point(225, 141);
            this.CmdViewRentals.Name = "CmdViewRentals";
            this.CmdViewRentals.Size = new System.Drawing.Size(128, 67);
            this.CmdViewRentals.TabIndex = 13;
            this.CmdViewRentals.Text = "View Rentals";
            this.CmdViewRentals.UseVisualStyleBackColor = true;
            // 
            // CmdManageAppliances
            // 
            this.CmdManageAppliances.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdManageAppliances.Location = new System.Drawing.Point(64, 228);
            this.CmdManageAppliances.Name = "CmdManageAppliances";
            this.CmdManageAppliances.Size = new System.Drawing.Size(128, 67);
            this.CmdManageAppliances.TabIndex = 14;
            this.CmdManageAppliances.Text = "Manage Appliances";
            this.CmdManageAppliances.UseVisualStyleBackColor = true;
            // 
            // CmdViewCustomers
            // 
            this.CmdViewCustomers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdViewCustomers.Location = new System.Drawing.Point(225, 228);
            this.CmdViewCustomers.Name = "CmdViewCustomers";
            this.CmdViewCustomers.Size = new System.Drawing.Size(128, 67);
            this.CmdViewCustomers.TabIndex = 15;
            this.CmdViewCustomers.Text = "View Customers";
            this.CmdViewCustomers.UseVisualStyleBackColor = true;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 385);
            this.Controls.Add(this.CmdViewCustomers);
            this.Controls.Add(this.CmdManageAppliances);
            this.Controls.Add(this.CmdViewRentals);
            this.Controls.Add(this.cmdAddAppliance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label1;
        private Button cmdAddAppliance;
        private Button CmdViewRentals;
        private Button CmdManageAppliances;
        private Button CmdViewCustomers;
    }
}