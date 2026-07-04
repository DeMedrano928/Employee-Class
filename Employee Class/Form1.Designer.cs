namespace Employee_Class
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultsLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // resultsLabel
            // 
            resultsLabel.BackColor = SystemColors.ButtonHighlight;
            resultsLabel.BorderStyle = BorderStyle.FixedSingle;
            resultsLabel.Font = new Font("Segoe UI", 10F);
            resultsLabel.Location = new Point(12, 9);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(776, 390);
            resultsLabel.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ButtonFace;
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.Location = new Point(355, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(resultsLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label resultsLabel;
        private Button exitButton;
    }
}
