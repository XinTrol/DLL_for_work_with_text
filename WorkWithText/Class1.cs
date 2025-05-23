﻿namespace WorkWithText
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


        public int GetCountWordMeetInString(string input, string word)
        {
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(word))
            {
                return -1;
            }

            var words = input.Split(new[] { ' ', '\t', '\r', '\n', '.', ',', ';', ':', '!', '?', '-', '"' }, StringSplitOptions.RemoveEmptyEntries);

            var lowerWords = words.Select(w => w.ToLower()).ToArray();
            string lowerWord = word.ToLower();

            int count = lowerWords.Count(w => w == lowerWord);
            return count;
        }


        public int GetCountWordsInString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return -1;
            }

            var words = input.Split(new[] { ' ', '\t', '\r', '\n', '.', ',', ';', ':', '!', '?', '-', '"' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count();
            return count;
        }


      
        public static string ReplaceSymbol(string input, char target, char replacement)
        {
            return input.Replace(target, replacement);

        }

        public static int CountCharacterOccurrences(string input, char character)
        {
            return input.Count(c => c == character);
        }

        public static string ReplaceSubstring(string input, string oldSubstring, string newSubstring)
        {
            return input.Replace(oldSubstring, newSubstring);
        }



    }
}
