using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Musica
{
    public class ApiCaller
    {
        static string key = "f94e2c864dmsh7e15a29f5dceed5p1e7333jsnd8ce5bcbe570";
        static string searchUrl = "https://genius.p.rapidapi.com/search?q=";
        static string artistUrl = "https://genius.p.rapidapi.com/artists/";

        public Artist GetArtistData(string a)
        {
            int code = GetArtistCodeAsync(a).Result;
            var artist = GetArtistDataAsync(code.ToString()).Result;
            return artist;
        }

        public async Task<int> GetArtistCodeAsync(string artist)
        {
            string encArtist = HttpUtility.UrlEncode(artist);
            string body = GetBodyAsync(searchUrl + encArtist).Result;
            CodeResult res = JsonConvert.DeserializeObject<CodeResult>(body);
            return res.response.hits[0].result.primary_artist.id;
        }
        public async Task<Artist> GetArtistDataAsync(string code)
        {
            string body = GetBodyAsync(artistUrl + code).Result;
            ArtistResult res = JsonConvert.DeserializeObject<ArtistResult>(body);
            return res.response.artist;
        }
        public async Task<string> GetBodyAsync(string url)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
    {
        { "X-RapidAPI-Host", "genius.p.rapidapi.com" },
        { "X-RapidAPI-Key", "f94e2c864dmsh7e15a29f5dceed5p1e7333jsnd8ce5bcbe570" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }

    }
}
