public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Step 1: Create an array with size equal to the number of multiples needed.
        // Step 2: Use a loop to go through each position in the array.
        // Step 3: For each index, calculate the multiple using number * (index + 1).
        // Step 4: Store the result in the array.
        // Step 5: Return the completed array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1,2,3,4,5,6,7,8,9} and amount is 3 then the list becomes  
    /// List<int>{7,8,9,1,2,3,4,5,6}.  
    /// The value of amount will be between 1 and data.Count.
    ///
    /// Because a list is dynamic, this function modifies the existing list instead of returning a new one.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Step 1: Determine the index where the list should be split.
        // Step 2: Extract the last 'amount' elements from the list.
        // Step 3: Extract the first part of the list before the split.
        // Step 4: Clear the original list.
        // Step 5: Add the last elements first.
        // Step 6: Add the first elements after them.

        int splitIndex = data.Count - amount;

        List<int> endPart = data.GetRange(splitIndex, amount);
        List<int> startPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}