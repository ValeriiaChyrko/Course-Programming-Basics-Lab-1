namespace Calculator.Tests;

[TestFixture]
public class OperationsDivideTests
{
    [TestCase(4, ExpectedResult = 0.25)]
    [TestCase(2, ExpectedResult = 0.5)]
    [TestCase(1, ExpectedResult = 1.0)]
    [TestCase(-4, ExpectedResult = -0.25)]
    public double DivideBySquare(int x)
    {
        return OperationsDivide.DivideBySquare(x);
    }

    [Test]
    public void DivideBySquare_Zero_ThrowsDivideByZeroException()
    {
        // Arrange
        const int x = 0;

        // Act & Assert
        var ex = Assert.Throws<DivideByZeroException>(() => OperationsDivide.DivideBySquare(x));
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }

    [TestCase(8, 2, 4, ExpectedResult = true)]
    [TestCase(10, 5, 2, ExpectedResult = true)]
    [TestCase(7, 3, 2, ExpectedResult = false)]
    [TestCase(0, 1, 0, ExpectedResult = true)]
    public bool CanSplitPieFairly(int totalSlices, int numberOfRecipients, int slicesPerPerson)
    {
        return OperationsDivide.CanSplitPieFairly(totalSlices, numberOfRecipients, slicesPerPerson);
    }

    [Test]
    public void CanSplitPieFairly_NegativeRecipients_ThrowsArgumentException()
    {
        // Arrange
        const int totalSlices = 8;
        const int numberOfRecipients = -1;
        const int slicesPerPerson = 4;

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() =>
            OperationsDivide.CanSplitPieFairly(totalSlices, numberOfRecipients, slicesPerPerson));
        Assert.That(ex.Message, Is.EqualTo("Number of recipients must be greater than zero."));
    }

    [TestCase(10, 3, 3, ExpectedResult = true)] 
    [TestCase(20, 6, 3, ExpectedResult = true)] 
    [TestCase(15, 4, 3, ExpectedResult = false)]
    [TestCase(0, 1, 0, ExpectedResult = true)]
    public bool LastDigitOfDivisionEquals(int x, int y, int z)
    {
        return OperationsDivide.LastDigitOfDivisionEquals(x, y, z);
    }

    [Test]
    public void LastDigitOfDivisionEquals_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        const int x = 10;
        const int y = 0;
        const int z = 3;

        // Act & Assert
        var ex = Assert.Throws<DivideByZeroException>(() => OperationsDivide.LastDigitOfDivisionEquals(x, y, z));
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }
}