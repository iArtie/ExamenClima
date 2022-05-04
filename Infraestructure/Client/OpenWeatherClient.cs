using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Infraestructure.OpenWeatherClient
{
    public class OpenWeatherClient : IOpenWeatherClient
    {
        public async Task<WeatherMain.ForeCastInfo> GetWeatherByGeo(double x, double y, long dt)
        {

            string url = $"{AppSettings.ApiUrl}lat={x}&lon={y}&dt={dt}&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            //WeatherForeCast.ForeCastInfo fr
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherMain.ForeCastInfo>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }
       


    }
}