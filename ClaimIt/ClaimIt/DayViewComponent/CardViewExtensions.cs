using System;
using System.Collections;
using Xamarin.Forms;

namespace ClaimIt.DayViewComponent
{
  public static class CardViewExtensions
  {
    public static CardsView AsCardsView(this BindableObject bindable)
    => bindable as CardsView;
    public static CardsView AsCarouselView(this BindableObject bindable)
    => bindable as CarouselView;

    public static View CreateView(this DataTemplate template)
    {
      var content = template.CreateContent();
      return content is ViewCell cell
          ? cell.View
          : content as View;
    }

    public static int ToCyclingIndex(this int index, int itemsCount)
    {
      if (itemsCount <= 0)
      {
        return -1;
      }
      if (index < 0)
      {
        while (index < 0)
        {
          index += itemsCount;
        }
      }
      else
      {
        while (index >= itemsCount)
        {
          index -= itemsCount;
        }
      }
      return index;
    }

    public static int FindIndex(this IEnumerable collection, object value)
    {
      if (collection is IList list)
      {
        return list.IndexOf(value);
      }
      var searchIndex = 0;
      foreach (var item in collection)
      {
        if (item == value)
        {
          return searchIndex;
        }
        ++searchIndex;
      }
      return -1;
    }

    public static object FindValue(this IEnumerable collection, int index)
    {
      if (collection is IList list)
      {
        return list[index];
      }
      var searchIndex = 0;
      foreach (var item in collection)
      {
        if (searchIndex == index)
        {
          return item;
        }
        ++searchIndex;
      }
      throw new IndexOutOfRangeException();
    }

    public static int Count(this IEnumerable collection)
    {
      if (collection is ICollection list)
      {
        return list.Count;
      }
      var searchIndex = 0;
      foreach (var item in collection)
      {
        ++searchIndex;
      }
      return searchIndex;
    }
  }
}
