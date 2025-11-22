# Form1.cs

```cs
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
```

---

# TableGenerator.cs

```cs
using System;
using System.Collections.Generic;

public class TableGenerator
{
    // It takes the user's number and returns a List of strings
    public List<string> Generate(int baseNumber, int limit = 10)
    {
        // We use a List<string> because it's a flexible way to return multiple lines of text
        List<string> tableLines = new List<string>();

        // Standard for loop to count from 1 to the limit
        for (int i = 1; i <= limit; i++)
        {
            // Calculate the result
            int result = baseNumber * i;

            // Format the output string clearly
            string line = $"{baseNumber} x {i} = {result}";

            // Add the new line to our list
            tableLines.Add(line);
        }

        // Return the complete list to whoever called the method
        return tableLines;
    }
}
```
