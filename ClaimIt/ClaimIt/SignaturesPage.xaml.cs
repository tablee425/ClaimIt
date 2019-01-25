using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClaimIt
{
  public partial class SignaturesPage : ContentPage
  {
    public SignaturesPage()
    {
      InitializeComponent();

      var tapDisagree = new TapGestureRecognizer();
      tapDisagree.Tapped += async delegate (object sender, EventArgs e) { await tapClear_TappedAsync(sender, e); };
      clearBtn.GestureRecognizers.Add(tapDisagree);

      var tapAgree = new TapGestureRecognizer();
      tapAgree.Tapped += async delegate (object sender, EventArgs e) { await tapDone_TappedAsync(sender, e); };
      doneBtn.GestureRecognizers.Add(tapAgree);
    }

    async System.Threading.Tasks.Task tapClear_TappedAsync(object sender, EventArgs e)
    {
      await Application.Current.MainPage.DisplayAlert("Test", "Clear", "Ok");
    }

    async System.Threading.Tasks.Task tapDone_TappedAsync(object sender, EventArgs e)
    {
      for (var counter = 1; counter < 2; counter++)
      {
        Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
      }
      await Navigation.PopAsync();
    }
  }
}
