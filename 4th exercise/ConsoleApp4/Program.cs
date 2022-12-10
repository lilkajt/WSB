﻿/*
string Raw_a = Console.ReadLine();
if (Raw_a == "")
{
    Console.WriteLine("User input is empty");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    if (TryParseuserInputA)
    {

    }
    else
    {
        Console.WriteLine("Input is not a number");
        Console.ReadLine();
    }
}
*/

//EXERCISE 1
/*
Console.Write("Please write your name: ");
string Name = Console.ReadLine();
Console.Write("Please write your surname: ");
string SurName = Console.ReadLine();
Console.Write("Please write your street: ");
string street = Console.ReadLine();
Console.Write("Please write your house number: ");
string house_number = Console.ReadLine();
Console.Write("Please write your flat number: ");
string flat_number = Console.ReadLine();
Console.Write("Please write your zip code: ");
string zip_code = Console.ReadLine();
Console.Write("Please write your city: ");
string city = Console.ReadLine();

Console.WriteLine($"\nYour data:\n{Name} {SurName}\nSt. {street} {house_number}/{flat_number}\n{zip_code} {city}");
*/
//EXERCISE 2
/*
Console.WriteLine($"Choose from list:\n1.New game\n2.About the author\n3.Quit\n");
string Raw_a = Console.ReadLine();
Start(Raw_a);
void Start(string UserInput)
{
    if (CheckInput(UserInput))
    {
        if ((int)Menu.New_game == int.Parse(UserInput))
        {
            New_game();
        }
        else if ((int)Menu.Author == int.Parse(UserInput))
        {
            Author();
        }
        else if ((int)Menu.Quit == int.Parse(UserInput))
        {
            QuitConfirm();
        }
        else
        {
            Console.WriteLine("Input number not found in list");
            Environment.Exit(0);
        }
    }
}

void QuitConfirm()
{
    Console.Write("Type 'Confirm' if you want to quit the program!");
    string Confirmation = Console.ReadLine();
    if (Confirmation == "Confirm")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Choose from list:\n1.New game\n2.About the author\n3.Quit\n");
        string ConfirmInput = Console.ReadLine();
        Start(ConfirmInput);
    }
}

void Author()
{
    Console.Clear();
    Console.WriteLine("Here is some info about Author of this program.");
    Console.WriteLine("Yello welcome\n");
    Console.WriteLine($"Choose from list:\n1.New game\n2.About the author\n3.Quit\n");
    string Input = Console.ReadLine();
    Start(Input);
}
void New_game()
{
    Console.Clear();
    Console.WriteLine("NEW GAME!");
    Console.WriteLine($"Choose from list:\n1.New game\n2.About the author\n3.Quit\n");
    string Input = Console.ReadLine();
    Start(Input);
}

bool CheckInput(string x)
{
    if (x == "")
    {
        Console.WriteLine("User input is empty");
        return false;
    }
    else
    {
        bool TryParseuserInputA = int.TryParse(x, out int Number);
        if (TryParseuserInputA)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Input is not a number");
            return false;
        }
    }
}

enum Menu
{
    New_game = 1,
    Author,
    Quit
}
*/

