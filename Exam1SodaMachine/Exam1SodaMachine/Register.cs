using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1SodaMachine
{
    class Register
    {
        List<Penny> pennies = new List<Penny>();
        List<Nickel> nickels = new List<Nickel>();
        List<Dime> dimes = new List<Dime>();
        List<Quarter> quarters = new List<Quarter>();
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter;
        int startingPenniesAmount = 50;
        int startingNickelsAmount = 20;
        int startingDimesAmount = 10;
        int startingQuartersAmount = 20;

        public List<Penny> Pennies
        {
            get
            {
                return pennies;
            }
            set
            {
                pennies = value;
            }
        }
        public List<Nickel> Nickels
        {
            get
            {
                return nickels;
            }
            set
            {
                nickels = value;
            }
        }
        public List<Dime> Dimes
        {
            get
            {
                return dimes;
            }
            set
            {
                dimes = value;
            }
        }
        public List<Quarter> Quarters
        {
            get
            {
                return quarters;
            }
            set
            {
                quarters = value;
            }
        }
        public Penny Penny
        {
            get
            {
                return penny;
            }
        }
        public Nickel Nickel
        {
            get
            {
                return nickel;
            }
        }
        public Dime Dime
        {
            get
            {
                return dime;
            }
        }
        public Quarter Quarter
        {
            get
            {
                return quarter;
            }
        }
        public Register()
        {
            for (int i = 1; i <= startingPenniesAmount; i++)
            {
                penny = new Penny();
                GenerateStartingCurrency(Pennies, penny);
            }
            for (int i = 1; i <= startingNickelsAmount; i++)
            {
                nickel = new Nickel();
                GenerateStartingCurrency(Nickels, nickel);
            }
            for (int i = 1; i <= startingDimesAmount; i++)
            {
                dime = new Dime();
                GenerateStartingCurrency(Dimes, dime);
            }
            for (int i = 1; i <= startingQuartersAmount; i++)
            {
                quarter = new Quarter();
                GenerateStartingCurrency(Quarters, quarter);
            }
        }

        private void GenerateStartingCurrency<T>(List<T> coins, T coin)
        {

            coins.Add(coin);
        }
    }
}
