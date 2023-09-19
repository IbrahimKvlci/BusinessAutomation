using Business.Core.Tools.MyWebClient.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Tools.MyWebClient.Concrete
{
    public class MyWebClient : IWebClient
    {
        WebClient _webClient;
        public MyWebClient()
        {
            _webClient = new WebClient();
        }
        public string GetDataHtml(string website)
        {
           Uri uri = new Uri(website);
           return _webClient.DownloadString(uri);
        }
    }
}
