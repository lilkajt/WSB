Console.Write("User input word: ");
string ask = Console.ReadLine();
string WordWithOutFirstLatter = ask.Substring(1);
//Console.WriteLine(ask.Substring(1));
Console.WriteLine(WordWithOutFirstLatter+ask[0]+"ay");