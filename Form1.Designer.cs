namespace MultiplicationTableGenerator
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
            label1 = new Label();
            numberTextBox = new TextBox();
            generateButton = new Button();
            resultsListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a number:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(109, 6);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(94, 23);
            numberTextBox.TabIndex = 1;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(12, 35);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(191, 23);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // resultsListBox
            // 
            resultsListBox.FormattingEnabled = true;
            resultsListBox.Location = new Point(12, 67);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(191, 169);
            resultsListBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 248);
            Controls.Add(resultsListBox);
            Controls.Add(generateButton);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Multiplication Table Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberTextBox;
        private Button generateButton;
        private ListBox resultsListBox;
    }
}
