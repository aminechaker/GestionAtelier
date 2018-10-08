namespace Gestion_Atelier
{
    partial class liste_employes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste_employes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new Gestion_Atelier.gestionDataSet();
            this.employeesTableAdapter = new Gestion_Atelier.gestionDataSetTableAdapters.employeesTableAdapter();
            this.Actualiser_Btn = new System.Windows.Forms.Button();
            this.Rechercher_Btn = new System.Windows.Forms.Button();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONCTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.cONTACTDataGridViewTextBoxColumn,
            this.fONCTIONDataGridViewTextBoxColumn,
            this.sALAIREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.gestionDataSet;
            // 
            // gestionDataSet
            // 
            this.gestionDataSet.DataSetName = "gestionDataSet";
            this.gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Actualiser_Btn
            // 
            resources.ApplyResources(this.Actualiser_Btn, "Actualiser_Btn");
            this.Actualiser_Btn.Name = "Actualiser_Btn";
            this.Actualiser_Btn.UseVisualStyleBackColor = true;
            this.Actualiser_Btn.Click += new System.EventHandler(this.Actualiser_Btn_Click);
            // 
            // Rechercher_Btn
            // 
            resources.ApplyResources(this.Rechercher_Btn, "Rechercher_Btn");
            this.Rechercher_Btn.Name = "Rechercher_Btn";
            this.Rechercher_Btn.UseVisualStyleBackColor = true;
            this.Rechercher_Btn.Click += new System.EventHandler(this.Rechercher_Btn_Click);
            // 
            // PrenomTextBox
            // 
            resources.ApplyResources(this.PrenomTextBox, "PrenomTextBox");
            this.PrenomTextBox.Name = "PrenomTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // RetourPictureBox
            // 
            resources.ApplyResources(this.RetourPictureBox, "RetourPictureBox");
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            resources.ApplyResources(this.nOMDataGridViewTextBoxColumn, "nOMDataGridViewTextBoxColumn");
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            resources.ApplyResources(this.pRENOMDataGridViewTextBoxColumn, "pRENOMDataGridViewTextBoxColumn");
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            // 
            // cONTACTDataGridViewTextBoxColumn
            // 
            this.cONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT";
            resources.ApplyResources(this.cONTACTDataGridViewTextBoxColumn, "cONTACTDataGridViewTextBoxColumn");
            this.cONTACTDataGridViewTextBoxColumn.Name = "cONTACTDataGridViewTextBoxColumn";
            // 
            // fONCTIONDataGridViewTextBoxColumn
            // 
            this.fONCTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fONCTIONDataGridViewTextBoxColumn.DataPropertyName = "FONCTION";
            resources.ApplyResources(this.fONCTIONDataGridViewTextBoxColumn, "fONCTIONDataGridViewTextBoxColumn");
            this.fONCTIONDataGridViewTextBoxColumn.Name = "fONCTIONDataGridViewTextBoxColumn";
            // 
            // sALAIREDataGridViewTextBoxColumn
            // 
            this.sALAIREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sALAIREDataGridViewTextBoxColumn.DataPropertyName = "SALAIRE";
            resources.ApplyResources(this.sALAIREDataGridViewTextBoxColumn, "sALAIREDataGridViewTextBoxColumn");
            this.sALAIREDataGridViewTextBoxColumn.Name = "sALAIREDataGridViewTextBoxColumn";
            // 
            // liste_employes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrenomTextBox);
            this.Controls.Add(this.Rechercher_Btn);
            this.Controls.Add(this.Actualiser_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "liste_employes";
            this.Load += new System.EventHandler(this.liste_employes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionDataSet gestionDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private gestionDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button Actualiser_Btn;
        private System.Windows.Forms.Button Rechercher_Btn;
        private System.Windows.Forms.TextBox PrenomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONCTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALAIREDataGridViewTextBoxColumn;
    }
}