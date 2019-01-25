using System;
using Newtonsoft.Json;

namespace ClaimIt.Models
{
  public class Post
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("userId")]
    public int UserId { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    public string ImageUrl { get; set; }
  }
}
