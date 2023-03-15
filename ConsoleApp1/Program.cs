public class ReverseString
{
    public static void Main()
    {

        ReverseString reverseString = new ReverseString();
        string testString = "abcdefg";
        string result = reverseString.Reverse(testString);
        Console.WriteLine(result);

    }
    public string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
