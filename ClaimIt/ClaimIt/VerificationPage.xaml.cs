using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaimIt
{
  public partial class VerificationPage : ContentPage
  {
    public VerificationPage()
    {
      InitializeComponent();
      addContentVerifyStepPage();
    }

    private void addContentVerifyStepPage()
    {
      var contentVerifyStep = new ContentVerifyStep();
      DynamicPageView.Children.Add(contentVerifyStep);
      contentVerifyStep.VerifyEvent += ContentVerifyStepEvent;
      activityIndicatorLayout.IsVisible = false;
    }

    private void addContentPasswordStepPage()
    {
      var contentPasswordStep = new ContentEnterPasswordStep();
      DynamicPageView.Children.Clear();
      DynamicPageView.Children.Add(contentPasswordStep);
    }

    async private void ContentVerifyStepEvent()
    {
      activityIndicatorLayout.IsVisible = true;
      await Task.Delay(3000);
      activityIndicatorLayout.IsVisible = false;
      addContentPasswordStepPage();
    }
  }
}
