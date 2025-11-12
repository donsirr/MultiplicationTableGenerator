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

        // Event
        private void generateButton_Click(object sender, EventArgs e)
        {
            // 1. Clear any old results from the ListBox
            resultsListBox.Items.Clear();

            int number;

            // 2. Validate the input from the TextBox
            // int.TryParse is safer than int.Parse because it won't crash
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // 3. Create an "instance" of your logic class
                TableGenerator generator = new TableGenerator();

                // 4. Call the method to get the results
                List<string> results = generator.Generate(number);

                // 5. Display the results in the ListBox
                // We loop through the list and add each item
                foreach (string line in results)
                {
                    resultsListBox.Items.Add(line);
                }
            }
            else
            {
                // 6. Show an error message if the input was not valid
                MessageBox.Show("Please enter a valid whole number.", "Input Error");

                // Optional: Select the bad text so the user can easily fix it
                numberTextBox.SelectAll();
                numberTextBox.Focus();
            }
        }
    }
}
