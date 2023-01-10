// See https://aka.ms/new-console-template for more information
using JokeApp;

//Console.WriteLine("Hello, World!");
Joke joke = JokeService.GetRandomJoke();
/*if (!joke.Flags.Nsfw)
{
    Console.WriteLine(joke.Setup);
    Console.WriteLine(joke.Delivery);

}
Console.WriteLine(joke.Flags.Nsfw);
*/

if (joke.Type == "single")
{
    Console.WriteLine(joke.JokeString);
    //Console.WriteLine("Single joke?");
}
if (joke.Type == "twopart")
{
    Console.WriteLine(joke.Setup);
    Console.WriteLine(joke.Delivery);
    //Console.WriteLine("twopart?");
}
