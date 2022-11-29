internal class PigLatin
{
    private static void Main(string[] args)
    {
        Console.Write("User input word: ");
        string ask = Console.ReadLine();
        //EXercise 1
        /*
        string WordWithOutFirstLatter = ask.Substring(1);
        //Console.WriteLine(ask.Substring(1));
        Console.WriteLine(WordWithOutFirstLatter+ask[0]+"ay");
        */
        //hi whats up
        //ihay hatsway puay
        //my way of coding
        /*
        string[] words = ask.Split();
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i].Substring(1) + words[i][0] + "ay ");
        }
        */
        //Teacher explanation
        string Trask = TranslatedSentence(ask);
        Console.WriteLine($"In pig latin: {Trask}");
    }
    static string TranslateSingleWord(string word)
    {
        string TranslatedWord = word.Substring(1) + word[0] + "ay ";
        return TranslatedWord;
    }
    static string TranslatedSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        string TrSentence = "";
        for (int i = 0; i < words.Length; i++)
        {
            TrSentence += $"{TranslateSingleWord(words[i])}";
        }
        return TrSentence;
    }
}