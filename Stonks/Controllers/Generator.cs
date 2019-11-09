using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Controllers
{
    public static class Generator
    {
        static Random rng = new Random();
        static readonly double Constant = 0.05;
        public static double RandomlyModify(double Value, double intensity = 1.0)
        {
            double modifier = rng.NextDouble() - rng.NextDouble();   // random number between (-1,1), gaussian distribution
            return (1 + modifier * Constant * intensity) * Value;

        }
    } 
}
