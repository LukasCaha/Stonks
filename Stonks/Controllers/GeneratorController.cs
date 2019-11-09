using Stonks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Controllers
{
    public class GeneratorController
    {
        public List<Stock> GenerateData(int numberOfIterations, )
        {
            List<Stock> stocks = new List<Stock>();
            //getdataforgenerator
            foreach (Stock stock in stocks) {
                for (int i = 0; i < numberOfIterations; i++)
                {
                    Generator.RandomlyModify(stock.Value);
                }
            }
        }
    }
}
