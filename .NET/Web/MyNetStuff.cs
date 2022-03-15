using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web;
using System.Net.Http;
using HtmlAgilityPack;


namespace MyWebUtils
{
    public class GetData{    
        public static async Task getHtml(Uri uri){
            System.Console.WriteLine("Getting html");
            
            HttpClient client = new HttpClient();
            string htmlStr;

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                htmlStr = await response.Content.ReadAsStringAsync();

                System.Console.WriteLine(htmlStr);
            }
            catch (HttpRequestException e)
            {
                System.Console.WriteLine("\nException Caught!");
                System.Console.WriteLine("Message :{0} ", e.Message);
            }

        }
    }
}

namespace WebScraping
{
    public class AutoResume
    {
        public static void getHtml(Uri uri)
        {
            // string url = "http://html-agility-pack.net/";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(uri);

            HtmlNodeCollection nodes = doc
                                            .DocumentNode
                                            .SelectNodes("//a[@href]");
            List<string> hrefTags = new List<string>();

            if(nodes != null)
            {
                foreach(HtmlNode node in nodes)
                {
                    hrefTags.Add(node.GetAttributeValue("href",null));
                }
            }



            foreach(string tag in hrefTags)
            {
                System.Console.WriteLine(tag);
            }
        }
    }
}