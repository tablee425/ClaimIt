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
      DynamicPageView.Children.Clear();
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

    private void addContentPasswordFailStepPage()
    {
      var contentPasswordFailStep = new ContentPasswordFailStep();
      DynamicPageView.Children.Clear();
      contentPasswordFailStep.TryAgainEvent += ContentTryAgainEvent;
      DynamicPageView.Children.Add(contentPasswordFailStep);
    }

    async private void ContentVerifyStepEvent(string code)
    {
      activityIndicatorLayout.IsVisible = true;
      await Task.Delay(3000);
      activityIndicatorLayout.IsVisible = false;
      if (code == "0000000000") // This is only for test 
      {
        addContentPasswordStepPage();
      }
      else
      {
        addContentPasswordFailStepPage();
      }
    }

    private void ContentTryAgainEvent()
    {
      addContentVerifyStepPage();
    }

  }
}
