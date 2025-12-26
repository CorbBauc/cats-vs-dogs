namespace CatsVsDogs
{
    partial class CardSlot
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
            labelMana = new Label();
            labelHealth = new Label();
            labelDamage = new Label();
            pictureBoxCardArt = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardArt).BeginInit();
            SuspendLayout();
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.Location = new Point(64, 9);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(38, 15);
            labelMana.TabIndex = 2;
            labelMana.Text = "label1";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Location = new Point(13, 126);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(38, 15);
            labelHealth.TabIndex = 4;
            labelHealth.Text = "label2";
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Location = new Point(64, 126);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(38, 15);
            labelDamage.TabIndex = 6;
            labelDamage.Text = "label3";
            // 
            // pictureBoxCardArt
            // 
            pictureBoxCardArt.Location = new Point(0, 0);
            pictureBoxCardArt.Name = "pictureBoxCardArt";
            pictureBoxCardArt.Size = new Size(115, 150);
            pictureBoxCardArt.TabIndex = 7;
            pictureBoxCardArt.TabStop = false;
            // 
            // CardSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(labelDamage);
            Controls.Add(labelHealth);
            Controls.Add(labelMana);
            Controls.Add(pictureBoxCardArt);
            Name = "CardSlot";
            Size = new Size(115, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCardArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMana;
        private Label labelHealth;
        private Label labelDamage;
        private PictureBox pictureBoxCardArt;
    }
}
