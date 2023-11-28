using dandd.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dandd.Services
{
   

    internal class RaceService
    {
        private HttpClient client;
        private JsonSerializerOptions _serializerOptions;
        private const string baseUrl = "https://www.dnd5eapi.co/api/ability-scores/cha";

        public RaceService() 
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<ObservableCollection<RaceModel>> GetRacaAsync()
        {
            var url = $"{baseUrl}/";
            try
            {
                var response = await client.GetAsync(baseUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ObservableCollection<RaceModel>>(content, _serializerOptions);
                }
                return null;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }
    }

}
}
