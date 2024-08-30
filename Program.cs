using System.Net.Http.Json;
using CodeSmells.Domain;

// Please add unit testing for this.

// Followed the SRP principle. However, you can improve it by separating them by folder or creating a better folder structure.

// Namespace follows standard convention. Good.
namespace CodeSmells
{
    // Code is generally readable
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

                    // Please add null checker for users. This might lead to a NRE.

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
                // If you can add more specific error handlers, please do.
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
