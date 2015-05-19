using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Model;

namespace VIKINGEdesign.Persistency
{
    class PersistencyService
    {
        /// <summary>
        /// Poster evented til databasen.
        /// </summary>
        /// <param name="newBillet"></param>
        public static async void SaveBilleterAsJsonAsync(Billet newBillet)
        {
            const string ServerUrl = "http://localhost:3541";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.PostAsJsonAsync("api/Billeters", newBillet).Result;
                }
                catch { }
            }
        }

        public static async void SaveKunderAsJsonAsync(Kunde newKunde)
        {
            const string ServerUrl = "http://localhost:3541";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.PostAsJsonAsync("api/Kunders", newKunde).Result;
                    
                }
                catch { }
            }
        }

        /// <summary>
        /// Getter data fra databasen.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Billet>> LoadBilleterFromJsonAsync()
        {
            const string ServerUrl = "http://localhost:3541";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync("api/Billeters").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<Billet> billetData = response.Content.ReadAsAsync<IEnumerable<Billet>>().Result;
                        return billetData.ToList();
                    }
                    return null;
                }
                catch { return null; }
            }
        }

        public static async Task<List<Kunde>> LoadKunderFromJsonAsync()
        {
            const string ServerUrl = "http://localhost:3541";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync("api/Kunders").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<Kunde> kundeData = response.Content.ReadAsAsync<IEnumerable<Kunde>>().Result;
                        return kundeData.ToList();
                    }
                    return null;
                }
                catch { return null; }
            }
        }
    }
}
