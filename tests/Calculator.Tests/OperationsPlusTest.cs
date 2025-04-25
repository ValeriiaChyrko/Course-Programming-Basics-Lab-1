namespace Calculator.Tests;

[TestFixture]
public sealed class OperationsPlusTests
{
    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(1, 0, ExpectedResult = 1)]
    [TestCase(0, 1, ExpectedResult = 1)]
    [TestCase(1, 1, ExpectedResult = 2)]
    public int Plus(int x, int y)
    {
        return OperationsPlus.Plus(x, y);
    }

    [TestCase(0, 0, 0, ExpectedResult = 0)]
    [TestCase(1, 1, 1, ExpectedResult = 3)]
    [TestCase(-1, 1, 0, ExpectedResult = 0)]
    [TestCase(10, 20, 30, ExpectedResult = 60)]
    public int PlusThree(int x, int y, int z)
    {
        return OperationsPlus.PlusThree(x, y, z);
    }

    [TestCase(0, ExpectedResult = 0)]
    [TestCase(1, ExpectedResult = 2)] 
    [TestCase(2, ExpectedResult = 6)] 
    [TestCase(-1, ExpectedResult = 0)] 
    [TestCase(-2, ExpectedResult = 2)] 
    public int PlusDouble(int x)
    {
        return OperationsPlus.PlusDouble(x);
    }
}