#if __IOS__
using AppsFlyerXamarinBinding;
using Foundation;
#elif __ANDROID__
using Com.Appsflyer;
#endif

namespace AppsFlyerSDK.Maui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
#if __IOS__
		var addToCartEvent = new NSDictionary(AFEventParameter.AFEventParamContentId, "id 1",
			AFEventParameter.AFEventParamContentType, "type 1", 
			AFEventParameter.AFEventParamCurrency, "USD", 
			AFEventParameter.AFEventParamDescription, "sdescription");

		AppsFlyerLib.Shared.LogEvent(AFEventName.AFEventAddToCart, addToCartEvent);
#elif __ANDROID__
		var eventValues = new Dictionary<string, Java.Lang.Object>
		{
			{ IAFInAppEventParameterName.Price, 2 },
			{ IAFInAppEventParameterName.Currency, "USD"! },
			{ IAFInAppEventParameterName.Quantity, "1"! },
		};
		AppsFlyerLib.Instance.LogEvent(Platform.AppContext, IAFInAppEventType.Purchase, eventValues);
#endif
	}
}

