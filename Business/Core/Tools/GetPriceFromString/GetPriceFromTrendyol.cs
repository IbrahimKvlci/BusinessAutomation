using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Tools.GetPriceFromString
{
    public class GetPriceFromTrendyol : IGetPrice
    {
        public string GetPrice(string text)
        {
            string price="";
            foreach (var item in text)
            {
                if (item != ',')
                {
                    price+=item;
                }
                else
                {
                    price += '.';
                }
                if(item == ' ' || item == 'T')
                {
                    break;
                }
            }
            return price;
        }
    }
}
