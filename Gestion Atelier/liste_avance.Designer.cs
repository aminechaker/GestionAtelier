namespace Gestion_Atelier
{
    partial class liste_avance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste_avance));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.avanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new Gestion_Atelier.gestionDataSet();
            this.avanceTableAdapter = new Gestion_Atelier.gestionDataSetTableAdapters.avanceTableAdapter();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEAVANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTANTAVANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dATEAVANCEDataGridViewTextBoxColumn,
            this.mONTANTAVANCEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 123);
            this.dataGridView1.TabIndex = 0;
            // 
            // avanceBindingSource
            // 
            this.avanceBindingSource.DataMember = "avance";
            this.avanceBindingSource.DataSource = this.gestionDataSet;
            // 
            // gestionDataSet
            // 
            this.gestionDataSet.DataSetName = "gestionDataSet";
            this.gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avanceTableAdapter
            // 
            this.avanceTableAdapter.ClearBeforeFill = true;
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(473, 357);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 6;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 120;
            // 
            // dATEAVANCEDataGridViewTextBoxColumn
            // 
            this.dATEAVANCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEAVANCEDataGridViewTextBoxColumn.DataPropertyName = "DATE_AVANCE";
            this.dATEAVANCEDataGridViewTextBoxColumn.HeaderText = "DATE_AVANCE";
            this.dATEAVANCEDataGridViewTextBoxColumn.Name = "dATEAVANCEDataGridViewTextBoxColumn";
            // 
            // mONTANTAVANCEDataGridViewTextBoxColumn
            // 
            this.mONTANTAVANCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mONTANTAVANCEDataGridViewTextBoxColumn.DataPropertyName = "MONTANT_AVANCE";
            this.mONTANTAVANCEDataGridViewTextBoxColumn.HeaderText = "MONTANT_AVANCE";
            this.mONTANTAVANCEDataGridViewTextBoxColumn.Name = "mONTANTAVANCEDataGridViewTextBoxColumn";
            // 
            // liste_avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 413);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "liste_avance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Avances";
            this.Load += new System.EventHandler(this.liste_avance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionDataSet gestionDataSet;
        private System.Windows.Forms.BindingSource avanceBindingSource;
        private gestionDataSetTableAdapters.avanceTableAdapter avanceTableAdapter;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEAVANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTANTAVANCEDataGridViewTextBoxColumn;
    }
}