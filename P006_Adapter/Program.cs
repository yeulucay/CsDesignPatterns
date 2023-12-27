using P006_Adapter;

var europeanCharger = new EuropeanCharger();

IUKSocket ukSocketAdapter = new EUToUKAdapter(europeanCharger);
IUSSocket usSocketAdapter = new EUToUSAdapter(europeanCharger);

ukSocketAdapter.PlugIntoUKSocket();
usSocketAdapter.PlugIntoUSSocket();
