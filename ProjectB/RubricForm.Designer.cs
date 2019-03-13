namespace ProjectB
{
    partial class RubricForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRubricsForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnGoBackToMainPage = new System.Windows.Forms.Button();
            this.cmbIds = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblCloIds = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnAddClo = new System.Windows.Forms.Button();
            this.txtRubricId = new System.Windows.Forms.TextBox();
            this.lblRubricId = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(166, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 206);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRubricsForm);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGoBackToMainPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 493);
            this.panel1.TabIndex = 6;
            // 
            // btnRubricsForm
            // 
            this.btnRubricsForm.FlatAppearance.BorderSize = 0;
            this.btnRubricsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubricsForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRubricsForm.ForeColor = System.Drawing.Color.White;
            this.btnRubricsForm.Location = new System.Drawing.Point(3, 101);
            this.btnRubricsForm.Name = "btnRubricsForm";
            this.btnRubricsForm.Size = new System.Drawing.Size(160, 46);
            this.btnRubricsForm.TabIndex = 1;
            this.btnRubricsForm.Text = "Rubrics Form";
            this.btnRubricsForm.UseVisualStyleBackColor = true;
            this.btnRubricsForm.Click += new System.EventHandler(this.btnRubricsForm_Click);
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
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelHeader.Location = new System.Drawing.Point(42, -13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(63, 79);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "p";
            // 
            // btnGoBackToMainPage
            // 
            this.btnGoBackToMainPage.FlatAppearance.BorderSize = 0;
            this.btnGoBackToMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToMainPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToMainPage.ForeColor = System.Drawing.Color.White;
            this.btnGoBackToMainPage.Location = new System.Drawing.Point(-3, 166);
            this.btnGoBackToMainPage.Name = "btnGoBackToMainPage";
            this.btnGoBackToMainPage.Size = new System.Drawing.Size(169, 49);
            this.btnGoBackToMainPage.TabIndex = 2;
            this.btnGoBackToMainPage.Text = "Go Back To Main Page";
            this.btnGoBackToMainPage.UseVisualStyleBackColor = true;
            this.btnGoBackToMainPage.Click += new System.EventHandler(this.btnGoBackToMainPage_Click);
            // 
            // cmbIds
            // 
            this.cmbIds.FormattingEnabled = true;
            this.cmbIds.Location = new System.Drawing.Point(379, 62);
            this.cmbIds.Name = "cmbIds";
            this.cmbIds.Size = new System.Drawing.Size(253, 29);
            this.cmbIds.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBox1_Validating);
            // 
            // lblCloIds
            // 
            this.lblCloIds.AutoSize = true;
            this.lblCloIds.Location = new System.Drawing.Point(246, 70);
            this.lblCloIds.Name = "lblCloIds";
            this.lblCloIds.Size = new System.Drawing.Size(64, 21);
            this.lblCloIds.TabIndex = 11;
            this.lblCloIds.Text = "CLO Id";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(246, 106);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(62, 21);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Details";
            // 
            // btnAddClo
            // 
            this.btnAddClo.FlatAppearance.BorderSize = 0;
            this.btnAddClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClo.Location = new System.Drawing.Point(544, 208);
            this.btnAddClo.Name = "btnAddClo";
            this.btnAddClo.Size = new System.Drawing.Size(103, 35);
            this.btnAddClo.TabIndex = 13;
            this.btnAddClo.Text = "Add CLO";
            this.btnAddClo.UseVisualStyleBackColor = true;
            this.btnAddClo.Click += new System.EventHandler(this.btnAddClo_Click);
            // 
            // txtRubricId
            // 
            this.txtRubricId.Location = new System.Drawing.Point(379, 19);
            this.txtRubricId.Name = "txtRubricId";
            this.txtRubricId.Size = new System.Drawing.Size(253, 27);
            this.txtRubricId.TabIndex = 14;
            this.txtRubricId.Validating += new System.ComponentModel.CancelEventHandler(this.txtRubricId_Validating);
            // 
            // lblRubricId
            // 
            this.lblRubricId.AutoSize = true;
            this.lblRubricId.Location = new System.Drawing.Point(246, 22);
            this.lblRubricId.Name = "lblRubricId";
            this.lblRubricId.Size = new System.Drawing.Size(80, 21);
            this.lblRubricId.TabIndex = 15;
            this.lblRubricId.Text = "Rubric ID";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // RubricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(725, 493);
            this.Controls.Add(this.lblRubricId);
            this.Controls.Add(this.txtRubricId);
            this.Controls.Add(this.btnAddClo);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblCloIds);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbIds);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RubricForm";
            this.Text = "RubricForm";
            this.Load += new System.EventHandler(this.RubricForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRubricsForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnGoBackToMainPage;
        private System.Windows.Forms.ComboBox cmbIds;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblCloIds;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnAddClo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRubricId;
        private System.Windows.Forms.Label lblRubricId;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}