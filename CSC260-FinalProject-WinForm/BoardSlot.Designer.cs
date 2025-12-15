namespace CSC260_FinalProject_WinForm
{
    partial class BoardSlot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCardArt = new PictureBox();
            labelMana = new Label();
            labelHealth = new Label();
            labelDamage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardArt).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCardArt
            // 
            pictureBoxCardArt.Location = new Point(0, 0);
            pictureBoxCardArt.Name = "pictureBoxCardArt";
            pictureBoxCardArt.Size = new Size(115, 150);
            pictureBoxCardArt.TabIndex = 0;
            pictureBoxCardArt.TabStop = false;
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.Location = new Point(65, 11);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(38, 15);
            labelMana.TabIndex = 2;
            labelMana.Text = "label1";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Location = new Point(3, 123);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(38, 15);
            labelHealth.TabIndex = 4;
            labelHealth.Text = "label2";
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Location = new Point(65, 123);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(38, 15);
            labelDamage.TabIndex = 6;
            labelDamage.Text = "label3";
            // 
            // BoardSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHealth);
            Controls.Add(labelDamage);
            Controls.Add(labelMana);
            Controls.Add(pictureBoxCardArt);
            Name = "BoardSlot";
            Size = new Size(115, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCardArt;
        private Label labelMana;
        private Label labelHealth;
        private Label labelDamage;
    }
}
