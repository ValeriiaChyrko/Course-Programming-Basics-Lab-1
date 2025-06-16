namespace Calculator;

public static class OperationsMultiply
{
    public static int Multiply(int x, int y)
    {
        // Add a breakpoint to the next line, run the unit test in the debug mode, and inspect the result during the program execution.
        int result = x * y;
        return result;
    }
    
    public static int MultiplySquare(int x)
    {
        // Write a method that calculates the square of a number
        var unused = 32;
        return x * x;
    }
    
    public static int CalcAge(int x)
    {
        // Write a method that c that takes the age in years and returns the age in days.
        // Use 365 days as the length of a year for this challenge. Ignore leap years and days between last birthday and now.
        return x * 365;
    }
}