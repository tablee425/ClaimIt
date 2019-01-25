using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace ClaimIt.DayViewComponent
{
  public class CarouselSampleViewModel
  {
    public CarouselSampleViewModel()
    {
      Items = new ObservableCollection<object>(Enumerable.Range(1, 20).Select(i => new {
      Number = i,
      Page = GetPage(i).ToString(),
      Day1 = GetDay(i, 1).ToString(),
      Day2 = GetDay(i, 2).ToString(),
      Day3 = GetDay(i, 3).ToString(),
      Day4 = GetDay(i, 4).ToString(),
      Day5 = GetDay(i, 5).ToString(),
      Day6 = GetDay(i, 6).ToString(),
      Day7 = GetDay(i, 7).ToString(),
      Color1 = GetColor(i, 1),
      Color2 = GetColor(i, 2),
      Color3 = GetColor(i, 3),
      Color4 = GetColor(i, 4),
      Color5 = GetColor(i, 5),
      Color6 = GetColor(i, 6),
      Color7 = GetColor(i, 7),
      DayColor1 = GetDayColor(i, 1),
      DayColor2 = GetDayColor(i, 2),
      DayColor3 = GetDayColor(i, 3),
      DayColor4 = GetDayColor(i, 4),
      DayColor5 = GetDayColor(i, 5),
      DayColor6 = GetDayColor(i, 6),
      DayColor7 = GetDayColor(i, 7)
      }).ToArray());
    }

    public ObservableCollection<object> Items { get; }

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

    private int GetDay(int i, int index)
    {
      int dayOfWeek = 0;
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

      return DateTime.Now.AddDays(-dayOfWeek + 7 * GetPage(i) + index - 1).Day;
    }

    private Color GetColor(int i, int index)
    {
      int dayOfWeek = 0;
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

      if (GetPage(i) == 0 && index == dayOfWeek + 1)
      {
        return Color.Green;
      }
      else
      {
        return Color.Transparent;
      }
    }

    private Color GetDayColor(int i, int index)
    {
      int dayOfWeek = 0;
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

      if (GetPage(i) == 0 && index == dayOfWeek + 1)
      {
        return Color.White;
      }
      else
      {
        return Color.FromArgb(51, 51, 51);
      }
    }

  }
}
