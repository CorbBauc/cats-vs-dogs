namespace CSC260_FinalProject_WinForm
{
    partial class StartScreen
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
            button1 = new Button();
            tutorialButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(51, 661);
            button1.Name = "button1";
            button1.Size = new Size(236, 200);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tutorialButton.Location = new Point(51, 455);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(236, 200);
            tutorialButton.TabIndex = 1;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            // 
            // StartScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDark;
            Controls.Add(tutorialButton);
            Controls.Add(button1);
            Name = "StartScreen";
            Size = new Size(1406, 892);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button tutorialButton;
    }
}
