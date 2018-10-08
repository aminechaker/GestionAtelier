namespace Gestion_Atelier
{
    partial class pointage_du_jour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pointage_du_jour));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.EntrerPictureBox = new System.Windows.Forms.PictureBox();
            this.SortiePictureBox = new System.Windows.Forms.PictureBox();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.NomLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntrerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(354, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(233, 79);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 26);
            this.IdTextBox.TabIndex = 2;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // EntrerPictureBox
            // 
            this.EntrerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EntrerPictureBox.Image")));
            this.EntrerPictureBox.Location = new System.Drawing.Point(58, 165);
            this.EntrerPictureBox.Name = "EntrerPictureBox";
            this.EntrerPictureBox.Size = new System.Drawing.Size(170, 100);
            this.EntrerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EntrerPictureBox.TabIndex = 3;
            this.EntrerPictureBox.TabStop = false;
            this.EntrerPictureBox.Click += new System.EventHandler(this.EntrerPictureBox_Click);
            this.EntrerPictureBox.MouseLeave += new System.EventHandler(this.EntrerPictureBox_MouseLeave);
            this.EntrerPictureBox.MouseHover += new System.EventHandler(this.EntrerPictureBox_MouseHover);
            // 
            // SortiePictureBox
            // 
            this.SortiePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SortiePictureBox.Image")));
            this.SortiePictureBox.Location = new System.Drawing.Point(242, 165);
            this.SortiePictureBox.Name = "SortiePictureBox";
            this.SortiePictureBox.Size = new System.Drawing.Size(170, 100);
            this.SortiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SortiePictureBox.TabIndex = 3;
            this.SortiePictureBox.TabStop = false;
            this.SortiePictureBox.Click += new System.EventHandler(this.SortiePictureBox_Click);
            this.SortiePictureBox.MouseLeave += new System.EventHandler(this.SortiePictureBox_MouseLeave);
            this.SortiePictureBox.MouseHover += new System.EventHandler(this.SortiePictureBox_MouseHover);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.Location = new System.Drawing.Point(545, 480);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 4;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLabel.Location = new System.Drawing.Point(144, 116);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(0, 20);
            this.NomLabel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.SortiePictureBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EntrerPictureBox);
            this.groupBox1.Controls.Add(this.NomLabel);
            this.groupBox1.Location = new System.Drawing.Point(65, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 288);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pointage_du_jour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RetourPictureBox);
            this.Name = "pointage_du_jour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointage du Jour";
            ((System.ComponentModel.ISupportInitialize)(this.EntrerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.PictureBox EntrerPictureBox;
        private System.Windows.Forms.PictureBox SortiePictureBox;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}