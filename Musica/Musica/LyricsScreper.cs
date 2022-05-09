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
            get => "1001";
        }
        private string tokenid
        {
            get => "tk324324";
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
            titleEnc = HttpUtility.UrlEncode(title);
            artistEnc = HttpUtility.UrlEncode(artist);
            using (IWebDriver driver = new ChromeDriver())
            {
                try
                {
                    var apiCaller = new ApiCaller();
                    string lyricsResultString = apiCaller.GetBodyAsync(url).Result;
                    LyricsResult lyricsResult = JsonConvert.DeserializeObject<LyricsResult>(lyricsResultString);
                    var res = lyricsResult.result[0];
                    driver.Url = res.songlink;

                    IWebElement lyricElement = driver.FindElement(By.XPath(fullXPath));
                    string RawHtml = lyricElement.Text;
                    return RawHtml;
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
        public string songlink { get; set; }
    }
}
