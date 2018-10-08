namespace Gestion_Atelier
{
    partial class avance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avance));
            this.AjouterAvancePictureBox = new System.Windows.Forms.PictureBox();
            this.ListeDesAvancesPictureBox = new System.Windows.Forms.PictureBox();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AjouterAvancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesAvancesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AjouterAvancePictureBox
            // 
            this.AjouterAvancePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AjouterAvancePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AjouterAvancePictureBox.Image")));
            this.AjouterAvancePictureBox.Location = new System.Drawing.Point(61, 155);
            this.AjouterAvancePictureBox.Name = "AjouterAvancePictureBox";
            this.AjouterAvancePictureBox.Size = new System.Drawing.Size(170, 100);
            this.AjouterAvancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AjouterAvancePictureBox.TabIndex = 0;
            this.AjouterAvancePictureBox.TabStop = false;
            this.AjouterAvancePictureBox.Click += new System.EventHandler(this.AjouterAvancePictureBox_Click);
            this.AjouterAvancePictureBox.MouseLeave += new System.EventHandler(this.AjouterAvancePictureBox_MouseLeave);
            this.AjouterAvancePictureBox.MouseHover += new System.EventHandler(this.AjouterAvancePictureBox_MouseHover);
            // 
            // ListeDesAvancesPictureBox
            // 
            this.ListeDesAvancesPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListeDesAvancesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ListeDesAvancesPictureBox.Image")));
            this.ListeDesAvancesPictureBox.Location = new System.Drawing.Point(343, 155);
            this.ListeDesAvancesPictureBox.Name = "ListeDesAvancesPictureBox";
            this.ListeDesAvancesPictureBox.Size = new System.Drawing.Size(170, 100);
            this.ListeDesAvancesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ListeDesAvancesPictureBox.TabIndex = 0;
            this.ListeDesAvancesPictureBox.TabStop = false;
            this.ListeDesAvancesPictureBox.Click += new System.EventHandler(this.ListeDesAvancesPictureBox_Click);
            this.ListeDesAvancesPictureBox.MouseLeave += new System.EventHandler(this.ListeDesAvancesPictureBox_MouseLeave);
            this.ListeDesAvancesPictureBox.MouseHover += new System.EventHandler(this.ListeDesAvancesPictureBox_MouseHover);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(514, 358);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 6;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 414);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.ListeDesAvancesPictureBox);
            this.Controls.Add(this.AjouterAvancePictureBox);
            this.Name = "avance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espaces des Avances";
            ((System.ComponentModel.ISupportInitialize)(this.AjouterAvancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesAvancesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AjouterAvancePictureBox;
        private System.Windows.Forms.PictureBox ListeDesAvancesPictureBox;
        private System.Windows.Forms.PictureBox RetourPictureBox;
    }
}