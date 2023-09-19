using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Tools.HtmlAgility.Abstract
{
    public interface IHtmlAgility
    {
        string GetContentFromHtml(string html, string node);
        string GetContentFromHtmlWithAttributes(string html, string node,string attribute);
        string GetContentFromWebSite(string url, string node);
        string GetContentFromWebSiteWithAttributes(string url, string node, string attribute);
    }
}
