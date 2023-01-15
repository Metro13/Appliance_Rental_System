namespace Appliance_Rental_System
{
    partial class Manage_Appliances
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manageAppliancePanel = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.TxtMonthlyFee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtEnergyConsumption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDimensions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtApplianceType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGetBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.manageAppliancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(668, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Edit/ Update and Delete Appliances";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Appliances";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Appliance_Rental_System.User);
            // 
            // manageAppliancePanel
            // 
            this.manageAppliancePanel.Controls.Add(this.cmdBack);
            this.manageAppliancePanel.Controls.Add(this.CmdDelete);
            this.manageAppliancePanel.Controls.Add(this.cmdUpdate);
            this.manageAppliancePanel.Controls.Add(this.TxtMonthlyFee);
            this.manageAppliancePanel.Controls.Add(this.label9);
            this.manageAppliancePanel.Controls.Add(this.TxtEnergyConsumption);
            this.manageAppliancePanel.Controls.Add(this.label5);
            this.manageAppliancePanel.Controls.Add(this.TxtColor);
            this.manageAppliancePanel.Controls.Add(this.label10);
            this.manageAppliancePanel.Controls.Add(this.label8);
            this.manageAppliancePanel.Controls.Add(this.TxtDimensions);
            this.manageAppliancePanel.Controls.Add(this.label7);
            this.manageAppliancePanel.Controls.Add(this.TxtApplianceType);
            this.manageAppliancePanel.Controls.Add(this.label6);
            this.manageAppliancePanel.Controls.Add(this.TxtBrand);
            this.manageAppliancePanel.Controls.Add(this.label2);
            this.manageAppliancePanel.Controls.Add(this.TxtModel);
            this.manageAppliancePanel.Controls.Add(this.label4);
            this.manageAppliancePanel.Location = new System.Drawing.Point(12, 81);
            this.manageAppliancePanel.Name = "manageAppliancePanel";
            this.manageAppliancePanel.Size = new System.Drawing.Size(668, 336);
            this.manageAppliancePanel.TabIndex = 13;
            // 
            // cmdBack
            // 
            this.cmdBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdBack.Location = new System.Drawing.Point(558, 18);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(94, 32);
            this.cmdBack.TabIndex = 52;
            this.cmdBack.Text = "Exit";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackColor = System.Drawing.Color.Red;
            this.CmdDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CmdDelete.Location = new System.Drawing.Point(403, 272);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(92, 43);
            this.CmdDelete.TabIndex = 51;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = false;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdUpdate.Location = new System.Drawing.Point(292, 272);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(94, 43);
            this.cmdUpdate.TabIndex = 50;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // TxtMonthlyFee
            // 
            this.TxtMonthlyFee.Location = new System.Drawing.Point(292, 222);
            this.TxtMonthlyFee.Multiline = true;
            this.TxtMonthlyFee.Name = "TxtMonthlyFee";
            this.TxtMonthlyFee.Size = new System.Drawing.Size(226, 32);
            this.TxtMonthlyFee.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(292, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Monthly Fee";
            // 
            // TxtEnergyConsumption
            // 
            this.TxtEnergyConsumption.Location = new System.Drawing.Point(292, 160);
            this.TxtEnergyConsumption.Multiline = true;
            this.TxtEnergyConsumption.Name = "TxtEnergyConsumption";
            this.TxtEnergyConsumption.Size = new System.Drawing.Size(226, 32);
            this.TxtEnergyConsumption.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(292, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Energy Consumption/Hr";
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(292, 96);
            this.TxtColor.Multiline = true;
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(226, 32);
            this.TxtColor.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(292, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Dimensions";
            // 
            // TxtDimensions
            // 
            this.TxtDimensions.Location = new System.Drawing.Point(15, 283);
            this.TxtDimensions.Multiline = true;
            this.TxtDimensions.Name = "TxtDimensions";
            this.TxtDimensions.Size = new System.Drawing.Size(226, 32);
            this.TxtDimensions.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Appliance Type";
            // 
            // TxtApplianceType
            // 
            this.TxtApplianceType.Location = new System.Drawing.Point(15, 221);
            this.TxtApplianceType.Multiline = true;
            this.TxtApplianceType.Name = "TxtApplianceType";
            this.TxtApplianceType.Size = new System.Drawing.Size(226, 32);
            this.TxtApplianceType.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Brand";
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(15, 156);
            this.TxtBrand.Multiline = true;
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(226, 32);
            this.TxtBrand.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Model";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(15, 96);
            this.TxtModel.Multiline = true;
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(226, 32);
            this.TxtModel.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Enter Appliance details";
            // 
            // cmdGetBack
            // 
            this.cmdGetBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGetBack.Location = new System.Drawing.Point(13, 26);
            this.cmdGetBack.Name = "cmdGetBack";
            this.cmdGetBack.Size = new System.Drawing.Size(94, 32);
            this.cmdGetBack.TabIndex = 53;
            this.cmdGetBack.Text = "Back";
            this.cmdGetBack.UseVisualStyleBackColor = true;
            this.cmdGetBack.Click += new System.EventHandler(this.cmdGetBack_Click);
            // 
            // Manage_Appliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 429);
            this.Controls.Add(this.cmdGetBack);
            this.Controls.Add(this.manageAppliancePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manage_Appliances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Appliances";
            this.Load += new System.EventHandler(this.Manage_Appliances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.manageAppliancePanel.ResumeLayout(false);
            this.manageAppliancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private Label label1;
        private BindingSource userBindingSource;
        private Panel manageAppliancePanel;
        private Label label6;
        private TextBox TxtBrand;
        private Label label2;
        private TextBox TxtModel;
        private Label label4;
        private Label label8;
        private TextBox TxtDimensions;
        private Label label7;
        private TextBox TxtApplianceType;
        private Button CmdDelete;
        private Button cmdUpdate;
        private TextBox TxtMonthlyFee;
        private Label label9;
        private TextBox TxtEnergyConsumption;
        private Label label5;
        private TextBox TxtColor;
        private Label label10;
        private Button cmdBack;
        private Button cmdGetBack;
    }
}