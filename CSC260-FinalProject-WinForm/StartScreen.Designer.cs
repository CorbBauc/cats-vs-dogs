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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(860, 449);
            button1.Name = "button1";
            button1.Size = new Size(236, 200);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(754, 202);
            label1.Name = "label1";
            label1.Size = new Size(441, 76);
            label1.TabIndex = 1;
            label1.Text = "DOGS VS. CATS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDark;
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "StartScreen";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}
