using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ClaimIt
{
  public delegate void VerifyEventDelegate();
  public partial class ContentVerifyStep : ContentView
  {
    public event VerifyEventDelegate VerifyEvent;
    public ContentVerifyStep()
    {
      InitializeComponent();
    }

    void Num1Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num2.Focus();
      }
    }

    void Num2Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num3.Focus();
      }
    }

    void Num3Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num4.Focus();
      }
    }

    void Num4Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num5.Focus();
      }
    }

    void Num5Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num6.Focus();
      }
    }

    void Num6Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num7.Focus();
      }
    }

    void Num7Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num8.Focus();
      }
    }

    void Num8Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num9.Focus();
      }
    }

    void Num9Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        num10.Focus();
      }
    }

    void Num10Changed(object o, TextChangedEventArgs e)
    {
      if (e.NewTextValue != "")
      {
        if (num1.Text == "")
        {
          num1.Focus();
        } 
        else if (num2.Text == "")
        {
          num2.Focus();
        }
        else if (num3.Text == "")
        {
          num3.Focus();
        }
        else if (num4.Text == "")
        {
          num4.Focus();
        }
        else if (num5.Text == "")
        {
          num5.Focus();
        }
        else if (num6.Text == "")
        {
          num6.Focus();
        }
        else if (num7.Text == "")
        {
          num7.Focus();
        }
        else if (num8.Text == "")
        {
          num8.Focus();
        }
        else if (num9.Text == "")
        {
          num9.Focus();
        }
        else
        {
          // handle done
          num10.Unfocus();
          VerifyEvent?.Invoke();
        }
      }
    }
  }
}
