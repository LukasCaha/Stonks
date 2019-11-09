using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Controllers
{
    public static class Generator
    {
        static Random rng = new Random();
        static readonly decimal Constant = 0.05M;

        /// random number between (-1,1), gaussian distribution
        static decimal RandGaussian() => (decimal)(rng.NextDouble() - rng.NextDouble());


        public static decimal RandomlyModify(decimal Value, decimal intensity = 1.0M)
        {
            return (1 + RandGaussian() * Constant * intensity) * Value;

        }
        public static decimal RandomGrowth(decimal Value, decimal intensity = 1.0M)
        {
            var modifier =  Math.Abs(RandGaussian());  
            return (1 + modifier * Constant * intensity) * Value;

        }
        public static decimal RandomFall(decimal Value, decimal intensity = 1.0M)
        {
            var modifier = -Math.Abs(RandGaussian());
            return (1 + modifier * Constant * intensity) * Value;

        }
    } 
}
