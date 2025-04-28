namespace WorkWithText
{
    public class TextUtilsLibrary
    {
        public static string ReplaceSymbol(string input, char target, char replacement)
        {
            return input.Replace(target, replacement);
        }

        public static int CountCharacterOccurrences(string input, char character)
        {
            return input.Count(c => c == character);
        }
    }
}
