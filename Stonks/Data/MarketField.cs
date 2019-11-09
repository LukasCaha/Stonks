using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Data
{
    class MarketField
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int[] dependencyIDs { get; set; }

    }
}
