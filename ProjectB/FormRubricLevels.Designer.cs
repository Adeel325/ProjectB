namespace ProjectB
{
    partial class FormRubricLevels
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
            this.btnAddClo = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRubricLevelForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToMainForm = new System.Windows.Forms.Button();
            this.lblRubricId = new System.Windows.Forms.Label();
            this.btnAddRubricLevel = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbRubricIds = new System.Windows.Forms.ComboBox();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClo
            // 
            this.btnAddClo.FlatAppearance.BorderSize = 0;
            this.btnAddClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClo.Location = new System.Drawing.Point(973, 357);
            this.btnAddClo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddClo.Name = "btnAddClo";
            this.btnAddClo.Size = new System.Drawing.Size(172, 57);
            this.btnAddClo.TabIndex = 20;
            this.btnAddClo.Text = "Add CLO";
            this.btnAddClo.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(167, 101);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 51);
            this.panelLeft.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(166, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 223);
            this.panel2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnRubricLevelForm);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGoBackToMainForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 514);
            this.panel1.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(-2, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 10);
            this.panel6.TabIndex = 6;
            // 
            // btnRubricLevelForm
            // 
            this.btnRubricLevelForm.FlatAppearance.BorderSize = 0;
            this.btnRubricLevelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubricLevelForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRubricLevelForm.ForeColor = System.Drawing.Color.White;
            this.btnRubricLevelForm.Location = new System.Drawing.Point(3, 101);
            this.btnRubricLevelForm.Name = "btnRubricLevelForm";
            this.btnRubricLevelForm.Size = new System.Drawing.Size(160, 46);
            this.btnRubricLevelForm.TabIndex = 1;
            this.btnRubricLevelForm.Text = "Rubric Levels Form";
            this.btnRubricLevelForm.UseVisualStyleBackColor = true;
            this.btnRubricLevelForm.Click += new System.EventHandler(this.btnRubricLevelForm_Click);
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
            this.labelHeader.Location = new System.Drawing.Point(-7, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(174, 57);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "projectB";
            // 
            // btnGoBackToMainForm
            // 
            this.btnGoBackToMainForm.FlatAppearance.BorderSize = 0;
            this.btnGoBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToMainForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToMainForm.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToMainForm.Location = new System.Drawing.Point(-3, 173);
            this.btnGoBackToMainForm.Name = "btnGoBackToMainForm";
            this.btnGoBackToMainForm.Size = new System.Drawing.Size(169, 49);
            this.btnGoBackToMainForm.TabIndex = 2;
            this.btnGoBackToMainForm.Text = "Go Back To Main Form";
            this.btnGoBackToMainForm.UseVisualStyleBackColor = true;
            this.btnGoBackToMainForm.Click += new System.EventHandler(this.btnGoBackToMainForm_Click);
            // 
            // lblRubricId
            // 
            this.lblRubricId.AutoSize = true;
            this.lblRubricId.Location = new System.Drawing.Point(102, 22);
            this.lblRubricId.Name = "lblRubricId";
            this.lblRubricId.Size = new System.Drawing.Size(80, 21);
            this.lblRubricId.TabIndex = 30;
            this.lblRubricId.Text = "Rubric ID";
            // 
            // btnAddRubricLevel
            // 
            this.btnAddRubricLevel.FlatAppearance.BorderSize = 0;
            this.btnAddRubricLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRubricLevel.Location = new System.Drawing.Point(379, 199);
            this.btnAddRubricLevel.Name = "btnAddRubricLevel";
            this.btnAddRubricLevel.Size = new System.Drawing.Size(160, 35);
            this.btnAddRubricLevel.TabIndex = 28;
            this.btnAddRubricLevel.Text = "Add Rubric Level";
            this.btnAddRubricLevel.UseVisualStyleBackColor = true;
            this.btnAddRubricLevel.Click += new System.EventHandler(this.btnAddRubricLevel_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(102, 50);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(62, 21);
            this.lblDetails.TabIndex = 27;
            this.lblDetails.Text = "Details";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 96);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBox1_Validating);
            // 
            // cmbRubricIds
            // 
            this.cmbRubricIds.FormattingEnabled = true;
            this.cmbRubricIds.Location = new System.Drawing.Point(273, 14);
            this.cmbRubricIds.Name = "cmbRubricIds";
            this.cmbRubricIds.Size = new System.Drawing.Size(253, 29);
            this.cmbRubricIds.TabIndex = 24;
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(273, 154);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(253, 27);
            this.txtMeasurementLevel.TabIndex = 34;
            this.txtMeasurementLevel.Validating += new System.ComponentModel.CancelEventHandler(this.txtMeasurementLevel_Validating);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(102, 154);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(163, 21);
            this.lblMeasurementLevel.TabIndex = 35;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel4.Controls.Add(this.lblRubricId);
            this.panel4.Controls.Add(this.lblMeasurementLevel);
            this.panel4.Controls.Add(this.cmbRubricIds);
            this.panel4.Controls.Add(this.txtMeasurementLevel);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.lblDetails);
            this.panel4.Controls.Add(this.btnAddRubricLevel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(166, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 252);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(166, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 39);
            this.panel5.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(453, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(310, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormRubricLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(841, 514);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddClo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormRubricLevels";
            this.Text = "FormRubricLevels";
            this.Load += new System.EventHandler(this.FormRubricLevels_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddClo;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRubricLevelForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnGoBackToMainForm;
        private System.Windows.Forms.Label lblRubricId;
        private System.Windows.Forms.Button btnAddRubricLevel;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmbRubricIds;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}