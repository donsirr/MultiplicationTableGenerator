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