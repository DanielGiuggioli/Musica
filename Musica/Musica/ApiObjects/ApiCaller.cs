using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public IList<Song> GetSongs(string s)
        {
            s = s.ToLower();
            IList<Song> songs = new List<Song>();
            SearchResponse searchResponse = SearchAsync(s).Result;
            Hit[] hits = searchResponse.hits;
            string[] searchSplit = s.Split(' ');
            foreach (var x in hits)
            {
                bool isContained = true;
                for(int index = 0; index<searchSplit.Length; index++)
                {
                    if (!isContained)
                        break;
                    if (!x.result.full_title.ToLower().Contains(searchSplit[index]))
                        isContained = false;
                }
                if(isContained)
                {
                    Song song = GetSongDataAsync(x.result.id.ToString()).Result;
                    songs.Add(song);
                }
            }
            return songs;
        }
        public ArtistSearch GetArtistData(string a)
        {
            var artistSearch = new ArtistSearch() { Songs = new List<Song>() };
            Hit[] hits = GetHits(a); 
            int artistCode;
            bool ok = false;
            int c = -1;
            var artistNameSplitted = a.Split(' ');
            while (!ok)
            {
                c++;
                if (hits[c].result.primary_artist.name.Split(' ').Length <= artistNameSplitted.Count())
                    ok = true;
                if (c == hits.Length - 1 && !ok)
                    return null;
            }
            artistCode = hits[c].result.primary_artist.id;

            var artist = GetArtistDataAsync(artistCode.ToString()).Result;
            var body = "[" + GetDynArtistDataAsync(artistCode.ToString()) + "]";
            dynamic dynArtist = JArray.Parse(body);

            artist.dynDescription = GetDescription(dynArtist);

            artistSearch.Artist = artist;
            PopulateFamousSongs(hits, artistSearch);
            
            return artistSearch;
        }

        public Hit[] GetHits(string a)
        {
            SearchResponse searchResponse = SearchAsync(a).Result;
            return searchResponse.hits;
        }
        public void PopulateFamousSongs(Hit[] hits, ArtistSearch artistSearch)
        {
            foreach (var x in hits)
            {
                if (x.result.primary_artist.id == artistSearch.Artist.id)
                {
                    Song song = GetSongDataAsync(x.result.id.ToString()).Result;
                    artistSearch.Songs.Add(song);
                }
                if (artistSearch.Songs.Count == 5)
                    break;
            }
        }
        public string GetDescription(dynamic input)
        {
            var result = "";
            dynamic children = input[0].response.artist.description.dom.children;
            foreach(var a in children)
            {
               result += $"{a1(a, "")}\n";
            }
            return result;
        }

        public string a1(dynamic a, string result)
        {
            if (a is null)
                return result;

            if (a.GetType() == typeof(JObject))
                result = a1(a.children, result);

            if (a.GetType() == typeof(JArray))
            {
                foreach (var i in a)
                {
                    result += a1(i, "");
                }
            }

            if (a.GetType() == typeof(JValue))
                return a.Value.ToString();

            return result;
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

        public string GetDynArtistDataAsync(string code)
        {
            return GetBodyAsync(artistUrl + code).Result;          
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
