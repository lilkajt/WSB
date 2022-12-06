Random rand = new Random();
//int number = rand.Next(1, 100);
//FizzBuzz(number);
//
//Console.WriteLine("");
/*
while (true) {
    Console.Write("Guess the number: ");
    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("No user input");
    }
    else
    {
        bool UserInput_to_int = int.TryParse(input, out int User_output);
        if (UserInput_to_int)
        {
            if (User_output == number)
            {
                Console.WriteLine($"Congratulations, You guess the number {number}");
                Environment.Exit(0);
            }
            else if (User_output > number)
            {
                Console.WriteLine($"Your number {User_output} is too high");
            }
            else if (User_output < number)
            {
                Console.WriteLine($"Your number {User_output} is too low");
            }
        }
        else
        {
            Console.WriteLine("User input is incorrect!");
        }
    }
}

void FizzBuzz(int x)
{
    for (int i = 1; i <= x; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
        else if  (i % 3 == 0) { Console.WriteLine("Fizz"); }
        else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
        else { Console.WriteLine(i); }
    }
}
*/
/* computer guessing number
Console.Write("Guess the number: ");
string input = Console.ReadLine();
int result = int.Parse(input);
if (input == "")
{
    Console.WriteLine("No user input");
}
else
{
    bool UserInput_to_int = int.TryParse(input, out int User_output);
    if (UserInput_to_int)
    {
        if (!(User_output >= 1 && User_output <= 100))
        {
        Console.WriteLine("User input out of range");
            Environment.Exit(0);
        }
    }
    else
    {
        Console.WriteLine("User input is incorrect!");
    }
}
bool Game_ends = true;
int Tries = 0;
int number = rand.Next(1, 101);
int MinNumber = 1;
int MaxNumber = 101;
while (Game_ends)
{
    if (number == result)
    {
        Console.WriteLine($"Congratulations, you guessed! {number}. In {Tries} tries");
        Game_ends = false;
    }
    else if (number < result)
    {
        Console.WriteLine("Number is too low");
        MinNumber = number;
        number = rand.Next(MinNumber, MaxNumber);
    }
    else if (number > result)
    {
        Console.WriteLine("Number is too high");
        MaxNumber = number;
        number = rand.Next(MinNumber, MaxNumber);
    }
    Tries += 1;
}
*/

//GAME
Console.WriteLine("Choose options");
Console.WriteLine("1.You guess the number");
Console.WriteLine("2. Computer guesses your number");
string input = Console.ReadLine();
//int result = int.Parse(input);
UserCheck(input);
void UserCheck(string UserInput)
{
    if (UserInput == "")
    {
        Console.WriteLine("No user input");
    }
    else
    {
        bool UserInput_to_int = int.TryParse(UserInput, out int User_output);
        if (UserInput_to_int)
        {
            if (User_output == 1)
            {
                UserGuessesNumber();
            }
            else if (User_output == 2)
            {
                ComputerGuessesNumber();
            }
            else { Console.WriteLine("Wrong input"); }
        }
        else
        {
            Console.WriteLine("User input is incorrect!");
        }
    }
}
void ComputerGuessesNumber()
{
    bool Game_ends = true;
    int Tries = 0;
    int MinNumber = 1;
    int MaxNumber = 101;
    int RandomNumber = rand.Next(MinNumber, MaxNumber);
    Console.WriteLine("");
    Console.WriteLine("Computer guesses your number!");
    Console.WriteLine("");

    Console.Write("Your number: ");
    string InputUserNumber = Console.ReadLine();
    bool StringUsertoNumber = int.TryParse(InputUserNumber, out int UNumber);
    if (StringUsertoNumber)
    {
        while (Game_ends)
        {
            if (UNumber == RandomNumber)
            {
                Console.WriteLine($"Congratulations, you guessed! {RandomNumber}. In {Tries} tries");
                Game_ends = false;
            }
            else if (UNumber > RandomNumber)
            {
                Console.WriteLine("Number is too low");
                MinNumber = RandomNumber;
                RandomNumber = rand.Next(MinNumber, MaxNumber);
            }
            else if (UNumber < RandomNumber)
            {
                Console.WriteLine("Number is too high");
                MaxNumber = RandomNumber;
                RandomNumber = rand.Next(MinNumber, MaxNumber);
            }
            Tries += 1;
        }
    }
}
void UserGuessesNumber()
{
    int RandomNumber = rand.Next(1, 101);
    int Tries = 0;
    Console.WriteLine("");
    Console.WriteLine("You guess the number!");
    Console.WriteLine("");
    Console.WriteLine("Number generated!");
    while (true)
    {
        Console.Write("Your guess: ");
        string Guess = Console.ReadLine();
        bool StringGuessToInt = int.TryParse(Guess, out int GuessNumber);
        if (StringGuessToInt)
        {
            if (GuessNumber == RandomNumber)
            {
                Console.WriteLine($"Congratulations, you won! Number = {GuessNumber} ! In {Tries} tries.");
                Environment.Exit(0);
            }
            else if (GuessNumber > RandomNumber)
            {
                Console.WriteLine("Number too high");
                Tries += 1;
            }
            else if (GuessNumber < RandomNumber)
            {
                Console.WriteLine("Number too low");
                Tries += 1;
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}