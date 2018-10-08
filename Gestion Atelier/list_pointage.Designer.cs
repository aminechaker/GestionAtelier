namespace Gestion_Atelier
{
    partial class list_pointage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_pointage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pointageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEntities = new Gestion_Atelier.gestionEntities();
            this.pointageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointageTableAdapter = new Gestion_Atelier.gestionDataSetTableAdapters.pointageTableAdapter();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualiser_Btn = new System.Windows.Forms.Button();
            this.TrieComboBox = new System.Windows.Forms.ComboBox();
            this.gestionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Imprimer_Btn = new System.Windows.Forms.Button();
            this.pointageTableAdapter1 = new Gestion_Atelier.gestionDataSet1TableAdapters.pointageTableAdapter();
            this.pointageTableAdapter2 = new Gestion_Atelier.gestionEntitiesTableAdapters.pointageTableAdapter();
            this.gestionEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet2 = new Gestion_Atelier.gestionDataSet2();
            this.gestionDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPOINTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNNEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEUREENTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEURESORTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEURECUMULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.dATEPOINTAGEDataGridViewTextBoxColumn,
            this.mOISDataGridViewTextBoxColumn,
            this.aNNEEDataGridViewTextBoxColumn,
            this.hEUREENTREDataGridViewTextBoxColumn,
            this.hEURESORTIEDataGridViewTextBoxColumn,
            this.pAUSEDataGridViewTextBoxColumn,
            this.hEURECUMULEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pointageBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // pointageBindingSource1
            // 
            this.pointageBindingSource1.DataMember = "pointage";
            this.pointageBindingSource1.DataSource = this.gestionEntities;
            // 
            // gestionEntities
            // 
            this.gestionEntities.DataSetName = "gestionEntities";
            this.gestionEntities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointageTableAdapter
            // 
            this.pointageTableAdapter.ClearBeforeFill = true;
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(816, 527);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 5;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(625, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TRIER PAR";
            // 
            // Actualiser_Btn
            // 
            this.Actualiser_Btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Actualiser_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Actualiser_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Actualiser_Btn.Location = new System.Drawing.Point(12, 165);
            this.Actualiser_Btn.Name = "Actualiser_Btn";
            this.Actualiser_Btn.Size = new System.Drawing.Size(99, 34);
            this.Actualiser_Btn.TabIndex = 0;
            this.Actualiser_Btn.Text = "Actualiser";
            this.Actualiser_Btn.UseVisualStyleBackColor = true;
            this.Actualiser_Btn.Click += new System.EventHandler(this.Actualiser_Btn_Click);
            // 
            // TrieComboBox
            // 
            this.TrieComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TrieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrieComboBox.FormattingEnabled = true;
            this.TrieComboBox.Items.AddRange(new object[] {
            "",
            "Identifiant",
            "Date"});
            this.TrieComboBox.Location = new System.Drawing.Point(735, 169);
            this.TrieComboBox.Name = "TrieComboBox";
            this.TrieComboBox.Size = new System.Drawing.Size(121, 28);
            this.TrieComboBox.TabIndex = 1;
            this.TrieComboBox.SelectedIndexChanged += new System.EventHandler(this.TrieComboBox_SelectedIndexChanged);
            // 
            // Imprimer_Btn
            // 
            this.Imprimer_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Imprimer_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Imprimer_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimer_Btn.Location = new System.Drawing.Point(748, 432);
            this.Imprimer_Btn.Name = "Imprimer_Btn";
            this.Imprimer_Btn.Size = new System.Drawing.Size(108, 34);
            this.Imprimer_Btn.TabIndex = 0;
            this.Imprimer_Btn.Text = "Imprimer";
            this.Imprimer_Btn.UseVisualStyleBackColor = true;
            this.Imprimer_Btn.Click += new System.EventHandler(this.Imprimer_Btn_Click);
            // 
            // pointageTableAdapter1
            // 
            this.pointageTableAdapter1.ClearBeforeFill = true;
            // 
            // pointageTableAdapter2
            // 
            this.pointageTableAdapter2.ClearBeforeFill = true;
            // 
            // gestionEntitiesBindingSource
            // 
            this.gestionEntitiesBindingSource.DataSource = this.gestionEntities;
            this.gestionEntitiesBindingSource.Position = 0;
            // 
            // gestionDataSet2
            // 
            this.gestionDataSet2.DataSetName = "gestionDataSet2";
            this.gestionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionDataSet2BindingSource
            // 
            this.gestionDataSet2BindingSource.DataSource = this.gestionDataSet2;
            this.gestionDataSet2BindingSource.Position = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            // 
            // dATEPOINTAGEDataGridViewTextBoxColumn
            // 
            this.dATEPOINTAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEPOINTAGEDataGridViewTextBoxColumn.DataPropertyName = "DATE_POINTAGE";
            this.dATEPOINTAGEDataGridViewTextBoxColumn.HeaderText = "DATE_POINTAGE";
            this.dATEPOINTAGEDataGridViewTextBoxColumn.Name = "dATEPOINTAGEDataGridViewTextBoxColumn";
            // 
            // mOISDataGridViewTextBoxColumn
            // 
            this.mOISDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mOISDataGridViewTextBoxColumn.DataPropertyName = "MOIS";
            this.mOISDataGridViewTextBoxColumn.HeaderText = "MOIS";
            this.mOISDataGridViewTextBoxColumn.Name = "mOISDataGridViewTextBoxColumn";
            // 
            // aNNEEDataGridViewTextBoxColumn
            // 
            this.aNNEEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aNNEEDataGridViewTextBoxColumn.DataPropertyName = "ANNEE";
            this.aNNEEDataGridViewTextBoxColumn.HeaderText = "ANNEE";
            this.aNNEEDataGridViewTextBoxColumn.Name = "aNNEEDataGridViewTextBoxColumn";
            // 
            // hEUREENTREDataGridViewTextBoxColumn
            // 
            this.hEUREENTREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hEUREENTREDataGridViewTextBoxColumn.DataPropertyName = "HEURE_ENTRE";
            this.hEUREENTREDataGridViewTextBoxColumn.HeaderText = "HEURE_ENTRE";
            this.hEUREENTREDataGridViewTextBoxColumn.Name = "hEUREENTREDataGridViewTextBoxColumn";
            // 
            // hEURESORTIEDataGridViewTextBoxColumn
            // 
            this.hEURESORTIEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hEURESORTIEDataGridViewTextBoxColumn.DataPropertyName = "HEURE_SORTIE";
            this.hEURESORTIEDataGridViewTextBoxColumn.HeaderText = "HEURE_SORTIE";
            this.hEURESORTIEDataGridViewTextBoxColumn.Name = "hEURESORTIEDataGridViewTextBoxColumn";
            // 
            // pAUSEDataGridViewTextBoxColumn
            // 
            this.pAUSEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAUSEDataGridViewTextBoxColumn.DataPropertyName = "PAUSE";
            this.pAUSEDataGridViewTextBoxColumn.HeaderText = "PAUSE";
            this.pAUSEDataGridViewTextBoxColumn.Name = "pAUSEDataGridViewTextBoxColumn";
            // 
            // hEURECUMULEDataGridViewTextBoxColumn
            // 
            this.hEURECUMULEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hEURECUMULEDataGridViewTextBoxColumn.DataPropertyName = "HEURE_CUMULE";
            this.hEURECUMULEDataGridViewTextBoxColumn.HeaderText = "HEURE_CUMULE";
            this.hEURECUMULEDataGridViewTextBoxColumn.Name = "hEURECUMULEDataGridViewTextBoxColumn";
            // 
            // list_pointage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 573);
            this.Controls.Add(this.TrieComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imprimer_Btn);
            this.Controls.Add(this.Actualiser_Btn);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "list_pointage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Pointages";
            this.Load += new System.EventHandler(this.list_pointage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pointageBindingSource;
        private gestionDataSetTableAdapters.pointageTableAdapter pointageTableAdapter;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualiser_Btn;
        private System.Windows.Forms.ComboBox TrieComboBox;
        private System.Windows.Forms.BindingSource gestionDataSetBindingSource;
        private System.Windows.Forms.Button Imprimer_Btn;
        private gestionDataSet1TableAdapters.pointageTableAdapter pointageTableAdapter1;
        private gestionEntities gestionEntities;
        private System.Windows.Forms.BindingSource pointageBindingSource1;
        private gestionEntitiesTableAdapters.pointageTableAdapter pointageTableAdapter2;
        private System.Windows.Forms.BindingSource gestionEntitiesBindingSource;
        private gestionDataSet2 gestionDataSet2;
        private System.Windows.Forms.BindingSource gestionDataSet2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPOINTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNNEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEUREENTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEURESORTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEURECUMULEDataGridViewTextBoxColumn;
    }
}