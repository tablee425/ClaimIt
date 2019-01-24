using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaimIt
{
  public partial class LoginPage : ContentPage
  {
    public LoginPage()
    {
      InitializeComponent();
      var tapImage = new TapGestureRecognizer();
      tapImage.Tapped += async delegate (object sender, EventArgs e) { await tapImage_TappedAsync(sender, e); };
      loginImageBtn.GestureRecognizers.Add(tapImage);
      activityIndicatorLayout.IsVisible = false;
    }

    async System.Threading.Tasks.Task tapImage_TappedAsync(object sender, EventArgs e)
    {
      activityIndicatorLayout.IsVisible = true;
      await Task.Delay(1000);
      activityIndicatorLayout.IsVisible = false;
      var dashboardPage = new DashboardPage(Width);
      await Navigation.PushAsync(dashboardPage);
    }
  }
}
