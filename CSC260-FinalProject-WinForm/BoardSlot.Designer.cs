namespace CatsVsDogs
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
            labelHealth = new Label();
            labelDamage = new Label();
            labelMana = new Label();
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
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Location = new Point(3, 123);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(0, 15);
            labelHealth.TabIndex = 4;
            labelHealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Location = new Point(74, 123);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(0, 15);
            labelDamage.TabIndex = 6;
            labelDamage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.Location = new Point(74, 11);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(0, 15);
            labelMana.TabIndex = 2;
            labelMana.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label labelHealth;
        private Label labelDamage;
        private Label labelMana;
    }
}
