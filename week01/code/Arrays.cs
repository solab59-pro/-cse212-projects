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
        // PLAN:
        // 1. Create a new array of type double with size = length.
        // 2. Loop from index 0 up to length - 1.
        // 3. For each index, calculate the multiple:
        //    multiple = number * (index + 1)
        // 4. Store the result in the array at the current index.
        // 5. After the loop finishes, return the array.

        // Step 1: Create an array to hold the multiples
        double[] result = new double[length];


        // Step 2: Loop through the array
        for (int i = 0; i < length; i++)
        {
        // Step 3: Calculate and store the multiple
            result[i] = number * (i + 1);
        }
        
        // Step 4: Return the completed array
        return result;
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
        // PLAN:
        // 1. Determine how many elements need to be moved from the end to the front.
        // 2. Create a temporary list to store the last 'amount' elements.
        // 3. Remove those elements from the end of the original list.
        // 4. Insert the stored elements at the beginning of the list.
        // 5. The original list is now rotated to the right.

        int count = data.Count;

        // Step 2: Get the last 'amount' elements
        List<int> tail = data.GetRange(count - amount, amount);

        // Step 3: Remove those elements from the original list
        data.RemoveRange(count - amount, amount);

        // Step 4: Insert them at the front
        data.InsertRange(0, tail);
    }
}
