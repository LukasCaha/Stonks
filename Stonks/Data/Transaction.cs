using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Data
{
    enum TransactionType { Buy, Sell }

    class Transaction
    {
        public TransactionType Type { get; set; }
        public int UserId { get; set; }
        public int StockId { get; set; }
        public int Amount { get; set; }

        /// <summary>
        /// time in game iterations from start
        /// </summary>
        public long Time { get; set; }
    }
}
