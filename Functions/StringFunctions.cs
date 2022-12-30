namespace ConsoleApp1.Functions;

public static class StringFunctions
{
    // get words from string content
    public static IEnumerable<string> GetWords(string stringContent)
    {
        var splittedWords = stringContent.ToLower().Split(new Char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return splittedWords;
    }

    // count words in ienumerable, and store to the dictionary
    public static SortedDictionary<String, int> CountWords(IEnumerable<string> words)
    {
        var dict = new SortedDictionary<String, int>();
        
        foreach (var word in words)
        {
            var trimmed = word.Trim();
            if(!string.IsNullOrEmpty(trimmed)){
                if (!dict.ContainsKey(trimmed))
                {
                    dict.Add(trimmed, 1);
                }
                else
                {
                    dict[trimmed]++;
                }
            }
        }
        return dict;
    }
}
