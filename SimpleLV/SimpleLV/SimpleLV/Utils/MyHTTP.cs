using SimpleLV.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System.Diagnostics;

namespace SimpleLV.Utils
{
    public static class MyHTTP
    {

        const string BASE_URL = "https://api.myjson.com/";
        const string POST_ENDPOINT = "bins/jw0c4";

        public static async Task<List<Patient>> GetPatientsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var jsonString = await httpClient.GetStringAsync(BASE_URL + POST_ENDPOINT);
                var patients = JsonConvert.DeserializeObject<List<Patient>>(jsonString);
                return patients;
            }
        }

    }
}
