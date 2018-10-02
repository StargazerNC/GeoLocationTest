using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace GeolocationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(Xamarin.Essentials.GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));
                var request1 = new GeolocationRequest(Xamarin.Essentials.GeolocationAccuracy.Lowest, TimeSpan.FromSeconds(10));

                var location = await Geolocation.GetLastKnownLocationAsync();
                var location1 = await Geolocation.GetLocationAsync(request);
                var location2 = await Geolocation.GetLocationAsync(request1);

                    lblLocation.Text = $"Lat: {location.Latitude} .-. Long: {location.Longitude}";
                    lblLocation1.Text = $"Lat: {location1.Latitude} .-. Long: {location1.Longitude}";
                    lblLocation2.Text = $"Lat: {location2.Latitude} .-. Long: {location2.Longitude}";
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                throw fnsEx;
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                throw pEx;
            }
            catch (Exception ex)
            {
                // Unable to get location
                throw ex;
            }
        }
    }
}
