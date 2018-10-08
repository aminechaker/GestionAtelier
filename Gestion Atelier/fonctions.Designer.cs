namespace Gestion_Atelier
{
    partial class fonctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fonctions));
            this.AjouterFonctionPictureBox = new System.Windows.Forms.PictureBox();
            this.ListeDesFonctionPictureBox = new System.Windows.Forms.PictureBox();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AjouterFonctionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesFonctionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AjouterFonctionPictureBox
            // 
            this.AjouterFonctionPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AjouterFonctionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AjouterFonctionPictureBox.Image")));
            this.AjouterFonctionPictureBox.Location = new System.Drawing.Point(53, 173);
            this.AjouterFonctionPictureBox.Name = "AjouterFonctionPictureBox";
            this.AjouterFonctionPictureBox.Size = new System.Drawing.Size(170, 100);
            this.AjouterFonctionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AjouterFonctionPictureBox.TabIndex = 0;
            this.AjouterFonctionPictureBox.TabStop = false;
            this.AjouterFonctionPictureBox.Click += new System.EventHandler(this.AjouterFonctionPictureBox_Click);
            this.AjouterFonctionPictureBox.MouseLeave += new System.EventHandler(this.AjouterFonctionPictureBox_MouseLeave);
            this.AjouterFonctionPictureBox.MouseHover += new System.EventHandler(this.AjouterFonctionPictureBox_MouseHover);
            // 
            // ListeDesFonctionPictureBox
            // 
            this.ListeDesFonctionPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListeDesFonctionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ListeDesFonctionPictureBox.Image")));
            this.ListeDesFonctionPictureBox.Location = new System.Drawing.Point(330, 173);
            this.ListeDesFonctionPictureBox.Name = "ListeDesFonctionPictureBox";
            this.ListeDesFonctionPictureBox.Size = new System.Drawing.Size(170, 100);
            this.ListeDesFonctionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ListeDesFonctionPictureBox.TabIndex = 0;
            this.ListeDesFonctionPictureBox.TabStop = false;
            this.ListeDesFonctionPictureBox.Click += new System.EventHandler(this.ListeDesFonctionPictureBox_Click);
            this.ListeDesFonctionPictureBox.MouseLeave += new System.EventHandler(this.ListeDesFonctionPictureBox_MouseLeave);
            this.ListeDesFonctionPictureBox.MouseHover += new System.EventHandler(this.ListeDesFonctionPictureBox_MouseHover);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.Location = new System.Drawing.Point(498, 351);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 1;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // fonctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 407);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.ListeDesFonctionPictureBox);
            this.Controls.Add(this.AjouterFonctionPictureBox);
            this.Name = "fonctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace Fonctions";
            ((System.ComponentModel.ISupportInitialize)(this.AjouterFonctionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesFonctionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AjouterFonctionPictureBox;
        private System.Windows.Forms.PictureBox ListeDesFonctionPictureBox;
        private System.Windows.Forms.PictureBox RetourPictureBox;
    }
}