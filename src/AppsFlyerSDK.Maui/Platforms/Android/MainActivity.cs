using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Appsflyer;

namespace AppsFlyerSDK.Maui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        // Optional
        //AppsFlyerLib.Instance.SetDebugLog(true);
        //AppsFlyerLib.Instance.SetLogLevel(AFLogger.LogLevel.Verbose); // Enable verbose logs for debugging
        
        AppsFlyerLib.Instance.Init("DEV_KEY", null, Application);
        AppsFlyerLib.Instance.Start(this, "DEV_KEY");
    }
}
