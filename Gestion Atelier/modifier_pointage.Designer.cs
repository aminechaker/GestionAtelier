namespace Gestion_Atelier
{
    partial class modifier_pointage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifier_pointage));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PauseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Confirmer_Btn = new System.Windows.Forms.Button();
            this.RetourPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 32);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(187, 102);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 26);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PAUSE";
            // 
            // PauseTextBox
            // 
            this.PauseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseTextBox.Location = new System.Drawing.Point(187, 181);
            this.PauseTextBox.Mask = "00:00";
            this.PauseTextBox.Name = "PauseTextBox";
            this.PauseTextBox.Size = new System.Drawing.Size(100, 26);
            this.PauseTextBox.TabIndex = 1;
            this.PauseTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Confirmer_Btn
            // 
            this.Confirmer_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Confirmer_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Confirmer_Btn.Location = new System.Drawing.Point(229, 398);
            this.Confirmer_Btn.Name = "Confirmer_Btn";
            this.Confirmer_Btn.Size = new System.Drawing.Size(99, 34);
            this.Confirmer_Btn.TabIndex = 2;
            this.Confirmer_Btn.Text = "Confirmer";
            this.Confirmer_Btn.UseVisualStyleBackColor = true;
            this.Confirmer_Btn.Click += new System.EventHandler(this.Confirmer_Btn_Click);
            // 
            // RetourPictureBox
            // 
            this.RetourPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RetourPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RetourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RetourPictureBox.Image")));
            this.RetourPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RetourPictureBox.Location = new System.Drawing.Point(514, 434);
            this.RetourPictureBox.Name = "RetourPictureBox";
            this.RetourPictureBox.Size = new System.Drawing.Size(44, 44);
            this.RetourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RetourPictureBox.TabIndex = 8;
            this.RetourPictureBox.TabStop = false;
            this.RetourPictureBox.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.NomLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.PauseTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(100, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 235);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLabel.Location = new System.Drawing.Point(98, 143);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(0, 20);
            this.NomLabel.TabIndex = 3;
            // 
            // modifier_pointage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RetourPictureBox);
            this.Controls.Add(this.Confirmer_Btn);
            this.Name = "modifier_pointage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier des Pointages";
            ((System.ComponentModel.ISupportInitialize)(this.RetourPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PauseTextBox;
        private System.Windows.Forms.Button Confirmer_Btn;
        private System.Windows.Forms.PictureBox RetourPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NomLabel;
    }
}