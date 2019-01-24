using System;
using System.Collections.Generic;
using System.Diagnostics;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace ClaimIt
{
  public partial class DashboardPage : ContentPage
  {
    public DashboardPage(double width)
    {
      InitializeComponent();
      var itemTemplate = new DataTemplate(() =>
      {
        var layout = new AbsoluteLayout()
        {
          WidthRequest = width / 7,
        };
        var fLabel = new Frame()
        {
          CornerRadius = 5,
          Padding = 0
        };
        var frame = new Frame()
        {
          Padding = 0,
          HasShadow = false,
          CornerRadius = 10,
          IsClippedToBounds = true
        };
        layout.Children.Add(frame, new Rectangle(.5, .5, width / 10, width / 10), AbsoluteLayoutFlags.PositionProportional);
        layout.Children.Add(fLabel, new Rectangle(.5, .6, width / 12, width / 12), AbsoluteLayoutFlags.PositionProportional);

        fLabel.SetBinding(BackgroundColorProperty, "Color");
        frame.SetBinding(BackgroundColorProperty, "Color");
        var label = new Label
        {
          TextColor = Color.White,
          HorizontalOptions = LayoutOptions.Center,
          VerticalOptions = LayoutOptions.Center,
          HorizontalTextAlignment = TextAlignment.Center,
          VerticalTextAlignment = TextAlignment.Center,
          FontAttributes = FontAttributes.Bold,
          FontSize = 16
        };
        label.SetBinding(Label.TextProperty, "Text");
        fLabel.Content = label;

        var image = new CachedImage
        {
          Aspect = Aspect.AspectFill,
        };
        //image.SetBinding(CachedImage.SourceProperty, "Source");
        //frame.Content = image;

        return layout;
      });

      var coverFlowCentered = new DayViewComponent.DayView
      {
        ItemTemplate = itemTemplate,
        ViewAlignment = DayViewComponent.DayPosition.Center,
        FirstItemPosition = DayViewComponent.DayPosition.Center,
        Spacing = 15,
        IsCyclical = true
      };

      coverFlowCentered.SetBinding(DayViewComponent.DayView.ItemsSourceProperty, nameof(DayViewComponent.DayViewModel.Items));

      BackgroundColor = Color.White;
      Title = "CoverFlowSampleView";

      var scrollView = new ScrollView()
      {
        Orientation = ScrollOrientation.Vertical,
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
      };
      var stack = new StackLayout
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Spacing = 5,
      };


      stack.Children.Add(coverFlowCentered);

      scrollView.Content = stack;

      Content = scrollView;
      BindingContext = new DayViewComponent.DayViewModel();
    }
  }
}
