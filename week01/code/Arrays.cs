public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Steps
        // Step 1: Return array that has exactly 'length' elements
        // Step 2: First element (index 0) needs to be number * 1
        // Step 3: Second element (index 1) needs to be number * 2
        // Step 4: Continue until the last element (index length - 1) = number * length
        // Step 5: Create a new array of doubles to hold the multiples of the number
        // Step 6: After the loop finishes filling the array, return the array

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Steps
        // Step 1: Move the last "amount" elements of the list to the front (shifting the first (data.Count - amount) elements to the end)
            // Example: data = [1, 2, 3, 4, 5, 6, 7, 8, 9]
            // Result: Amount = 3 --> new order is [7, 8, 9, 1, 2, 3, 4, 5, 6]
        // Step 2: Create a new list to hold the temporary list
        // Step 3: Add the last "amount" elements to the new list first
        // Step 4: Add the first (data.Count - amount) elements to the new list
        // Step 5: Clear the original list and add the elements from the new list back to the original list
            //This allows for the list to rotate even when ammount = data.Count

        if (data == null || data.Count == 0 || amount == 0)
        {
            return;
        }

        List<int> rotated = new List<int>();
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        for (int i = 0; i < data.Count - amount; i++)
        {
            rotated.Add(data[i]);
        }

        data.Clear();
        foreach (int num in rotated)
        {
            data.Add(num);
        }
    }
}
