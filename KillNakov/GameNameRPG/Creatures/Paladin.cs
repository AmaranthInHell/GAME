
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;

namespace GameNameRPG.Creatures
{
    class Paladin : Hero
    {
        private static new readonly int damage = 50;
        private static new readonly int healthPoints = 100;
        private static new int stepsPerMove = 1;
        private static new char objectSymbol = 'P';
        private static string type = "Paladin";

        public Paladin(Position position, char objectSymbol,string name) 
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
