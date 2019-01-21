
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ClaimIt.Droid
{
  [Activity(Label = "@string/ApplicationName")]
  public class MainActivity : AppCompatActivity
  {
    static readonly string TAG = "X:" + typeof(MainActivity).Name;
    Button _button;
    int _clickCount;

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      SetContentView(Resource.Layout.Layout);

      _button = FindViewById<Button>(Resource.Id.MyButton);

      _button.Click += (sender, args) =>
      {
        string message = string.Format("You clicked {0} times.", ++_clickCount);
        _button.Text = message;
        Log.Debug(TAG, message);
      };

      Log.Debug(TAG, "MainActivity is loaded.");
    }
  }
}
