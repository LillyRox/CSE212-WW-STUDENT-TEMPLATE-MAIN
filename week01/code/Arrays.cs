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
        // PLAN:
        // 1. Create an array with the size "length".
        // 2. Use a for loop to fill the array.
        // 3. Each element will be number * (i + 1).
        // 4. Return the array.
        ////////////////////////////////////////////////////////////////////////////////////////////

        /// 1. Create an array with the size "length".
        double[] multiples = new double[length];

        /// 2. Use a for loop to fill the array.
        for (int i = 0; i < length; i++)
        {
            /// 3. Each element will be number * (i + 1).
            multiples[i] = number * (i + 1);
        }

        /// 4. Return the array.
        return multiples;
        // TODO Problem 1 End   
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
        // PLAN:
        // 1. Validate that data is not null and contains elements.
        // 2. Normalize 'amount' just in case (amount % data.Count).
        // 3. Calculate the split index: splitIndex = data.Count - amount.
        // 4. Get the last 'amount' elements using GetRange.
        // 5. Remove that portion from the original list using RemoveRange.
        // 6. Insert the extracted portion at the beginning using InsertRange(0, endPart).
        // 7. The list 'data' will now be rotated in place; no return value is needed (void).

        // 1. Validate that data is not null and contains elements.
        if (data == null || data.Count == 0)
            return;

        // 2. Normalize 'amount'
        amount = amount % data.Count;
        if (amount == 0)
            return;

        // 3. Calculate the split index: splitIndex = data.Count - amount.
        int splitIndex = data.Count - amount;

        // 4. Get the last 'amount' elements using GetRange.
        List<int> endPart = data.GetRange(splitIndex, amount);

        // 5.  Remove that portion from the original list using RemoveRange.
        data.RemoveRange(splitIndex, amount);

        // 6. Insert the extracted portion at the beginning using InsertRange(0, endPart).
        data.InsertRange(0, endPart);

        // 7.The list 'data' will now be rotated in place; no return value is needed (void).{
        // TODO Problem 2 End   
    }

}
