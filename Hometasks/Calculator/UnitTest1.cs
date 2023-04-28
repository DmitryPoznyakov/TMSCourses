using NUnit.Framework;

namespace Calculator;

[TestFixture]

public class Tests
{
    Calculator calculator = new();

    [SetUp]
    public void SetupForEeachMethod()
    {
        calculator = new Calculator();
    }

    //SUMM

    [Test, Description("Calculator's addition function testing")]
    [Category("Calculator Test")]
    [TestCase(3, 5, ExpectedResult = 8)]
    [TestCase(-3, 5, ExpectedResult = 2)]
    [TestCase(-3, -5, ExpectedResult = -8)]
    [TestCase(3, 0, ExpectedResult = 3)]

    public int SummTest(int operand1, int operand2)
    {
        var ActualResult = calculator.Summ(operand1, operand2);
        return ActualResult;
    }

    //SUBSTRACTION

    [Test, Description("Calculator's subtraction function testing")]
    [Category("Calculator Test")]

    public void MinusTest(
        [Values(5,10)] int operand1,
        [Range(1,10,4)] int operand2)
    {
        var ActualResult = calculator.Minus(operand1, operand2);
        var ExpectedResult = operand1 - operand2;
        
        Assert.That(ExpectedResult, Is.EqualTo(ActualResult), $"Incorrect result of Minus operation: {operand1} - {operand2} = {ActualResult}");
        
    }

    //DIVIDE

    [Test, Description("Calculator's divide function testing")]
    [Category("Calculator Test")]
    [Retry(2)]

    public void DivideTest(
        [Values(8,16,32, 0)] int operand1,
        [Range(2,8,2)] int operand2)
    {
        int ActualResult = calculator.Divide(operand1, operand2);
        int ExpectedResult = operand1 / operand2;

        Assert.That(ExpectedResult, Is.EqualTo(ActualResult), $"Incorrect result of Minus operation: {operand1} - {operand2} = {ActualResult}");
        Assert.That(ActualResult != 0, "The actual result equals 0");
    }

    //MULTIPLY

    [Test, Description("Calculator's multiply function testing")]
    [Category("Calculator Test")]

    public void MultiplyTest(
        [Values(1,5,10)] int operand1,
        [Random(1, 10, 4)] int operand2)
    {
        var ActualResult = calculator.Multiply(operand1, operand2);
        var ExpectedResult = operand1 * operand2;

        Assert.AreEqual(ExpectedResult, ActualResult, $"Incorrect result of Multiply operation: {operand1} * {operand2} = {ActualResult}");
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        Console.WriteLine("Test run funished");
    }
}

