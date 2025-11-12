namespace MultiplicationTableGenerator
{
    partial class Form1
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
            groupBoxInput = new GroupBox();
            labelPrompt = new Label();
            numberInput = new NumericUpDown();
            generateButton = new Button();
            resultsListBox = new ListBox();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberInput).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelPrompt);
            groupBoxInput.Controls.Add(numberInput);
            groupBoxInput.Dock = DockStyle.Top;
            groupBoxInput.FlatStyle = FlatStyle.Flat;
            groupBoxInput.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInput.ForeColor = Color.White;
            groupBoxInput.Location = new Point(12, 12);
            groupBoxInput.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(12);
            groupBoxInput.Size = new Size(366, 87);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Input";
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.ForeColor = Color.White;
            labelPrompt.Location = new Point(26, 39);
            labelPrompt.Margin = new Padding(4, 0, 4, 0);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(100, 16);
            labelPrompt.TabIndex = 1;
            labelPrompt.Text = "Enter a number:";
            // 
            // numberInput
            // 
            numberInput.BackColor = Color.FromArgb(25, 25, 25);
            numberInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberInput.ForeColor = Color.White;
            numberInput.Location = new Point(150, 35);
            numberInput.Margin = new Padding(4, 3, 4, 3);
            numberInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numberInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(188, 26);
            numberInput.TabIndex = 0;
            numberInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.CornflowerBlue;
            generateButton.Dock = DockStyle.Bottom;
            generateButton.FlatAppearance.BorderSize = 0;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateButton.ForeColor = Color.White;
            generateButton.Location = new Point(12, 451);
            generateButton.Margin = new Padding(4, 3, 4, 3);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(366, 46);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.FromArgb(25, 25, 25);
            resultsListBox.Dock = DockStyle.Fill;
            resultsListBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsListBox.ForeColor = Color.White;
            resultsListBox.FormattingEnabled = true;
            resultsListBox.Location = new Point(12, 99);
            resultsListBox.Margin = new Padding(4, 3, 4, 3);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(366, 352);
            resultsListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AcceptButton = generateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(390, 509);
            Controls.Add(resultsListBox);
            Controls.Add(generateButton);
            Controls.Add(groupBoxInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(347, 398);
            Name = "Form1";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiplication Table Generator";
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberInput).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox resultsListBox;
    }
}