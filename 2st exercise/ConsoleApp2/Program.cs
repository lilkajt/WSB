//Console.Write("Input prime number : ");
//string Raw_a = Console.ReadLine();
//  Console.Write("Input +,-,*,/: ");
//  string Raw_c = Console.ReadLine();
//Console.Write("Input number width: ");
//string Raw_b = Console.ReadLine();
/*
string b = Console.ReadLine();
if (b == null)
{
    Console.WriteLine("Input is empty!Try again");
    Console.WriteLine();
} else if (int.TryParse(b))
{
    int c = int.Parse(b);
}
else
{
    Console.WriteLine("cant convert");
    Console.ReadLine();
}
*/
/* EXERCISE 1
if (Raw_a == "")
{
    Console.WriteLine("User input is empty");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int a);
    if (TryParseuserInputA)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"{a} is odd");
            Console.ReadLine();
        }

    }
    else
    {
        Console.WriteLine("Input is not a number");
        Console.ReadLine();
    }
}
*/

/* EXERCISE 2
if (Raw_a == "" && Raw_b == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA= int.TryParse(Raw_a, out int x);
    bool TryParseuserInputB= int.TryParse(Raw_b, out int z);
    if (TryParseuserInputA && TryParseuserInputB)
    {
        double result = (x * z) / (x + z);
        Console.WriteLine($"Result of equation is {result}");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
//exercise 3
/*
if (Raw_a == "" && Raw_b == "" && Raw_c == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA= int.TryParse(Raw_a, out int x);
    bool TryParseuserInputB= int.TryParse(Raw_b, out int y);
    bool TryParseuserInputC = int.TryParse(Raw_b, out int z);

    if (TryParseuserInputA && TryParseuserInputB && TryParseuserInputC)
    {
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
/* EXERCISE 4
if (Raw_a == "" && Raw_b == "" && Raw_c == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    bool TryParseuserInputB = int.TryParse(Raw_b, out int y);
    //bool TryParseuserInputC = int.TryParse(Raw_c, out int z);
    //if (TryParseuserInputA && TryParseuserInputB && TryParseuserInputC)
    if (TryParseuserInputA && TryParseuserInputB)
    {
        switch (Raw_c)
        {
            case "/":
                double Result = x / y;
                Console.WriteLine(Result);
                break;
            case "*":
                Console.WriteLine(x * y);
                break;
            case "+":
                Console.WriteLine(x + y);
                break;
            case "-":
                Console.WriteLine(x - y);
                break;
            default:
                Console.WriteLine("Wrong arithmetic input");
                break;
        }
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
/* EXERCISE 6
if (Raw_a == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    if (TryParseuserInputA)
    {
        if (x <= 10 && x >= 1)
        {
            int result = 1;
            for (int i = x; i > 1; i--)
            {
                result = result* i;
                //Console.WriteLine(result);
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Input number must be in <1,10> range");
        }
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
/* EXERCISE 7
static void Rectangle(int w, int h)
{
    string Z="";
    for (int y = 0; y < w; y++)
    {
        Z += "*";
        //Console.WriteLine(Z);
    }
    for (int x = 0; x < h; x++)
    {
        Console.WriteLine(Z);
    }
}
if (Raw_a == "" && Raw_b == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    bool TryParseuserInputB = int.TryParse(Raw_b, out int y);
    if (TryParseuserInputA && TryParseuserInputB)
    {
        Rectangle(y,x);
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
/* EXERCISE 8
static void Pyramid(int h)
{
    string Z = "";
    for (int y = 0; y < h; y++)
    {
        for(int i = h - y; i >= 0;  i--)
        {
            Console.Write($" ");
        }
        Z += "*";
        Console.WriteLine(Z);
        Z += "*";
    }
}
if (Raw_a == "")
{
    Console.WriteLine("User input empty!");
    Console.ReadLine();
}
else
{
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    if (TryParseuserInputA)
    {
        Pyramid(x);
    }
    else
    {
        Console.WriteLine("User did not input number");
        Console.ReadLine();
    }
}
*/
/* EXERCISE 9
if (Raw_a == "")
{
    Console.WriteLine("User input is empty");
    Console.ReadLine();
}
else
{
    bool a = true;
    bool TryParseuserInputA = int.TryParse(Raw_a, out int x);
    if (TryParseuserInputA)
    {
        if (x == 0 || x == 1)
        {
            Console.WriteLine($"Given number is not prime: {x}!");
            a = false;
        }
        for (int i = 3; i <= x; i+=2)
        {
            if (x == 2)
            {
                break;
            }
            if (x % i == 0)
            {
                Console.WriteLine($"Given number is not prime: {x}!");
                a = false;
                break;
            }
        }
        if (x < 0)
        {
            Console.WriteLine($"Given number is not prime: {x}!");
            a = false;
        }
        if (a)
        {
            Console.WriteLine($"Given number is prime: {x}");
        }
    }
    else
    {
        Console.WriteLine("Input is not a number");
        Console.ReadLine();
    }
}
*/
Console.WriteLine("Welcome to tic tac toe ");
Console.WriteLine($"   |   |   ");
Console.WriteLine($"---+---+---");
Console.WriteLine($"   |   |   ");
Console.WriteLine($"---+---+---");
Console.WriteLine($"   |   |   ");
string[] Array = new string[9];
bool X = true;
bool O = true;
int End = 1;
while (true)
{
    //Console.WriteLine(End);
    //Console.WriteLine(Array.Length);
    if (End == 10)
    {
        Console.ReadLine();
        Console.WriteLine($" {Array[0]} | {Array[1]} | {Array[2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Array[3]} | {Array[4]} | {Array[5]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Array[6]} | {Array[7]} | {Array[8]} ");
        Console.WriteLine("Game END");
        Console.ReadLine();
        Environment.Exit(1);
    }
    if (X)
    {
        Console.Write("X's move: ");
        string Raw_a = Console.ReadLine();
        if (Raw_a == "")
        {
            Console.WriteLine("User input is empty");
            Console.ReadLine();
        }
        else
        {
            bool TryParseuserInputA = int.TryParse(Raw_a, out int a);
            if (TryParseuserInputA)
            {
                if (a > 0 && a < 10)
                {
                    if (Array[a - 1] != "X" && Array[a - 1] != "O")
                    {
                        Array[a - 1] = "X";
                        Console.WriteLine($" {Array[0]} | {Array[1]} | {Array[2]} ");
                        Console.WriteLine($"---+---+---");
                        Console.WriteLine($" {Array[3]} | {Array[4]} | {Array[5]} ");
                        Console.WriteLine($"---+---+---");
                        Console.WriteLine($" {Array[6]} | {Array[7]} | {Array[8]} ");
                        X = false;
                        O = true;
                        End += 1;
                    }
                    else
                    {
                        Console.WriteLine("X can not be placed here");
                    }

                }
                else
                {
                    Console.WriteLine("User input out of range");
                }
            }
            else
            {
                Console.WriteLine("Input is not a number");
            }
        }

    }

    if (O)
    {
        Console.Write("O's move: ");
        string Raw_a = Console.ReadLine();
        if (Raw_a == "")
        {
            Console.WriteLine("User input is empty");
            Console.ReadLine();
        }
        else
        {
            bool TryParseuserInputA = int.TryParse(Raw_a, out int a);
            if (TryParseuserInputA)
            {
                if (a > 0 && a < 10)
                {
                    if (Array[a - 1] != "X" && Array[a - 1] != "O")
                    {
                        Array[a - 1] = "O";
                        Console.WriteLine($" {Array[0]} | {Array[1]} | {Array[2]} ");
                        Console.WriteLine($"---+---+---");
                        Console.WriteLine($" {Array[3]} | {Array[4]} | {Array[5]} ");
                        Console.WriteLine($"---+---+---");
                        Console.WriteLine($" {Array[6]} | {Array[7]} | {Array[8]} ");
                        X = true;
                        O = false;
                        End += 1;
                    }
                    else
                    {
                        Console.WriteLine("O can not be placed here");
                    }

                }
                else
                {
                    Console.WriteLine("User input out of range");
                }
            }
            else
            {
                Console.WriteLine("Input is not a number");
            }
        }

    }

}