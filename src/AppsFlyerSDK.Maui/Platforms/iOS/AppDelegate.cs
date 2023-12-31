﻿using AppsFlyerXamarinBinding;
using Foundation;
using UIKit;

namespace AppsFlyerSDK.Maui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	
	[Export("application:didFinishLaunchingWithOptions:")]
	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		base.FinishedLaunching(application, launchOptions);

		// Simple example from README
		AppsFlyerLib.Shared.AppleAppID = "<APP_ID>";
		AppsFlyerLib.Shared.AppsFlyerDevKey = "<YOUR_DEV_KEY>";
		/* AppsFlyerLib.Shared.Delegate = af_delegate; */
		/* AppsFlyerLib.Shared.IsDebug = true; */
		
		// Full example from sample app
		// AppsFlyerLib.Shared.IsDebug = true;
		// AppsFlyerLib.Shared.CurrencyCode = "GBP";
		// AppsFlyerLib.Shared.OneLinkCustomDomains = new string[] { "automationsdk.blaster.afsdktests.com" };
		// AppsFlyerLib.Shared.AppsFlyerDevKey = "4UGrDF4vFvPLbHq5bXtCza"; // Replace with your DevKey
		// AppsFlyerLib.Shared.AppleAppID = "753258300"; // Replace with your app ID
		// AppsFlyerLib.Shared.AppInviteOneLinkID = "E2bM"; // Replace with your OneLink ID
		// AppsFlyerLib.Shared.CurrentDeviceLanguage = "en-en12";
		// //appsflyer.AnonymizeUser = true;
		// string[] networks = { "all", "another" };
		// AppsFlyerLib.Shared.SetSharingFilterForPartners(networks);
		// AppsFlyerLib.Shared.AddPushNotificationDeepLinkPath(new string[] { "key1", "key2" });
		//
		// var partnerInfo = new NSDictionary("id", "id123", "type", 1, "desc", "Description example");
		// AppsFlyerLib.Shared.SetPartnerData("test_partner", partnerInfo);
		//
		// // Conversion data callbacks
		// var GCDDelegate = new AppsFlyerConversionDataDelegate();
		// AppsFlyerLib.Shared.Delegate = GCDDelegate;
		// // DeepLink callbacks
		// var deepLinkDelegate = new MyAppsFlyerDeepLinkDelegate();
		// AppsFlyerLib.Shared.DeepLinkDelegate = deepLinkDelegate;

		return true;
	}
	
	[Export("applicationDidBecomeActive:")]
	public override void OnActivated(UIApplication application)
	{
		base.OnActivated(application);
		
		AppsFlyerLib.Shared.Start();

		// Full example from sample app
		// AppsFlyerLib.Shared.ValidateAndLogInAppPurchase("productId", "price", "USD", "123", null, (dictionary) => {
		// 	Console.WriteLine(dictionary.Description);
		// }, (err, obj) => {
		// 	Console.WriteLine(err.Description);
		// });
	}
}

// Full example from sample app
//
// public class AppsFlyerConversionDataDelegate : AppsFlyerLibDelegate
// {
// 	public AppsFlyerConversionDataDelegate()
// 	{
// 		Console.WriteLine("AppsFlyerConversionDataDelegate Initialized");
// 	}
//
// 	public override void OnAppOpenAttribution(NSDictionary attributionData)
// 	{
// 		String message = "OnAppOpenAttribution:\n";
// 		foreach (var kvp in attributionData)
// 		{
// 			message = message + kvp.Key.ToString() + " = " + kvp.Value.ToString() + "\n";
// 		}
// 		Console.WriteLine(message);
// 	}
//
// 	public override void OnAppOpenAttributionFailure(NSError error)
// 	{
//
// 	}
//
// 	public override void OnConversionDataSuccess(NSDictionary conversionInfo)
// 	{
// 		String message = "OnConversionDataSuccess:\n";
// 		foreach (var kvp in conversionInfo)
// 		{
// 			if (kvp.Value != null)
// 			{
// 				message = message + kvp.Key.ToString() + " = " + kvp.Value.ToString() + "\n";
// 			}
// 		}
// 		message = message + "Timestamp:" + DateTime.Now;
// 		Console.WriteLine(message);
// 	}
//
// 	public override void OnConversionDataFail(NSError error)
// 	{
//
// 	}
// }
//
// public class MyAppsFlyerDeepLinkDelegate : AppsFlyerDeepLinkDelegate
// {
// 	public MyAppsFlyerDeepLinkDelegate()
// 	{
// 		Console.WriteLine("MyAppsFlyerDeepLinkDelegate Initialized");
// 	}
//
// 	public override void DidResolveDeepLink(AppsFlyerDeepLinkResult result)
// 	{
// 		AppsFlyerDeepLink deepLink = result.deepLink;
// 		if (deepLink != null)
// 		{
// 			Console.WriteLine("DDL: " + result.deepLink.toString());
// 			string message = result.deepLink.toString();
// 			Console.WriteLine(message);
// 		}
// 		else
// 		{
// 			Console.WriteLine("DDL: " + result.status);
// 		}
// 	}
// }
