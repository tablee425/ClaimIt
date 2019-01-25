using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ClaimIt.Helpers;
using Xamarin.Forms;

namespace ClaimIt.Models
{
  public class CalendarListViewModel : BaseViewModel
  {
    public ObservableCollection<Post> Posts { get; set; }

    public CalendarListViewModel()
    {
      this.Posts = new ObservableCollection<Post>();
    }

    public async Task UpdatePostsAsync()
    {
      var newPosts = await JsonPlaceholderHelper.GetPostsAsync();
      this.Posts.Clear();
      newPosts.ForEach((post) =>
      {
        post.ImageUrl = "https://picsum.photos/70/?image=" + newPosts.IndexOf(post);
        this.Posts.Add(post);
      });
    }

  }
}
