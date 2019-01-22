using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ClaimIt
{
  public delegate void EnterPasswordEventDelegate();
  public partial class ContentEnterPasswordStep : ContentView
  {
    public event EnterPasswordEventDelegate EnterPasswordEvent;
    public ContentEnterPasswordStep()
    {
      InitializeComponent();
      var tapImage = new TapGestureRecognizer();
      tapImage.Tapped += tapImage_Tapped;
      enterPasswordImageBtn.GestureRecognizers.Add(tapImage);
    }

    void tapImage_Tapped(object sender, EventArgs e)
    {
      EnterPasswordEvent?.Invoke();
    }
  }
}
