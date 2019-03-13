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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFormManageClos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToMain = new System.Windows.Forms.Button();
            this.btnEditClo = new System.Windows.Forms.Button();
            this.btnDeleteClo = new System.Windows.Forms.Button();
            this.lblDateUpdated = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddClo = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 101);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 51);
            this.panelLeft.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGoBackToMain);
            this.panel1.Controls.Add(this.buttonFormManageClos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 514);
            this.panel1.TabIndex = 6;
            // 
            // buttonFormManageClos
            // 
            this.buttonFormManageClos.FlatAppearance.BorderSize = 0;
            this.buttonFormManageClos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormManageClos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormManageClos.ForeColor = System.Drawing.Color.White;
            this.buttonFormManageClos.Location = new System.Drawing.Point(3, 101);
            this.buttonFormManageClos.Name = "buttonFormManageClos";
            this.buttonFormManageClos.Size = new System.Drawing.Size(160, 63);
            this.buttonFormManageClos.TabIndex = 1;
            this.buttonFormManageClos.Text = "Manage CLO\'s Form";
            this.buttonFormManageClos.UseVisualStyleBackColor = true;
            this.buttonFormManageClos.Click += new System.EventHandler(this.buttonFormManageClos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.labelHeader.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(42, -13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(63, 79);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "p";
            // 
            // btnGoBackToMain
            // 
            this.btnGoBackToMain.FlatAppearance.BorderSize = 0;
            this.btnGoBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToMain.Location = new System.Drawing.Point(3, 179);
            this.btnGoBackToMain.Name = "btnGoBackToMain";
            this.btnGoBackToMain.Size = new System.Drawing.Size(160, 71);
            this.btnGoBackToMain.TabIndex = 1;
            this.btnGoBackToMain.Text = "Go Back To Main Form";
            this.btnGoBackToMain.UseVisualStyleBackColor = true;
            this.btnGoBackToMain.Click += new System.EventHandler(this.btnGoBackToMain_Click);
            // 
            // btnEditClo
            // 
            this.btnEditClo.FlatAppearance.BorderSize = 0;
            this.btnEditClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClo.ForeColor = System.Drawing.Color.White;
            this.btnEditClo.Location = new System.Drawing.Point(477, 280);
            this.btnEditClo.Name = "btnEditClo";
            this.btnEditClo.Size = new System.Drawing.Size(146, 31);
            this.btnEditClo.TabIndex = 32;
            this.btnEditClo.Text = "Edit CLO";
            this.btnEditClo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClo
            // 
            this.btnDeleteClo.FlatAppearance.BorderSize = 0;
            this.btnDeleteClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClo.Location = new System.Drawing.Point(638, 278);
            this.btnDeleteClo.Name = "btnDeleteClo";
            this.btnDeleteClo.Size = new System.Drawing.Size(137, 32);
            this.btnDeleteClo.TabIndex = 31;
            this.btnDeleteClo.Text = "Delete CLO";
            this.btnDeleteClo.UseVisualStyleBackColor = true;
            // 
            // lblDateUpdated
            // 
            this.lblDateUpdated.AutoSize = true;
            this.lblDateUpdated.ForeColor = System.Drawing.Color.White;
            this.lblDateUpdated.Location = new System.Drawing.Point(236, 129);
            this.lblDateUpdated.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateUpdated.Name = "lblDateUpdated";
            this.lblDateUpdated.Size = new System.Drawing.Size(126, 21);
            this.lblDateUpdated.TabIndex = 23;
            this.lblDateUpdated.Text = "Date Updated";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.ForeColor = System.Drawing.Color.White;
            this.lblDateCreated.Location = new System.Drawing.Point(236, 94);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(121, 21);
            this.lblDateCreated.TabIndex = 21;
            this.lblDateCreated.Text = "Date Created";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(236, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(436, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 27);
            this.txtName.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 183);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnAddClo
            // 
            this.btnAddClo.FlatAppearance.BorderSize = 0;
            this.btnAddClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClo.ForeColor = System.Drawing.Color.White;
            this.btnAddClo.Location = new System.Drawing.Point(611, 170);
            this.btnAddClo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddClo.Name = "btnAddClo";
            this.btnAddClo.Size = new System.Drawing.Size(137, 33);
            this.btnAddClo.TabIndex = 29;
            this.btnAddClo.Text = "Add CLO";
            this.btnAddClo.UseVisualStyleBackColor = true;
            this.btnAddClo.Click += new System.EventHandler(this.btnAddClo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 27);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(436, 125);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(286, 27);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // FormManageClos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEditClo);
            this.Controls.Add(this.btnDeleteClo);
            this.Controls.Add(this.lblDateUpdated);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddClo);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormManageClos";
            this.Text = "FormManageClos";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblDateUpdated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddClo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}