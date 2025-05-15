namespace Calculator;

public static class OperationsDivide
{
    public static double DivideBySquare(int x)
    {
        // Example: DivideBySquare(4) should return 0.25 (4 / 16).
        return x / (x*x);
    }

    public static bool CanSplitPieFairly(int totalSlices, int numberOfRecipients, int slicesPerPerson)
    {
        // TODO #2. Write a method that determines whether it's possible to split a pie fairly.
        // A fair split is possible if the total number of slices is equal to the product of the number of recipients and slices per person.
        // Example: CanSplitPieFairly(8, 2, 4) should return true.
        if (numberOfRecipients <= 0) throw new ArgumentException("Number of recipients must be greater than zero.");
        throw new NotImplementedException();
    }

    public static bool LastDigitOfDivisionEquals(int x, int y, int z)
    {
        // TODO #3. Create a function that takes 3 numbers: x, y, z
        // and returns true if the last digit of x / y equals z.
        // Example: LastDigitOfDivisionEquals(10, 3, 3) should return true (10 / 3 = 3.33, last digit is 3).
        throw new NotImplementedException();
    }
}
