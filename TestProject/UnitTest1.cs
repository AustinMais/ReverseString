namespace TestProject
{
    public class UnitTest1
    {
        //Test to do basic reversing of first few letters of alphabet
        [Fact]
        public void TestReverseString()
        {
            ReverseString reverseString = new ReverseString();
            string testString = "abcdefg";
            string result = reverseString.Reverse(testString);

            Assert.Equal("gfedcba", result);
        }
    }
}