using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ClaimIt.DayViewComponent
{
  public class CarouselSampleViewModel
  {
    public CarouselSampleViewModel()
    {
      Items = new ObservableCollection<object>(Enumerable.Range(1, 20).Select(i => new {
       Number = i,
       Page = GetPage(i)
      }).ToArray());
    }

    public ObservableCollection<object> Items { get; }

    private string GetPage(int i)
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
      return page.ToString();
    }
  }
}
