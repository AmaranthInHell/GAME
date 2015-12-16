
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;

namespace GameNameRPG.Creatures
{
    public class Hunter : Hero
    {
        private static new readonly int damage=30;
        private static new readonly int healthPoints=70;
        private static new readonly int stepsPerMove=3;
        private static new readonly char objectSymbol = 'H';
        private static readonly string type = "Hunter";

        public Hunter(Position position, char objectSymbol,string name) 
            : base(position, ObjectSymbol, name, Damage, HealthPoints, StepsPerMove)
        {

        }
        public static new int Damage 
        {
            get { return damage; }
        }
        public static new int HealthPoints
        {
            get { return healthPoints; }
        }
        public static new int StepsPerMove
        {
            get { return stepsPerMove; }
        }
        public static new char ObjectSymbol
        {
            get { return objectSymbol; }
        }
        public static string Type 
        {
            get { return type; }
        }
     


    }
}
