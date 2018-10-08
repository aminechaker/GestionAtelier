namespace Gestion_Atelier
{
    partial class salaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salaire));
            this.CalculerSalairePictureBox = new System.Windows.Forms.PictureBox();
            this.ListeDesSalairePictureBox = new System.Windows.Forms.PictureBox();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CalculerSalairePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesSalairePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculerSalairePictureBox
            // 
            this.CalculerSalairePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CalculerSalairePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CalculerSalairePictureBox.Image")));
            this.CalculerSalairePictureBox.Location = new System.Drawing.Point(96, 163);
            this.CalculerSalairePictureBox.Name = "CalculerSalairePictureBox";
            this.CalculerSalairePictureBox.Size = new System.Drawing.Size(170, 100);
            this.CalculerSalairePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CalculerSalairePictureBox.TabIndex = 0;
            this.CalculerSalairePictureBox.TabStop = false;
            this.CalculerSalairePictureBox.Click += new System.EventHandler(this.CalculerSalairePictureBox_Click);
            this.CalculerSalairePictureBox.MouseLeave += new System.EventHandler(this.CalculerSalairePictureBox_MouseLeave);
            this.CalculerSalairePictureBox.MouseHover += new System.EventHandler(this.CalculerSalairePictureBox_MouseHover);
            // 
            // ListeDesSalairePictureBox
            // 
            this.ListeDesSalairePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListeDesSalairePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ListeDesSalairePictureBox.Image")));
            this.ListeDesSalairePictureBox.Location = new System.Drawing.Point(328, 163);
            this.ListeDesSalairePictureBox.Name = "ListeDesSalairePictureBox";
            this.ListeDesSalairePictureBox.Size = new System.Drawing.Size(170, 100);
            this.ListeDesSalairePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ListeDesSalairePictureBox.TabIndex = 0;
            this.ListeDesSalairePictureBox.TabStop = false;
            this.ListeDesSalairePictureBox.Click += new System.EventHandler(this.ListeDesSalairePictureBox_Click);
            this.ListeDesSalairePictureBox.MouseLeave += new System.EventHandler(this.ListeDesSalairePictureBox_MouseLeave);
            this.ListeDesSalairePictureBox.MouseHover += new System.EventHandler(this.ListeDesSalairePictureBox_MouseHover);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(546, 351);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 6;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // salaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 407);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.ListeDesSalairePictureBox);
            this.Controls.Add(this.CalculerSalairePictureBox);
            this.Name = "salaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace des Salaires";
            ((System.ComponentModel.ISupportInitialize)(this.CalculerSalairePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesSalairePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CalculerSalairePictureBox;
        private System.Windows.Forms.PictureBox ListeDesSalairePictureBox;
        private System.Windows.Forms.PictureBox RetourPictureBox;
    }
}