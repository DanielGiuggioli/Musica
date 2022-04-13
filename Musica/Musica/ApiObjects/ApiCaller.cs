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
        static string songUrl = "https://genius.p.rapidapi.com/songs/";
        static string artistUrl = "https://genius.p.rapidapi.com/artists/";

        public ArtistSearch GetArtistData(string a)
        {
            var artistSearch = new ArtistSearch() { Songs = new List<Song>() };
            SearchResponse searchResponse = SearchAsync(a).Result;
            Hit[] hits = searchResponse.hits;
            int artistCode;
            if (hits[0].result.primary_artist.name.Length > a.Length+2)
                artistCode = hits[1].result.primary_artist.id;
            else
                artistCode = hits[0].result.primary_artist.id;
            var artist = GetArtistDataAsync(artistCode.ToString()).Result;
            artistSearch.Artist = artist;
            foreach(var x in hits)
            {
                Song song = GetSongDataAsync(x.result.id.ToString()).Result;
                artistSearch.Songs.Add(song);
            }
            return artistSearch;
        }

        public async Task<SearchResponse> SearchAsync(string artist)
        {
            string encArtist = HttpUtility.UrlEncode(artist);
            string body = GetBodyAsync(searchUrl + encArtist).Result;
            SearchResult res = JsonConvert.DeserializeObject<SearchResult>(body);
            return res.response;
        }
        public async Task<Song> GetSongDataAsync(string code)
        {
            string body = GetBodyAsync(songUrl + code).Result;
            SongResult res = JsonConvert.DeserializeObject<SongResult>(body);
            return res.response.song;
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
