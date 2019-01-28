using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace ClaimIt.MacOS
{
  [Register("AppDelegate")]
  public class AppDelegate : FormsApplicationDelegate
  {
    NSWindow _window;
    public AppDelegate()
    {
      var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

      var rect = new CoreGraphics.CGRect(200, 200, 800, 600);
      _window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
    }

    public override NSWindow MainWindow
    {
      get { return _window; }
    }

    public override void DidFinishLaunching(NSNotification notification)
    {
      // Insert code here to initialize your application
      Forms.Init();
      LoadApplication(new App());
      base.DidFinishLaunching(notification);
      _window.StyleMask = _window.StyleMask | NSWindowStyle.Titled;
      _window.Title = "ClaimIt";
    }

    public override void WillTerminate(NSNotification notification)
    {
      // Insert code here to tear down your application
    }
  }
}
