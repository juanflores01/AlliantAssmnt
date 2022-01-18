using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliantLibrary
{
    //interface ITerminal
    //{
    //    //List<KeyValuePair<string, int>> Scan(string item);
    //    //decimal Total(List<KeyValuePair<string, int>> list);
    //}

    public class Methods 
    {
        public decimal sumTotal;
        public List<KeyValuePair<string, int>> productList;

        public List<KeyValuePair<string, int>> Scan(string input)
        {
            char charA = 'A';
            char charB = 'B';
            char charC = 'C';
            char charD = 'D';

            int freqA = input.Count(f => (f == charA));
            int freqB = input.Count(f => (f == charB));
            int freqC = input.Count(f => (f == charC));
            int freqD = input.Count(f => (f == charD));

            productList = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("A", freqA),
                new KeyValuePair<string, int>("B", freqB),
                new KeyValuePair<string, int>("C", freqC),
                new KeyValuePair<string, int>("D", freqD)
            };

            return productList;
        }

        public decimal Total(List<KeyValuePair<string, int>> list)
        {

            int freqA = 0;
            int freqB = 0;
            int freqC = 0;
            int freqD = 0;

            freqA = list.First(c => c.Key == "A").Value;
            freqB = list.First(c => c.Key == "B").Value;
            freqC = list.First(c => c.Key == "C").Value;
            freqD = list.First(c => c.Key == "D").Value;

            decimal freqACount = 0;
            decimal freqBCount = 0;
            decimal freqCCount = 0;
            decimal freqDCount = 0;

            if (freqA != 0)
            {
                int countOfModulo = freqA % 4;
                int countOfDivisible = ((freqA - countOfModulo) / 4);

                int sumOfNormPrice = countOfModulo * 2;
                int sumOfSalePrice = countOfDivisible * 7;

                freqACount = sumOfNormPrice + sumOfSalePrice;
            }

            if (freqB != 0)
            {
                freqBCount = freqB * 12;
            }

            if (freqC != 0)
            {
                int countOfModulo = freqC % 6;
                int countOfDivisible = ((freqC - countOfModulo) / 6);

                decimal sumOfNormPrice = countOfModulo * 1.25m;
                decimal sumOfSalePrice = countOfDivisible * 6;

                freqCCount = sumOfNormPrice + sumOfSalePrice;
            }

            if (freqD != 0)
            {
                freqDCount = freqD * 0.15m;
            }

            sumTotal = freqACount + freqBCount + freqCCount + freqDCount;

            return sumTotal;
        }
    }
}
