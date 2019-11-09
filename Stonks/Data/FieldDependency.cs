using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Data
{
    class FieldDependency
    {
        public int ID { get; set; }
        public int Share2ID { get; set; }
        public int Share1ID { get; set; }

        public decimal Modifier { get; set; }


    }
}
