using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks.Models.Persons
{

    //TODO individual directory @Ryba
    enum RPG_Class { Barbarian, Wizard, Monk, Necromancer, Druid, Bard, Rogue, Marksman } //TODO: rename classes
    class User : Person
    {
        public int ID { get; set; }
        public decimal Balance { get; set; }
        public Stock[] Portfolio { get; set; }
        /// <summary>
        /// transaction IDs
        /// </summary>
        public int[] History { get; set; }

        public RPG_Class Specialization { get; set; }

    }




}
