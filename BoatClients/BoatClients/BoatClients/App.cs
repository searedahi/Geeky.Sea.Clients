using BoatClients.PiData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BoatClients
{
    public class App : Application
    {
        public App()
        {
            BoatPiManager boatMan = new BoatPiManager(new BoatPiService());

            var currentTemp = boatMan.GetCurrentTemp().Result;
            
            // The root page of your application
            MainPage = new ContentPage
            {
                BackgroundColor = new Color(1, 1, 1, 0.5),

                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Farenheight" },
                            new Label
                            {
                                XAlign = TextAlignment.Center,
                                Text = currentTemp.Farenheight.ToString(),
                                FontSize = 72
                            }

                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
