using System.Net.Http.Json;
using CodeSmells.Domain;


namespace CodeSmells
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://fake-json-api.mock.beeceptor.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<User> users = await client.GetFromJsonAsync<List<User>>(apiUrl);

                    foreach (var user in users)
                    {
                        Console.WriteLine($"ID: {user.id}");
                        Console.WriteLine($"Name: {user.name}");
                        Console.WriteLine($"Email: {user.email}");
                        Console.WriteLine($"Address: {user.address}");
                        Console.WriteLine($"Zip: {user.zip}");
                        Console.WriteLine($"State: {user.state}");
                        Console.WriteLine($"Country: {user.country}");
                        Console.WriteLine($"Phone: {user.phone}");
                        Console.WriteLine($"Photo: {user.photo}");
                        Console.WriteLine("**Next User**");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
