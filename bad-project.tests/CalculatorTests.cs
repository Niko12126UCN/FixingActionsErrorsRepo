namespace bad_project.tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsIncorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(4, calc.Add(2, 2)); // Fejlen her: 2+2=4, ikke 5
    }

    [Fact]
    public void AddMultipleNumbers()
    {
        var calc = new Calculator();

        var currentSum = 0;

        for (int i = 0; i < 6; i++)
        {
            int number = 3;
            currentSum = calc.Add(number, currentSum);
        }

        Assert.Equal(18, currentSum);
    }


}
