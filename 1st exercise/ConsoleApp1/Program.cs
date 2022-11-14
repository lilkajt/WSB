Console.WriteLine("01Introduction - Exercises.pdf");
Console.WriteLine("");
/*

Console.WriteLine("Hello, World!");

int a = 5;
int b = 10;

int area = a * b;

Console.WriteLine("Area of rectangle is " + area);

int x = 5;
int y = 2; //cant divide by 0, added int

int z = int.Parse(Console.ReadLine());

Console.WriteLine(x / y);


double PLN = double.Parse(Console.ReadLine()); //input here pln
double USD_value_topln = 0.21;
double exchange = PLN * USD_value_topln;
Console.WriteLine("You have " + exchange + " usd");
*/
/*
double a = double.Parse(Console.ReadLine()); //asks user for an input
double b = double.Parse(Console.ReadLine());//asks user for an input
double c = double.Parse(Console.ReadLine());//asks user for an input
double x = double.Parse(Console.ReadLine());//asks user for an input

double function = (a*x*x) + (b*x) + c; //calculate the function
Console.WriteLine(function); //prints out the function
*/
/*
float a = float.Parse(Console.ReadLine());
Console.WriteLine(Math.Truncate(a));

Console.WriteLine("*****");
Console.WriteLine("*****");
Console.WriteLine("*****");
*/
/*
//console.WriteLine("tic toc toe!");
Console.WriteLine(" X |   | 0 ");
Console.WriteLine("---+---+---");
Console.WriteLine("   | X |   ");
Console.WriteLine("---+---+---");
Console.WriteLine("   | 0 |   ");
*/
Console.WriteLine($"tic toc toe game!\n");
//game states
Console.Write($"What's the state of the first field: ");
string a = Console.ReadLine();
Console.Write($"What's the state of the second field: ");
string b = Console.ReadLine();
Console.Write($"What's the state of the third field: ");
string c = Console.ReadLine();
Console.Write($"What's the state of the fourth field: ");
string d = Console.ReadLine();
Console.Write($"What's the state of the fifth field: ");
string e = Console.ReadLine();
Console.Write($"What's the state of the sixth field: ");
string f = Console.ReadLine();
Console.Write($"What's the state of the seventh field: ");
string g = Console.ReadLine();
Console.Write($"What's the state of the eight field: ");
string h = Console.ReadLine();
Console.Write($"What's the state of the nineth field: ");
string i = Console.ReadLine();
//list
string[] list = { a, b, c, d, e, f, g, h, i };
Console.Write($"");

for (int P = 0; P < list.Length; P++)
{
    if (list[P] == "")
    {
        //Console.WriteLine("idex " + P);
        //Console.WriteLine("before change X" + list[P] + "X");
        list[P] = " ";
        //Console.WriteLine("after change X" + list[P] + "X");
    }
    if (!(list[P].ToLower().Contains(" ") || list[P].ToLower().Contains("o") || list[P].ToLower().Contains("x")))
    {
        //Console.WriteLine(list[P]);
        Console.WriteLine($"YOU PUT {list[P]}\nPlease go back and change characters!\nONLY ' ', 'x', 'o' is accepted");
        Console.ReadLine();
        Environment.Exit(0);
    }
}
Console.WriteLine($"");
Console.WriteLine($" {list[0].ToUpper()} | {list[1].ToUpper()} | {list[2].ToUpper()} ");
Console.WriteLine($"---+---+---");
Console.WriteLine($" {list[3].ToUpper()} | {list[4].ToUpper()} | {list[5].ToUpper()} ");
Console.WriteLine($"---+---+---");
Console.WriteLine($" {list[6].ToUpper()} | {list[7].ToUpper()} | {list[8].ToUpper()} ");
Console.ReadLine();