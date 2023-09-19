using Business.Core.Tools.HtmlAgility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Business.Core.Tools.HtmlAgility.Concrete
{
    public class HtmlAgility : IHtmlAgility
    {
       
        public HtmlAgility()
        {
             
        }

        public string GetContentFromHtml(string html,string node)
        {
            try
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);

                var items = htmlDoc.DocumentNode.SelectNodes(node);
                return items[0].InnerText;
            }
            catch (Exception)
            {

                return string.Empty;
            }
            
        }

        public string GetContentFromHtmlWithAttributes(string html, string node, string attribute)
        {
            try
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);
                var item = htmlDoc.DocumentNode.SelectSingleNode(node).GetAttributeValue(attribute, "");
                return item;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
            
        }

        public string GetContentFromWebSite(string url, string node)
        {
            try
            {
                var httpClient = new HttpClient();
                var html = httpClient.GetStringAsync(url).Result;
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);

                var item = htmlDoc.DocumentNode.SelectSingleNode(node);
                return item.InnerText.Trim();

            }
            catch (Exception)
            {

                return string.Empty;
            }
            
        }
        public string GetContentFromWebSiteWithAttributes(string url, string node,string attribute)
        {
            try
            {
                var httpClient = new HttpClient();
                var html = httpClient.GetStringAsync(url).Result;
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);

                var item = htmlDoc.DocumentNode.SelectSingleNode(node).GetAttributeValue(attribute, "");
                return item.Trim();

            }
            catch (Exception)
            {

                return string.Empty;
            }
        }
    }
}
