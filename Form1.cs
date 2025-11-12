using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiplicationTableGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // 1. Clear previous results
            resultsListBox.Items.Clear();

            // 2. Get the value from the NumericUpDown control.
            // No validation is needed, it's guaranteed to be a number!
            int number = (int)numberInput.Value;

            // 3. Create an instance of our logic class
            TableGenerator generator = new TableGenerator();

            // 4. Call the method to get the results
            List<string> results = generator.Generate(number);

            // 5. Display the results in the ListBox
            foreach (string line in results)
            {
                resultsListBox.Items.Add(line);
            }
        }
    }
}