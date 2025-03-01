// filepath: /g:/My Drive/elevAlte - Microsoft Learning/xUnit_test/TestProject1_elevAlte/UnitTest1.cs
namespace TestProject1_elevAlte;

using Xunit;
using MyApp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }
}
