using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using ClaimIt.DayViewComponent;
using FFImageLoading.Forms;
using Xamarin.Forms;
using ClaimIt.Models;

namespace ClaimIt
{
  public partial class DashboardPage : ContentPage
  {
    private View GetCardItem() => new CardItem();
    private int dayOfWeek = 0;
    CalendarListViewModel itemListViewModel; // calendar page list view model

    public DashboardPage(double width)
    {
      InitializeComponent();

      itemListViewModel = new CalendarListViewModel();
      ItemsListView.BindingContext = itemListViewModel;
      ItemsListView.ItemSelected += async delegate (object sender, SelectedItemChangedEventArgs e) { await OnItemSelectedAsync(sender, e); };

      switch (DateTime.Now.DayOfWeek.ToString())
      {
        case "Monday":
          dayOfWeek = 0;
          break;
        case "Tuesday":
          dayOfWeek = 1;
          break;
        case "Wednesday":
          dayOfWeek = 2;
          break;
        case "Thursday":
          dayOfWeek = 3;
          break;
        case "Friday":
          dayOfWeek = 4;
          break;
        case "Saturday":
          dayOfWeek = 5;
          break;
        case "Sunday":
          dayOfWeek = 6;
          break;
        default:
          dayOfWeek = 0;
          break;
      }

      var carousel = new DayViewComponent.CarouselView
      {
        ItemTemplate = new DataTemplate(GetCardItem),
      };
      carousel.ItemAppearing += Carousel_ItemAppearing;
      carousel.SetBinding(CardsView.ItemsSourceProperty, nameof(CarouselSampleViewModel.Items));
      carousel.BindingContext = new CarouselSampleViewModel();

      var parentScrollView = new DayViewComponent.ParentScrollView {
        Content = new StackLayout {
          Children = { carousel }
        }
      };
      dynamicDayViewCarousel.Children.Add(parentScrollView);
    }

    protected override async void OnAppearing()
    {
      base.OnAppearing();
      await itemListViewModel.UpdatePostsAsync();
    }

    void Carousel_ItemAppearing(CardsView view, ItemAppearingEventArgs args)
    {
      var months = new List<string>(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Select(dayName => dayName).ToList());
      DateTime thatDate = DateTime.Now.AddDays(3 - dayOfWeek + GetPage(view.SelectedIndex + 1) * 7);
      yearLabel.Text = months[thatDate.Month - 1] + " " + thatDate.Year;
    }

    async System.Threading.Tasks.Task OnItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
    {
      var agreementPage = new CompleteAgreementPage();
      await Navigation.PushAsync(agreementPage);
    }

    private int GetPage(int i)
    {
      int page = 0;
      if (i > 10)
      {
        page = i - 20 - 1;
      }
      else
      {
        page = i - 1;
      }
      return page;
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
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label2 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label3 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label4 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label5 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label6 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var label7 = new Label
      {
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 15,
        FontAttributes = FontAttributes.Bold,
        WidthRequest = 36,
        HeightRequest = 36
      };
      var labelFrame1 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label1,
        Padding = 0
      };
      var labelFrame2 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label2,
        Padding = 0
      };
      var labelFrame3 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label3,
        Padding = 0
      };
      var labelFrame4 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label4,
        Padding = 0
      };
      var labelFrame5 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        Content = label5,
        Padding = 0
      };
      var labelFrame6 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label6,
        Padding = 0
      };
      var labelFrame7 = new Frame
      {
        CornerRadius = 18,
        WidthRequest = 36,
        HeightRequest = 36,
        HasShadow = false,
        IsClippedToBounds = true,
        Content = label7,
        Padding = 0
      };
      label1.SetBinding(Label.TextProperty, "Day1");
      label1.SetBinding(Label.TextColorProperty, "DayColor1");
      labelFrame1.SetBinding(BackgroundColorProperty, "Color1");
      label2.SetBinding(Label.TextProperty, "Day2");
      label2.SetBinding(Label.TextColorProperty, "DayColor2");
      labelFrame2.SetBinding(BackgroundColorProperty, "Color2");
      label3.SetBinding(Label.TextProperty, "Day3");
      label3.SetBinding(Label.TextColorProperty, "DayColor3");
      labelFrame3.SetBinding(BackgroundColorProperty, "Color3");
      label4.SetBinding(Label.TextProperty, "Day4");
      label4.SetBinding(Label.TextColorProperty, "DayColor4");
      labelFrame4.SetBinding(BackgroundColorProperty, "Color4");
      label5.SetBinding(Label.TextProperty, "Day5");
      label5.SetBinding(Label.TextColorProperty, "DayColor5");
      labelFrame5.SetBinding(BackgroundColorProperty, "Color5");
      label6.SetBinding(Label.TextProperty, "Day6");
      label6.SetBinding(Label.TextColorProperty, "DayColor6");
      labelFrame6.SetBinding(BackgroundColorProperty, "Color6");
      label7.SetBinding(Label.TextProperty, "Day7");
      label7.SetBinding(Label.TextColorProperty, "DayColor7");
      labelFrame7.SetBinding(BackgroundColorProperty, "Color7");

      Content = new FlexLayout
      {
        Direction = FlexDirection.Row,
        JustifyContent = FlexJustify.SpaceBetween,
        AlignItems = FlexAlignItems.Center,
        Margin = new Thickness(10, 0, 10, 0),
        Children =
        {
          labelFrame1,
          labelFrame2,
          labelFrame3,
          labelFrame4,
          labelFrame5,
          labelFrame6,
          labelFrame7
        }
      };
    }
  }
}
