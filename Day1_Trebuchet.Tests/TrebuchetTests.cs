namespace Day1_Trebuchet.Tests;

[TestClass]
public class TrebuchetTests
{
    [TestMethod]
    public void NoNumbers()
    {
        // arrange
        string input = "";
        int expected = 0;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void OnlyText()
    {
        // arrange
        string input = "nonumbers";
        int expected = 0;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void OneNumbers()
    {
        // arrange
        string input = "1";
        int expected = 11;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TwoNumbers()
    {
        // arrange
        string input = "12";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TextBeforeTwoNumbers()
    {
        // arrange
        string input = "hello12";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TextAfterTwoNumbers()
    {
        // arrange
        string input = "12hello";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MultipleNumbers()
    {
        // arrange
        string input = "12345";
        int expected = 15;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void SpecialCharacters()
    {
        // arrange
        string input = "/,.-*;'";
        int expected = 0;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TextInBetweenTwoNumbers()
    {
        // arrange
        string input = "1hello2";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TextBeforeAndInBetweenTwoNumbers()
    {
        // arrange
        string input = "hello1hello2";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TextInBetweenAndAfterTwoNumbers()
    {
        // arrange
        string input = "1hello2hello";
        int expected = 12;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void MixTextAndNumbers()
    {
        // arrange
        string input = "text1is2every3where";
        int expected = 13;

        // act
        int result = Program.ComputeLine(input);

        // assert
        Assert.AreEqual(result, expected);
    }
}
