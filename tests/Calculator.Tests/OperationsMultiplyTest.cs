namespace Calculator.Tests;

[TestFixture]
public sealed class OperationsMultiplyTests
{
    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(1, 0, ExpectedResult = 0)]
    [TestCase(0, 1, ExpectedResult = 0)]
    [TestCase(1, 1, ExpectedResult = 1)]
    public int Multiply(int x, int y)
    {
        return OperationsMultiply.Multiply(x, y);
    }

    [TestCase(0, ExpectedResult = 0)]
    [TestCase(2, ExpectedResult = 4)]
    [TestCase(3, ExpectedResult = 9)]
    [TestCase(-3, ExpectedResult = 9)]
    [TestCase(5, ExpectedResult = 25)]
    public int MultiplySquare(int x)
    {
        return OperationsMultiply.MultiplySquare(x);
    }

    [TestCase(1, ExpectedResult = 365)]
    [TestCase(2, ExpectedResult = 730)]
    [TestCase(10, ExpectedResult = 3650)]
    [TestCase(18, ExpectedResult = 6570)]
    [TestCase(50, ExpectedResult = 18250)]
    public int CalcAge(int years)
    {
        return OperationsMultiply.CalcAge(years);
    }
}