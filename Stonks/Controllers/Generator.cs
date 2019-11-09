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

        /// random number between (-1,1), gaussian distribution
        static double RandGaussian() => rng.NextDouble() - rng.NextDouble();


        public static double RandomlyModify(double Value, double intensity = 1.0)
        {
            return (1 + RandGaussian() * Constant * intensity) * Value;

        }
        public static double RandomGrowth(double Value, double intensity = 1.0)
        {
            double modifier =  Math.Abs(RandGaussian());  
            return (1 + modifier * Constant * intensity) * Value;

        }
        public static double RandomFall(double Value, double intensity = 1.0)
        {
            double modifier = -Math.Abs(RandGaussian());
            return (1 + modifier * Constant * intensity) * Value;

        }
    } 
}
