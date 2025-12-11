namespace CSC260_FinalProject_WinForm
{
    partial class SetupScreen
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(201, 141);
            button1.Name = "button1";
            button1.Size = new Size(202, 126);
            button1.TabIndex = 0;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            // 
            // SetupScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "SetupScreen";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
