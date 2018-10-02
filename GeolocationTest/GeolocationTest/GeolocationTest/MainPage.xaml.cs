using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GeolocationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new Xamarin.Essentials.GeolocationRequest(Xamarin.Essentials.GeolocationAccuracy.Best, TimeSpan.FromSeconds(20));
            var request1 = new Xamarin.Essentials.GeolocationRequest(Xamarin.Essentials.GeolocationAccuracy.Best);
            var request2 = new Xamarin.Essentials.GeolocationRequest();

            var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
            var location1 = await Xamarin.Essentials.Geolocation.GetLocationAsync(request);
            var location2 = await Xamarin.Essentials.Geolocation.GetLocationAsync(request1);
            var location3 = await Xamarin.Essentials.Geolocation.GetLocationAsync(request2);
            var location4 = await Xamarin.Essentials.Geolocation.GetLocationAsync();

            lblLocation.Text = $"Lat: {location.Latitude} .-. Long: {location.Longitude}";
            lblLocation1.Text = $"Lat: {location1.Latitude} .-. Long: {location1.Longitude}";
            lblLocation2.Text = $"Lat: {location2.Latitude} .-. Long: {location2.Longitude}";
            lblLocation3.Text = $"Lat: {location3.Latitude} .-. Long: {location3.Longitude}";
            lblLocation4.Text = $"Lat: {location4.Latitude} .-. Long: {location4.Longitude}";
        }
    }
}
