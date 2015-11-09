namespace Consuming_Web_Services
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;

    public class Program
    {
        public async static void PrintComments(HttpClient httpClient, string queryString, int numOfItems)
        {
            var responsePosts = await httpClient.GetAsync("posts");
            var resultPosts = responsePosts.Content.ReadAsStringAsync().Result;
            var postsObjs = JsonConvert.DeserializeObject<List<Post>>(resultPosts);

            var responseUsers = await httpClient.GetAsync("users");
            var resultUsers = responseUsers.Content.ReadAsStringAsync().Result;
            var usersObjs = JsonConvert.DeserializeObject<List<User>>(resultUsers);
            foreach (var post in postsObjs)
            {
                post.User = usersObjs
                                   .Where(x => x.Id == post.UserId)
                                   .Select(x => x.Username)
                                   .FirstOrDefault();

            }
            var filteredPosts = postsObjs.Where(x => x.Body.Contains(queryString)).Take(numOfItems);
            Console.WriteLine("Items:\n\n" + string.Join(Environment.NewLine+"-------------------"+Environment.NewLine, filteredPosts));
        }

        public static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");
            Console.WriteLine("Enter the number of items that you want to retireve");
            int numberOfItems = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the query string that you want to search by (example dolorem) or check what kind of word are in the posts here-->http://jsonplaceholder.typicode.com/posts");
            string queryString = Console.ReadLine();
            PrintComments(httpClient, queryString, numberOfItems);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
