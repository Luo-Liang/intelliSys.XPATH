using HtmlAgilityPack;
using intelliSys.XPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            var html = client.DownloadString("http://www.merriam-webster.com/word-of-the-day/");
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            Console.WriteLine(doc.DocumentNode.INSSSelectSingleNode("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[5]").InnerText);
        }
    }
}
