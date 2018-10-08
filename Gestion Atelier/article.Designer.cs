namespace Gestion_Atelier
{
    partial class article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(article));
            this.AjouterArticlePictureBox = new System.Windows.Forms.PictureBox();
            this.ListeArticlePictureBox = new System.Windows.Forms.PictureBox();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AjouterArticlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AjouterArticlePictureBox
            // 
            this.AjouterArticlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AjouterArticlePictureBox.Image = global::Gestion_Atelier.Properties.Resources.ajouter_article;
            this.AjouterArticlePictureBox.Location = new System.Drawing.Point(46, 192);
            this.AjouterArticlePictureBox.Name = "AjouterArticlePictureBox";
            this.AjouterArticlePictureBox.Size = new System.Drawing.Size(170, 100);
            this.AjouterArticlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AjouterArticlePictureBox.TabIndex = 0;
            this.AjouterArticlePictureBox.TabStop = false;
            this.AjouterArticlePictureBox.Click += new System.EventHandler(this.AjouterArticlePictureBox_Click);
            this.AjouterArticlePictureBox.MouseLeave += new System.EventHandler(this.AjouterArticlePictureBox_MouseLeave);
            this.AjouterArticlePictureBox.MouseHover += new System.EventHandler(this.AjouterArticlePictureBox_MouseHover);
            // 
            // ListeArticlePictureBox
            // 
            this.ListeArticlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListeArticlePictureBox.Image = global::Gestion_Atelier.Properties.Resources.liste_article;
            this.ListeArticlePictureBox.Location = new System.Drawing.Point(294, 192);
            this.ListeArticlePictureBox.Name = "ListeArticlePictureBox";
            this.ListeArticlePictureBox.Size = new System.Drawing.Size(170, 100);
            this.ListeArticlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ListeArticlePictureBox.TabIndex = 0;
            this.ListeArticlePictureBox.TabStop = false;
            this.ListeArticlePictureBox.Click += new System.EventHandler(this.ListeArticlePictureBox_Click);
            this.ListeArticlePictureBox.MouseLeave += new System.EventHandler(this.ListeArticlePictureBox_MouseLeave);
            this.ListeArticlePictureBox.MouseHover += new System.EventHandler(this.ListeArticlePictureBox_MouseHover);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(485, 371);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 7;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_Atelier.Properties.Resources.espace_article;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 427);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.ListeArticlePictureBox);
            this.Controls.Add(this.AjouterArticlePictureBox);
            this.Name = "article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace des Articles";
            ((System.ComponentModel.ISupportInitialize)(this.AjouterArticlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AjouterArticlePictureBox;
        private System.Windows.Forms.PictureBox ListeArticlePictureBox;
        private System.Windows.Forms.PictureBox RetourPictureBox;
    }
}