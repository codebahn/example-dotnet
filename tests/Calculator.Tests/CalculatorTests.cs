using Xunit;

namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsSum(double a, double b, double expected)
    {
        Assert.Equal(expected, _calc.Add(a, b));
    }

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(0, 5, -5)]
    [InlineData(-2, -3, 1)]
    public void Subtract_ReturnsDifference(double a, double b, double expected)
    {
        Assert.Equal(expected, _calc.Subtract(a, b));
    }

    [Theory]
    [InlineData(4, 5, 20)]
    [InlineData(-3, 7, -21)]
    [InlineData(0, 100, 0)]
    public void Multiply_ReturnsProduct(double a, double b, double expected)
    {
        Assert.Equal(expected, _calc.Multiply(a, b));
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(7, 3, 2.3333333333333335)]
    [InlineData(-9, 3, -3)]
    public void Divide_ReturnsQuotient(double a, double b, double expected)
    {
        Assert.Equal(expected, _calc.Divide(a, b));
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(1, 0));
    }
}
