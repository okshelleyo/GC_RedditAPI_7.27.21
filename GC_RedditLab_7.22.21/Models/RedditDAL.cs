using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GC_RedditLab_7._22._21.Models
{
    public class RedditDAL
    {
        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.reddit.com");
            return client;
        }

        public async Task<IEnumerable<Child>> GetRedditPosts()
        {
            var client = GetHttpClient();
            var request = await client.GetAsync("/r/aww/.json");
            var response = await request.Content.ReadAsAsync<RedditRootobject>();
            return response.data.children;
        }

    }
}
