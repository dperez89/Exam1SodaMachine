﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1SodaMachine
{
    class Soda
    {
        protected string flavor;
        protected double price;

        public string Flavor
        {
            get
            {
                return flavor;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }

        public Soda()
        {

        }
    }
}
