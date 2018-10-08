namespace Gestion_Atelier
{
    partial class imprimer_pointage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprimer_pointage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestionEntities = new Gestion_Atelier.gestionEntities();
            this.pointageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointageTableAdapter = new Gestion_Atelier.gestionEntitiesTableAdapters.pointageTableAdapter();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Imprimer_Btn = new System.Windows.Forms.Button();
            this.pointageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPOINTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEUREENTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEURESORTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEURECUMULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MoisComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnneeTextBox = new System.Windows.Forms.TextBox();
            this.NomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dATEPOINTAGEDataGridViewTextBoxColumn,
            this.hEUREENTREDataGridViewTextBoxColumn,
            this.hEURESORTIEDataGridViewTextBoxColumn,
            this.pAUSEDataGridViewTextBoxColumn,
            this.hEURECUMULEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pointageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestionEntities
            // 
            this.gestionEntities.DataSetName = "gestionEntities";
            this.gestionEntities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointageBindingSource
            // 
            this.pointageBindingSource.DataMember = "pointage";
            this.pointageBindingSource.DataSource = this.gestionEntities;
            // 
            // pointageTableAdapter
            // 
            this.pointageTableAdapter.ClearBeforeFill = true;
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.Location = new System.Drawing.Point(673, 432);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 2;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(617, 348);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 26);
            this.IdTextBox.TabIndex = 13;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(503, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "IDENTIFIANT";
            // 
            // Imprimer_Btn
            // 
            this.Imprimer_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Imprimer_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Imprimer_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimer_Btn.Location = new System.Drawing.Point(609, 74);
            this.Imprimer_Btn.Name = "Imprimer_Btn";
            this.Imprimer_Btn.Size = new System.Drawing.Size(108, 34);
            this.Imprimer_Btn.TabIndex = 14;
            this.Imprimer_Btn.Text = "Imprimer";
            this.Imprimer_Btn.UseVisualStyleBackColor = true;
            this.Imprimer_Btn.Click += new System.EventHandler(this.Imprimer_Btn_Click);
            // 
            // pointageBindingSource1
            // 
            this.pointageBindingSource1.DataMember = "pointage";
            this.pointageBindingSource1.DataSource = this.gestionEntities;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 35;
            // 
            // dATEPOINTAGEDataGridViewTextBoxColumn
            // 
            this.dATEPOINTAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEPOINTAGEDataGridViewTextBoxColumn.DataPropertyName = "DATE_POINTAGE";
            this.dATEPOINTAGEDataGridViewTextBoxColumn.HeaderText = "DATE_POINTAGE";
            this.dATEPOINTAGEDataGridViewTextBoxColumn.Name = "dATEPOINTAGEDataGridViewTextBoxColumn";
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
            this.pAUSEDataGridViewTextBoxColumn.DataPropertyName = "PAUSE";
            this.pAUSEDataGridViewTextBoxColumn.HeaderText = "PAUSE";
            this.pAUSEDataGridViewTextBoxColumn.Name = "pAUSEDataGridViewTextBoxColumn";
            // 
            // hEURECUMULEDataGridViewTextBoxColumn
            // 
            this.hEURECUMULEDataGridViewTextBoxColumn.DataPropertyName = "HEURE_CUMULE";
            this.hEURECUMULEDataGridViewTextBoxColumn.HeaderText = "HEURE_CUMULE";
            this.hEURECUMULEDataGridViewTextBoxColumn.Name = "hEURECUMULEDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(503, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "MOIS";
            // 
            // MoisComboBox
            // 
            this.MoisComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MoisComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MoisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoisComboBox.FormattingEnabled = true;
            this.MoisComboBox.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.MoisComboBox.Location = new System.Drawing.Point(617, 307);
            this.MoisComboBox.Name = "MoisComboBox";
            this.MoisComboBox.Size = new System.Drawing.Size(100, 28);
            this.MoisComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(503, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ANNEE";
            // 
            // AnneeTextBox
            // 
            this.AnneeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AnneeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeTextBox.Location = new System.Drawing.Point(617, 270);
            this.AnneeTextBox.Name = "AnneeTextBox";
            this.AnneeTextBox.ReadOnly = true;
            this.AnneeTextBox.Size = new System.Drawing.Size(100, 26);
            this.AnneeTextBox.TabIndex = 13;
            // 
            // NomLabel
            // 
            this.NomLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NomLabel.AutoSize = true;
            this.NomLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NomLabel.Location = new System.Drawing.Point(191, 81);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(0, 20);
            this.NomLabel.TabIndex = 12;
            // 
            // imprimer_pointage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 488);
            this.Controls.Add(this.MoisComboBox);
            this.Controls.Add(this.Imprimer_Btn);
            this.Controls.Add(this.AnneeTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "imprimer_pointage";
            this.Text = "imprimer_pointage";
            this.Load += new System.EventHandler(this.imprimer_pointage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionEntities gestionEntities;
        private System.Windows.Forms.BindingSource pointageBindingSource;
        private gestionEntitiesTableAdapters.pointageTableAdapter pointageTableAdapter;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Imprimer_Btn;
        private System.Windows.Forms.BindingSource pointageBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPOINTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEUREENTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEURESORTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEURECUMULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MoisComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnneeTextBox;
        private System.Windows.Forms.Label NomLabel;
    }
}