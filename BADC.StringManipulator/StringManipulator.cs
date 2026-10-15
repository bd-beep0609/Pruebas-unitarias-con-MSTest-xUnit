namespace BADC.StringManipulator
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            
            char[] charArray = input.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            
            return input.Replace(" ", "");
        }
    }
}