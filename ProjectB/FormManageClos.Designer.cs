namespace ProjectB
{
    partial class FormManageClos
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoBackToMain = new System.Windows.Forms.Button();
            this.buttonFormManageClos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnEditClo = new System.Windows.Forms.Button();
            this.btnDeleteClo = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddClo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 122);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 57);
            this.panelLeft.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnGoBackToMain);
            this.panel1.Controls.Add(this.buttonFormManageClos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 425);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGoBackToMain
            // 
            this.btnGoBackToMain.FlatAppearance.BorderSize = 0;
            this.btnGoBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToMain.Location = new System.Drawing.Point(3, 185);
            this.btnGoBackToMain.Name = "btnGoBackToMain";
            this.btnGoBackToMain.Size = new System.Drawing.Size(160, 71);
            this.btnGoBackToMain.TabIndex = 1;
            this.btnGoBackToMain.Text = "Go Back To Main Form";
            this.btnGoBackToMain.UseVisualStyleBackColor = true;
            this.btnGoBackToMain.Click += new System.EventHandler(this.btnGoBackToMain_Click);
            // 
            // buttonFormManageClos
            // 
            this.buttonFormManageClos.FlatAppearance.BorderSize = 0;
            this.buttonFormManageClos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormManageClos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormManageClos.ForeColor = System.Drawing.Color.White;
            this.buttonFormManageClos.Location = new System.Drawing.Point(3, 116);
            this.buttonFormManageClos.Name = "buttonFormManageClos";
            this.buttonFormManageClos.Size = new System.Drawing.Size(160, 63);
            this.buttonFormManageClos.TabIndex = 1;
            this.buttonFormManageClos.Text = "Manage CLO\'s Form";
            this.buttonFormManageClos.UseVisualStyleBackColor = true;
            this.buttonFormManageClos.Click += new System.EventHandler(this.buttonFormManageClos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.labelHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 82);
            this.panel3.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(-4, 6);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(174, 57);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "projectB";
            // 
            // btnEditClo
            // 
            this.btnEditClo.FlatAppearance.BorderSize = 0;
            this.btnEditClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClo.ForeColor = System.Drawing.Color.White;
            this.btnEditClo.Location = new System.Drawing.Point(281, 11);
            this.btnEditClo.Name = "btnEditClo";
            this.btnEditClo.Size = new System.Drawing.Size(146, 31);
            this.btnEditClo.TabIndex = 32;
            this.btnEditClo.Text = "Edit CLO";
            this.btnEditClo.UseVisualStyleBackColor = true;
            this.btnEditClo.Click += new System.EventHandler(this.btnEditClo_Click);
            // 
            // btnDeleteClo
            // 
            this.btnDeleteClo.FlatAppearance.BorderSize = 0;
            this.btnDeleteClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClo.Location = new System.Drawing.Point(442, 9);
            this.btnDeleteClo.Name = "btnDeleteClo";
            this.btnDeleteClo.Size = new System.Drawing.Size(137, 32);
            this.btnDeleteClo.TabIndex = 31;
            this.btnDeleteClo.Text = "Delete CLO";
            this.btnDeleteClo.UseVisualStyleBackColor = true;
            this.btnDeleteClo.Click += new System.EventHandler(this.btnDeleteClo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(36, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 21);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name Of The CLO";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 27);
            this.txtName.TabIndex = 20;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // btnAddClo
            // 
            this.btnAddClo.FlatAppearance.BorderSize = 0;
            this.btnAddClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClo.ForeColor = System.Drawing.Color.White;
            this.btnAddClo.Location = new System.Drawing.Point(386, 83);
            this.btnAddClo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddClo.Name = "btnAddClo";
            this.btnAddClo.Size = new System.Drawing.Size(137, 33);
            this.btnAddClo.TabIndex = 29;
            this.btnAddClo.Text = "Add CLO";
            this.btnAddClo.UseVisualStyleBackColor = true;
            this.btnAddClo.Click += new System.EventHandler(this.btnAddClo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 163);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.btnAddClo);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 121);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel4.Controls.Add(this.btnEditClo);
            this.panel4.Controls.Add(this.btnDeleteClo);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(166, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 241);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel5.Location = new System.Drawing.Point(177, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 69);
            this.panel5.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(3, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 10);
            this.panel6.TabIndex = 0;
            // 
            // FormManageClos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(760, 425);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormManageClos";
            this.Text = "FormManageClos";
            this.Load += new System.EventHandler(this.FormManageClos_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFormManageClos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnGoBackToMain;
        private System.Windows.Forms.Button btnEditClo;
        private System.Windows.Forms.Button btnDeleteClo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddClo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
    }
}