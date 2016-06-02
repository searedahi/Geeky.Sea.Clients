using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatClients.PiModels;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BoatClients.PiData
{
    public class BoatPiService : IBoatPiService
    {
        HttpClient client;

        public PiCurrentTemp CurrentTemp { get; private set; }
        public List<PiTemperature> Temperatures { get; private set; }
        public List<PiLocation> Locations { get; private set; }


        public BoatPiService()
        {
            var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        //public async Task<List<TodoItem>> RefreshDataAsync()
        //{
        //    Items = new List<TodoItem>();

        //    // RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
        //    var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

        //    try
        //    {
        //        var response = await client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"				ERROR {0}", ex.Message);
        //    }

        //    return Items;
        //}



        public async Task<PiCurrentTemp> GetCurrentTemp()
        {
            CurrentTemp = new PiCurrentTemp();

            var restUrl = $"{Constants.RestUrl}currentTemp";
            var uri = new Uri(string.Format(restUrl, string.Empty));

            try
            {
                var response = client.GetAsync(uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    CurrentTemp = JsonConvert.DeserializeObject<PiCurrentTemp>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return CurrentTemp;


        }

        public Task<List<PiLocation>> GetLocationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<PiTemperature>> GetTemperaturesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
