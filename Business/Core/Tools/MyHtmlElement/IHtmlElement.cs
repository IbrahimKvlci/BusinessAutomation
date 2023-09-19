using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Tools.MyHtmlElement
{
    public interface IHtmlElement
    {
        string GetValueFromWebsite(string website);
    }
}
