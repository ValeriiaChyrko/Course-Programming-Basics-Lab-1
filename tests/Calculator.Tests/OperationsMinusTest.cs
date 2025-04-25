namespace Calculator.Tests;

[TestFixture]
public sealed class OperationsMinusTests
{
    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(1, 0, ExpectedResult = 1)]
    [TestCase(0, 1, ExpectedResult = -1)]
    [TestCase(1, 1, ExpectedResult = 0)]
    public int Minus(int x, int y)
    {
        return OperationsMinus.Minus(x, y);
    }

    [TestCase(0, 0, 0, ExpectedResult = 0)]
    [TestCase(10, 5, 2, ExpectedResult = 3)]
    [TestCase(10, 5, 3, ExpectedResult = 2)]
    [TestCase(20, 10, 5, ExpectedResult = 5)]
    public int MinusThree(int x, int y, int z)
    {
        return OperationsMinus.MinusThree(x, y, z);
    }

    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(5, 2, ExpectedResult = 3)]
    [TestCase(10, 7, ExpectedResult = 3)]
    [TestCase(-5, 5, ExpectedResult = -10)]
    public int MinusRevision(int x, int y)
    {
        return OperationsMinus.MinusRevision(x, y);
    }
}