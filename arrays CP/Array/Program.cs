// EXERCISE 1
/*
int[] UserInput = new int[21];
for (int i = 1; i < UserInput.Length; i++)
{
    UserInput[i] = i;
    Console.Write($"Please input number #{UserInput[i]}: ");
    string User = Console.ReadLine();
    if (CheckInput(User)) { UserInput[i] = int.Parse(User); } else { Environment.Exit(0); }
    //Console.WriteLine(UserInput[i]);
}

Console.WriteLine("User input in reverse !");
int count = 1;
for (int x = UserInput.Length-1; x > 0; x--)
{
    Console.WriteLine($"User reverse {count}: {UserInput[x]}");
    count++;
}
*/
bool CheckInput(string a)
{
    if (a == "" || a == null)
    {
        Console.WriteLine($"User input empty!");
        return false;
    }
    else
    {
        bool String_to_int = int.TryParse(a, out int result);
        if (String_to_int) {return true;}
        Console.WriteLine("Wrong user input!");
        return false;
    }
}

//EXERCISE 2
/*
Console.Write("How many number you want to input: ");
string Answer = Console.ReadLine();
if (!CheckInput(Answer)) { Environment.Exit(0); }
int[] UserInput = new int[int.Parse(Answer)+1];
for (int i = 1; i < UserInput.Length; i++)
{
    UserInput[i] = i;
    Console.Write($"Please input number #{UserInput[i]}: ");
    string User = Console.ReadLine();
    if (CheckInput(User)) { UserInput[i] = int.Parse(User); } else { Environment.Exit(0); }
    //Console.WriteLine(UserInput[i]);
}

float Average = 0;
for (int i = 1; i < UserInput.Length; i++)
{
    //Console.WriteLine(UserInput[i]);
    Average += UserInput[i];
}
float Result = Average / float.Parse(Answer);
Console.WriteLine($"Average is equal: {Result}");
*/
//EXERCISE 3
/*
Console.Write("How many number you want to input: ");
string Answer = Console.ReadLine();
if (!CheckInput(Answer)) { Environment.Exit(0); }
int[] UserInput = new int[int.Parse(Answer) + 1];
string[] Numbers = new string[UserInput.Length];
for (int i = 1; i < UserInput.Length; i++)
{
    UserInput[i] = i;
    Console.Write($"Please input number #{UserInput[i]}: ");
    string User = Console.ReadLine();
    if (CheckInput(User)) { if (int.Parse(User) > 0 && int.Parse(User) < 6) { UserInput[i] = int.Parse(User); } else { Environment.Exit(0); } } else { Environment.Exit(0); }
    Numbers[UserInput[i]] += "*";
}

for (int i = 1; i < Numbers.Length; i++)
{
    Console.WriteLine(i + ": " +Numbers[i]);
}
*/
//EXERCISE 6

