using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Musica
{
    public class LyricsScreper
    {
        private string uid
        {
            get => "10381";
        }
        private string tokenid
        {
            get => "CYYZ5JCuHeXEyQTI";
        }
        private string titleEnc { get; set; }
        private string artistEnc { get; set; }
        private string fullXPath = "/html/body/div[1]/div/div[2]/div[1]/div/div[1]/div[1]/pre";
        private string url
        {
            get => "https://www.stands4.com/services/v2/lyrics.php?uid=" + uid + "&tokenid=" + tokenid + "&term=" + titleEnc + "&artist=" + artistEnc + "&format=json";
        }

        public string GetLyrics(string title, string artist)
        {
            if (title[title.Length - 1] == ' ')
                title.Remove(title.Length - 1);
            if (artist[artist.Length - 1] == ' ')
                artist.Remove(artist.Length - 1);

            titleEnc = title.Replace(" ", "%20");
            artistEnc = artist.Replace(" ", "%20");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(service, options))
            {
                try
                {
                    var apiCaller = new ApiCaller();
                    string lyricsResultString = apiCaller.GetBodyAsync(url).Result;
                    string lrs = lyricsResultString.Replace('-', '_');
                    LyricsResult lyricsResult = JsonConvert.DeserializeObject<LyricsResult>(lrs);
                    if (lyricsResult == null)
                    {
                        var res = lyricsResult.result[0];
                        driver.Url = res.song_link;
                        IWebElement lyricElement = driver.FindElement(By.XPath(fullXPath));
                        string RawHtml = lyricElement.GetAttribute("innerHTML");
                        return RawHtml;
                    }
                    else
                        return null;
                   
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }
    }
    public class LyricsResult
    {
        public Res[] result { get; set; }
    }
    public class Res
    {
        public string song_link { get; set; }
    }
}
