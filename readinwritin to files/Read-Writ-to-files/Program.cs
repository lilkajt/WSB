/*using (StreamWriter S_W = new StreamWriter(@"C:\Users\admin\source\repos\lilkajt\WSB\readinwritin to files\Write-Read\book.txt"))
{
    //Console.WriteLine("")
    S_W.WriteLine("Kajetan\nSzln");
    S_W.Close();
}
*/


StreamReader S_R = new StreamReader(@"C:\Users\admin\source\repos\lilkajt\WSB\readinwritin to files\Write-Read\book.txt");
    int WordCount = 0;
    int[] Number = new int[20];
while (!S_R.EndOfStream)
{
    //Console.WriteLine(S_R.ReadLine());
    string line = S_R.ReadLine();
    string[] words = line.Split(" ");
    for (int i = 0; i < words.Length; i++)
    {
        WordCount++;
        if (words[i].Length !> 20)
        {
            Number[ words[i].Length ]++;
        }
    }
}
Console.WriteLine($"This many words: {WordCount}");
S_R.Close();
for (int i = 0; i < Number.Length; i++)
{
    Console.WriteLine(Number[i]);
}