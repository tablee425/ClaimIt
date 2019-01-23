using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using ClaimIt;
using ClaimIt.Droid;
using Android.Content;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace ClaimIt.Droid
{
  class MyEntryRenderer : EntryRenderer
  {
    public MyEntryRenderer(Context context) : base(context)
    {
    }

    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (Control != null)
      {
        //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
      }
    }
  }
}
