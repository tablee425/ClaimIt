using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace ClaimIt
{
  public delegate void TryAgainEventDelegate();
  public partial class ContentPasswordFailStep : ContentView
  {
    public event TryAgainEventDelegate TryAgainEvent;
    public ContentPasswordFailStep()
    {
      InitializeComponent();
      var tapImage = new TapGestureRecognizer();
      tapImage.Tapped += tapImage_Tapped;
      tryAgainImageBtn.GestureRecognizers.Add(tapImage);
    } 

    void tapImage_Tapped(object sender, EventArgs e)
    {
      TryAgainEvent?.Invoke();
    }
  }
}
