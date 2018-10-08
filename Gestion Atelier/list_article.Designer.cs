namespace Gestion_Atelier
{
    partial class list_article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_article));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rEFERENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXUNITAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDEBUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDataSet = new Gestion_Atelier.gestionDataSet();
            this.articleTableAdapter = new Gestion_Atelier.gestionDataSetTableAdapters.articleTableAdapter();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.Actualiser_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrieComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FinArticle_Btn = new System.Windows.Forms.Button();
            this.ReferenceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
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
            this.rEFERENCEDataGridViewTextBoxColumn,
            this.qUANTITEDataGridViewTextBoxColumn,
            this.pRIXUNITAIREDataGridViewTextBoxColumn,
            this.dATEDEBUTDataGridViewTextBoxColumn,
            this.dATEFINDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 225);
            this.dataGridView1.TabIndex = 4;
            // 
            // rEFERENCEDataGridViewTextBoxColumn
            // 
            this.rEFERENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEFERENCEDataGridViewTextBoxColumn.DataPropertyName = "REFERENCE";
            this.rEFERENCEDataGridViewTextBoxColumn.HeaderText = "REFERENCE";
            this.rEFERENCEDataGridViewTextBoxColumn.Name = "rEFERENCEDataGridViewTextBoxColumn";
            // 
            // qUANTITEDataGridViewTextBoxColumn
            // 
            this.qUANTITEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qUANTITEDataGridViewTextBoxColumn.DataPropertyName = "QUANTITE";
            this.qUANTITEDataGridViewTextBoxColumn.HeaderText = "QUANTITE";
            this.qUANTITEDataGridViewTextBoxColumn.Name = "qUANTITEDataGridViewTextBoxColumn";
            // 
            // pRIXUNITAIREDataGridViewTextBoxColumn
            // 
            this.pRIXUNITAIREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRIXUNITAIREDataGridViewTextBoxColumn.DataPropertyName = "PRIX_UNITAIRE";
            this.pRIXUNITAIREDataGridViewTextBoxColumn.HeaderText = "PRIX_UNITAIRE";
            this.pRIXUNITAIREDataGridViewTextBoxColumn.Name = "pRIXUNITAIREDataGridViewTextBoxColumn";
            // 
            // dATEDEBUTDataGridViewTextBoxColumn
            // 
            this.dATEDEBUTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEDEBUTDataGridViewTextBoxColumn.DataPropertyName = "DATE_DEBUT";
            this.dATEDEBUTDataGridViewTextBoxColumn.HeaderText = "DATE_DEBUT";
            this.dATEDEBUTDataGridViewTextBoxColumn.Name = "dATEDEBUTDataGridViewTextBoxColumn";
            // 
            // dATEFINDataGridViewTextBoxColumn
            // 
            this.dATEFINDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEFINDataGridViewTextBoxColumn.DataPropertyName = "DATE_FIN";
            this.dATEFINDataGridViewTextBoxColumn.HeaderText = "DATE_FIN";
            this.dATEFINDataGridViewTextBoxColumn.Name = "dATEFINDataGridViewTextBoxColumn";
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "article";
            this.articleBindingSource.DataSource = this.gestionDataSet;
            // 
            // gestionDataSet
            // 
            this.gestionDataSet.DataSetName = "gestionDataSet";
            this.gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(612, 554);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 9;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // Actualiser_Btn
            // 
            this.Actualiser_Btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Actualiser_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Actualiser_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualiser_Btn.Location = new System.Drawing.Point(12, 167);
            this.Actualiser_Btn.Name = "Actualiser_Btn";
            this.Actualiser_Btn.Size = new System.Drawing.Size(88, 32);
            this.Actualiser_Btn.TabIndex = 0;
            this.Actualiser_Btn.Text = "Actualiser";
            this.Actualiser_Btn.UseVisualStyleBackColor = false;
            this.Actualiser_Btn.Click += new System.EventHandler(this.Actualiser_Btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trier Par";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrieComboBox
            // 
            this.TrieComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TrieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrieComboBox.FormattingEnabled = true;
            this.TrieComboBox.Items.AddRange(new object[] {
            "",
            "Date",
            "Quantite",
            "Prix"});
            this.TrieComboBox.Location = new System.Drawing.Point(535, 170);
            this.TrieComboBox.Name = "TrieComboBox";
            this.TrieComboBox.Size = new System.Drawing.Size(121, 28);
            this.TrieComboBox.TabIndex = 1;
            this.TrieComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reference";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // FinArticle_Btn
            // 
            this.FinArticle_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinArticle_Btn.BackColor = System.Drawing.Color.Transparent;
            this.FinArticle_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinArticle_Btn.Location = new System.Drawing.Point(568, 457);
            this.FinArticle_Btn.Name = "FinArticle_Btn";
            this.FinArticle_Btn.Size = new System.Drawing.Size(88, 32);
            this.FinArticle_Btn.TabIndex = 3;
            this.FinArticle_Btn.Text = "Fin Article";
            this.FinArticle_Btn.UseVisualStyleBackColor = false;
            this.FinArticle_Btn.Click += new System.EventHandler(this.FinArticle_Btn_Click);
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceTextBox.Location = new System.Drawing.Point(453, 460);
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.Size = new System.Drawing.Size(100, 26);
            this.ReferenceTextBox.TabIndex = 2;
            this.ReferenceTextBox.TextChanged += new System.EventHandler(this.ReferenceTextBox_TextChanged);
            // 
            // list_article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_Atelier.Properties.Resources.espace_liste_article;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 610);
            this.Controls.Add(this.ReferenceTextBox);
            this.Controls.Add(this.TrieComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinArticle_Btn);
            this.Controls.Add(this.Actualiser_Btn);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "list_article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Articles";
            this.Load += new System.EventHandler(this.list_article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionDataSet gestionDataSet;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private gestionDataSetTableAdapters.articleTableAdapter articleTableAdapter;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.Button Actualiser_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TrieComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FinArticle_Btn;
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFERENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXUNITAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDEBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
    }
}