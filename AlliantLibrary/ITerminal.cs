using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlliantLibrary
{
    public class ITerminal
    {
        public decimal Terminal(string userInput)
        {
            Methods methods = new Methods();
            var list = methods.Scan(userInput);
            var costTotal = methods.Total(list);
            return costTotal;
        }
    }
}
