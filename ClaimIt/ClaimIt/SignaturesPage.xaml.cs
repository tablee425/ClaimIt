using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using SignaturePad.Forms;

namespace ClaimIt
{
  public partial class SignaturesPage : ContentPage
  {
    public SignaturesPage()
    {
      InitializeComponent();

      var tapDisagree = new TapGestureRecognizer();
      tapDisagree.Tapped += TapClear_Tapped;
      clearBtn.GestureRecognizers.Add(tapDisagree);

      var tapAgree = new TapGestureRecognizer();
      tapAgree.Tapped += async delegate (object sender, EventArgs e) { await tapDone_TappedAsync(sender, e); };
      doneBtn.GestureRecognizers.Add(tapAgree);
      closeImageBtn.GestureRecognizers.Add(tapAgree);
    }

    private void TapClear_Tapped(object sender, EventArgs e)
    {
      //Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Jpeg); // save
      PadView.Clear();
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
