namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("([)", false)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void Test(string s, bool expected)
    {
        var result = Solution.IsValid(s);

        Assert.Equal(expected, result);
    }
}
