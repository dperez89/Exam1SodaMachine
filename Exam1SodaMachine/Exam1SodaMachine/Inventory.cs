using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1SodaMachine
{
    class Inventory
    {
        Grape grapeSodaCan;
        Orange orangeSodaCan;
        Lemon lemonSodaCan;
        List<Grape> grapeSodas = new List<Grape>();
        List<Orange> orangeSodas = new List<Orange>();
        List<Lemon> lemonSodas = new List<Lemon>();
        int startingSodaAmount = 50;

        public List<Grape> GrapeSodas
        {
            get
            {
                return grapeSodas;
            }
            set
            {
                grapeSodas = value;
            }
        }
        public List<Orange> OrangeSodas
        {
            get
            {
                return orangeSodas;
            }
            set
            {
                orangeSodas = value;
            }
        }
        public List<Lemon> LemonSodas
        {
            get
            {
                return lemonSodas;
            }
            set
            {
                lemonSodas = value;
            }
        }
        public Grape GrapeSodaCan
        {
            get
            {
                return grapeSodaCan;
            }
        }
        public Orange OrangeSodaCan
        {
            get
            {
                return orangeSodaCan;
            }
        }
        public Lemon LemonSodaCan
        {
            get
            {
                return lemonSodaCan;
            }
        }

        public Inventory()
        {
            grapeSodaCan = new Grape();
            orangeSodaCan = new Orange();
            lemonSodaCan = new Lemon();
            for(int i = 1; i <= startingSodaAmount; i++)
            {
                GenerateStartingInventory(grapeSodas, grapeSodaCan);
                GenerateStartingInventory(orangeSodas, orangeSodaCan);
                GenerateStartingInventory(lemonSodas, lemonSodaCan);
            }
        }

        private void GenerateStartingInventory<T>(List<T> sodas, T soda)
        {
            sodas.Add(soda);
        }
    }
}