//EXERCISE 4
int GameCheckDRAW = 0;
string[] Array = new string[9];
GameTicTacToe();
void GameTicTacToe()
{
    bool XTrueFalse = true;
    bool OTrueFalse = true;
    Start();
    while (true)
    {
        if (XTrueFalse)
        {
            Console.Write("X's move: ");
            string X_move = Console.ReadLine();
            XsTurn(X_move);
            XTrueFalse = false;
            OTrueFalse = true;
        }
        CheckGameScore();
        if (OTrueFalse)
        {
            Console.Write("O's move: ");
            string O_move = Console.ReadLine();
            OsTurn(O_move);
            OTrueFalse = false;
            XTrueFalse = true;
        }
        CheckGameScore();
    }
}
void Start()
{
    Console.WriteLine("Welcome to tic tac toe ");
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = " ";
    }
    BoardDisplay();
}
void XsTurn(string X)
{
    if (CheckInput(X))
    {
        int Number = int.Parse(X);
        if (Number > 0 && Number < 10)
        {
            if (Array[Number - 1] != "X" && Array[Number - 1] != "O")
            {
                Array[Number - 1] = "X";
                BoardDisplay();
            }
            else
            {
                Console.WriteLine("X can not be placed here");
                XsRepeat();
            }
        }
        else
        {
            Console.WriteLine("User input out of range");
            XsRepeat();
        }
    }
    else
    {
        XsRepeat();
    }
}
//NOT OPTIMIZED
void CheckGameScore()
{
    if (Array[0] == "X" && Array[1] == "X" && Array[2] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[3] == "X" && Array[4] == "X" && Array[5] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[6] == "X" && Array[7] == "X" && Array[8] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[2] == "X" && Array[5] == "X" && Array[8] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[1] == "X" && Array[4] == "X" && Array[7] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[0] == "X" && Array[3] == "X" && Array[6] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[2] == "X" && Array[4] == "X" && Array[6] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[0] == "X" && Array[4] == "X" && Array[8] == "X") { Console.WriteLine("THE WINNER IS X!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[0] == "O" && Array[1] == "O" && Array[2] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[3] == "O" && Array[4] == "O" && Array[5] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[6] == "O" && Array[7] == "O" && Array[8] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[2] == "O" && Array[5] == "O" && Array[8] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[1] == "O" && Array[4] == "O" && Array[7] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[0] == "O" && Array[3] == "O" && Array[6] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[2] == "O" && Array[4] == "O" && Array[6] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (Array[0] == "O" && Array[4] == "O" && Array[8] == "O") { Console.WriteLine("THE WINNER IS O!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    else if (GameCheckDRAW == 8) { Console.Clear();Console.WriteLine("DRAW = NO WINNER!"); GameCheckDRAW = 0 ;BoardDisplay();RestartGame(); }
    GameCheckDRAW += 1;
}
void OsTurn(string O)
{
    if (CheckInput(O))
    {
        int Number = int.Parse(O);
        if (Number > 0 && Number < 10)
        {
            if (Array[Number - 1] != "X" && Array[Number - 1] != "O")
            {
                Array[Number - 1] = "O";
                BoardDisplay();
            }
            else
            {
                Console.WriteLine("O can not be placed here");
                OsRepeat();
            }
        }
        else
        {
            Console.WriteLine("User input out of range");
            OsRepeat();
        }
    }
    else
    {
        OsRepeat();
    }
}
void OsRepeat()
{
    Console.WriteLine("TRY AGAIN!");
    Console.Write("O's move: ");
    string O_move_repeat = Console.ReadLine();
    OsTurn(O_move_repeat);
}
void XsRepeat()
{
    Console.WriteLine("TRY AGAIN!");
    Console.Write("X's move: ");
    string X_move_repeat = Console.ReadLine();
    XsTurn(X_move_repeat);
}
void RestartGame()
{
    Console.WriteLine($"Choose from list:\n1.New game\n2.About the author\n3.Quit\n");
    string AnswerRestart = Console.ReadLine();
    if (CheckInput(AnswerRestart))
    {
        if ((int)Game.New_game == int.Parse(AnswerRestart))
        {
            Console.Clear();
            Console.WriteLine("NEW GAME\n");
            GameTicTacToe();
        }
        else if ((int)Game.Author == int.Parse(AnswerRestart))
        {
            Console.Clear();
            Console.WriteLine("Here's some information about Author of this program\n");
            RestartGame();
        }
        else if ((int)Game.Exit == int.Parse(AnswerRestart))
        {
            Console.Clear();
            ExitConfirm();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Input number not found in list");
            RestartGame();
        }
    }
    else
    {
        Console.Clear();
        RestartGame();
    }
}
void BoardDisplay()
{
    Console.WriteLine($" {Array[0]} | {Array[1]} | {Array[2]} ");
    Console.WriteLine($"---+---+---");
    Console.WriteLine($" {Array[3]} | {Array[4]} | {Array[5]} ");
    Console.WriteLine($"---+---+---");
    Console.WriteLine($" {Array[6]} | {Array[7]} | {Array[8]} ");
}
bool CheckInput(string UserInput)
{
    if (UserInput == "")
    {
        Console.WriteLine("User input is empty\n");
        return false;
    }
    else
    {
        bool TryParseuserInputA = int.TryParse(UserInput, out int a);
        if (TryParseuserInputA) { return true; }
        else
        {
            Console.WriteLine("Input is not a number");
            return false;
        }
    }
}
void ExitConfirm()
{
    Console.Write("Type 'Confirm' if you want to EXIT the program!\n");
    string Confirmation = Console.ReadLine();
    if (Confirmation.ToLower() == "confirm")
    {
        Environment.Exit(0);
    }
    else
    {
        RestartGame();
    }
}
enum Game
{
    New_game = 1,
    Author,
    Exit
}