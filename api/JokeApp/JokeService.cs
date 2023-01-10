using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace JokeApp
{
    public class JokeService
    {
        public static Joke GetRandomJoke()
        {
            return DoGetJoke("Any");
        }
        private static Joke DoGetJoke(string category)
        {
            using HttpClient client = new();
            category ??= "Any";
            String json = client.GetStringAsync($"https://v2.jokeapi.dev/joke/{category}?blacklistFlags=nsfw,racist,sexist").Result;
            Joke joke = JsonSerializer.Deserialize<Joke>(json);
            return joke;
        }
        public static Joke GetRndCategoryJoke(string category)
        {
            return DoGetJoke(category);
        }
    }
}
