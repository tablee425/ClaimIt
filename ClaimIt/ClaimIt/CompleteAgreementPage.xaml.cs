using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClaimIt
{
  public partial class CompleteAgreementPage : ContentPage
  {
    public CompleteAgreementPage()
    {
      InitializeComponent();

      var tapDisagree = new TapGestureRecognizer();
      tapDisagree.Tapped += async delegate (object sender, EventArgs e) { await tapDisagree_TappedAsync(sender, e); };
      disagreeBtn.GestureRecognizers.Add(tapDisagree);

      var tapAgree = new TapGestureRecognizer();
      tapAgree.Tapped += async delegate (object sender, EventArgs e) { await tapAgree_TappedAsync(sender, e); };
      agreeBtn.GestureRecognizers.Add(tapAgree);
    }

    async System.Threading.Tasks.Task tapDisagree_TappedAsync(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

    async System.Threading.Tasks.Task tapAgree_TappedAsync(object sender, EventArgs e)
    {
      var signatures = new SignaturesPage();
      await Navigation.PushAsync(signatures);
    }
  }
}
