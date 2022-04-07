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
		public void GetArtistData(string artist)
        {
			//Task<int> code = GetArtistCodeAsync(artist);
        }

		public async Task<string> GetArtistCodeAsync(string artist)
        {
			string encArtist = HttpUtility.UrlEncode(artist);
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://genius.p.rapidapi.com/search?q="+encArtist),
				Headers =
	{
		{ "X-RapidAPI-Host", "genius.p.rapidapi.com" },
		{ "X-RapidAPI-Key", "SIGN-UP-FOR-KEY" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				return body;
			}
		}
        public async Task GetArtistDataAsync(string code)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://genius.p.rapidapi.com/artists/"+code),
				Headers =
	{
		{ "X-RapidAPI-Host", "genius.p.rapidapi.com" },
		{ "X-RapidAPI-Key", "SIGN-UP-FOR-KEY" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
			}
		}
		public void Call(string artist)
		{
			string encArtist = HttpUtility.UrlEncode(artist);
			var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://genius.p.rapidapi.com/search?q=" + encArtist);
			//httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";
			httpWebRequest.Headers.Add("X-RapidAPI-Host", "genius.p.rapidapi.com");
			httpWebRequest.Headers.Add("X-RapidAPI-Key", "SIGN-UP-FOR-KEY");
			try
			{
				using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
				{
					string json = JsonConvert.SerializeObject(streamWriter);

					//streamWriter.Write(nomeProdotto);
				}

				//var httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
				//List<Product> response = new List<Product>();
				//string result = "";
				////CreaTelecameraResponse response;
				//using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				//{
				//	result = streamReader.ReadToEnd();
				//	//response = JsonConvert.DeserializeObject<List<Product>>(result);
				//}
				//return result;
			}
			catch (Exception ex)
			{
				//return null;
			}
		}
	}
}
