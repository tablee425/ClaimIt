using System;
using System.Collections.Generic;
using System.Diagnostics;
using ClaimIt.DayViewComponent;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace ClaimIt
{
  public partial class DashboardPage : ContentPage
  {
    private View GetCardItem() => new CardItem();

    public DashboardPage(double width)
    {
      InitializeComponent();

      var carousel = new DayViewComponent.CarouselView
      {
        ItemTemplate = new DataTemplate(GetCardItem),
      };
      carousel.ItemAppearing += Carousel_ItemAppearing;
      carousel.SetBinding(CardsView.ItemsSourceProperty, nameof(CarouselSampleViewModel.Items));
      BindingContext = new CarouselSampleViewModel();

      var parentScrollView = new DayViewComponent.ParentScrollView {
        Content = new StackLayout {
          Children = { carousel }
        }
      };
      dynamicDayViewCarousel.Children.Add(parentScrollView);
    }

    void Carousel_ItemAppearing(CardsView view, ItemAppearingEventArgs args)
    {
      indexLabel.Text = view.OldIndex.ToString() + "..." + view.SelectedIndex.ToString();
    }

  }

  public class CardItem : ContentView
  {
    public CardItem()
    {
      var label1 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label2 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label3 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label4 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label5 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label6 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      var label7 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 30,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 50
      };
      label1.SetBinding(Label.TextProperty, "Page");
      label2.SetBinding(Label.TextProperty, "Page");
      label3.SetBinding(Label.TextProperty, "Page");
      label4.SetBinding(Label.TextProperty, "Page");
      label5.SetBinding(Label.TextProperty, "Page");
      label6.SetBinding(Label.TextProperty, "Page");
      label7.SetBinding(Label.TextProperty, "Page");
      Content = new FlexLayout
      {
        Direction = FlexDirection.Row,
        JustifyContent = FlexJustify.SpaceBetween,
        AlignItems = FlexAlignItems.Center,
        Margin = new Thickness(10, 0, 10, 0),
        Children =
        {
          label1,
          label2,
          label3,
          label4,
          label5,
          label6,
          label7
        }
      };
    }
  }
}
