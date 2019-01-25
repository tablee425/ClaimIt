using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClaimIt.Models;

namespace ClaimIt.Helpers
{
  public static class JsonPlaceholderHelper
  {
    const string BASE_URL = "https://jsonplaceholder.typicode.com/";
    const string POST_ENDPOINT = "posts?id=1";

    public static async Task<List<Post>> GetPostsAsync()
    {
      using (var httpClient = new HttpClient())
      {
        var jsonString = await httpClient.GetStringAsync(BASE_URL + POST_ENDPOINT);
        var posts = JsonConvert.DeserializeObject<List<Post>>(jsonString);
        return posts;
      }
    }
  }
}
