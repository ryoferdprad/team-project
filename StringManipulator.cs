namespace StringManipulationLib
{
    public class StringManipulator
    {
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Analyze(string input)
        {
            int characterCount = input.Length;
            int wordCount = CountWords(input);
            string reversedString = ReverseString(input);

            return $"Analysis:\n" +
                   $"- Character Count: {characterCount}\n" +
                   $"- Word Count: {wordCount}\n" +
                   $"- Reversed String:\n{reversedString}";
        }

        private static int CountWords(string input)
        {
            int wordCount = 0;
            bool isWord = false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (!isWord)
                    {
                        wordCount++;
                        isWord = true;
                    }
                }
                else
                {
                    isWord = false;
                }
            }

            return wordCount;
        }
    }
}
