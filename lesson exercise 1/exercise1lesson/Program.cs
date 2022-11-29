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
string[] words = ask.Split();
for (int i = 0; i < words.Length; i++)
{
    Console.Write(words[i].Substring(1) + words[i][0] +"ay ");
}
