using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Processing_JSON_in.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            string XMLpath = "../../videos.xml";
            string savePathToJSON = "../../rss.json";
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.DownloadFile("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", XMLpath);

            var doc = XDocument.Load(XMLpath);

            Console.WriteLine("----------------------------------------------");
            string json = GetJsonFromXml(doc);
            Console.WriteLine(json);
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("All video titles\n");
            Console.WriteLine(string.Join(",", GetAllVideoTitles(json)));
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("----------------------------------------------");
            var videos = GetAllPocoVideos(json);
            Console.WriteLine("All videos\n");
            foreach (var video in videos)
            {
                Console.WriteLine(video.Title + " " + video.Author.Name + " " + video.Url.Href);
            }
            Console.WriteLine("----------------------------------------------");

            string html = CreateHTMLFromPocoObj(videos);
            using (StreamWriter writer = new StreamWriter("../../videos.html"))
            {
                writer.Write(html);
                
            }
            


        }

         static string CreateHTMLFromPocoObj(IEnumerable<Video> videos)
        {
            StringBuilder builder=new StringBuilder();
            builder.Append("<!DOCTYPE html><meta charset=\"utf-8\" /><html><body>");
            foreach (var video in videos)
            {
                builder.AppendFormat("<div style=\"float:left; width: 400px; height: 400px; margin-right:20px; margin-top:70px\">" +
                                   "<h3>{2}</h3><a href=\"{0}\">YouTube Link</a>" +
                                  "<iframe width=\"400\" height=\"400\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "</div>",
                                  video.Url.Href, video.Id, video.Title);
            }
            builder.Append("</body></html>");
             return builder.ToString();
        }


        static string GetJsonFromXml(XDocument doc)
        {
            string json = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            return json;

        }

        static IEnumerable<JToken> GetAllVideoTitles(string json)
        {
            var jsonObj = JObject.Parse(json);

            var titles = jsonObj["feed"]["entry"].Select(x => x["title"]);
            return titles;
        }

        static IEnumerable<Video> GetAllPocoVideos(string json)
        {
            var jsonObj = JObject.Parse(json);
            var videos = jsonObj["feed"]["entry"].Select(x => JsonConvert.DeserializeObject<Video>(x.ToString()));
            return videos;
        }
    }
}
