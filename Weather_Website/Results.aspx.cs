using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using Newtonsoft.Json;

namespace Weather_Website
{
    public partial class Results : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve city and state from query string
                string city = Request.QueryString["city"];
                string state = Request.QueryString["state"];

                lblCity.Text = string.IsNullOrEmpty(city) ? "N/A" : city;
                lblState.Text = string.IsNullOrEmpty(state) ? "N/A" : state;

                // Fetch weather data
                string weatherData = await GetWeatherData(city, state);
                lblWeatherInfo.Text = weatherData;
            }
        }

        private async Task<string> GetWeatherData(string city, string state)
        {
            string apiKey = "0adcebdf811924395e563668294b1b91"; // Replace with your OpenWeatherMap API key
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city},{state}&appid={apiKey}\r\n";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        dynamic weatherInfo = JsonConvert.DeserializeObject(jsonResult);

                        string weatherDescription = weatherInfo.weather[0].description;
                        double temperature = weatherInfo.main.temp;

                        return $"Current weather is {weatherDescription} with a temperature of {temperature}°C.";
                    }
                    else
                    {
                        return "Unable to fetch weather information. Please try again.";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }
    }
}
