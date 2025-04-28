namespace WorkWithText
{
    public class TextUtilsLibrary
    {
        public string GetLongestWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return string.Empty;

            var words = word.Split(new[] { ' ', '\t', '\r', '\n', '.', ',', ';', ':', '!', '?', '-', '"' }, StringSplitOptions.RemoveEmptyEntries);

            return words.OrderByDescending(w => w.Length).FirstOrDefault() ?? string.Empty;
        }
    }
}
