using P003_Observer;

var weatherChannel = new TheWeatherChannel();

IObserver mobileApp = new MobileApp();
IObserver outdoorDisplay = new OutdoorDisplay();

weatherChannel.AddObserver(mobileApp);
weatherChannel.AddObserver(outdoorDisplay);

weatherChannel.SetNewWeather("It starts to rain soon.");
Thread.Sleep(2000);
weatherChannel.SetNewWeather("A storm is coming!");