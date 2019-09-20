using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Motorcyckle : Vehicle
    {
        /// <summary>
        /// Constructor from MOtorcyckle creates an object inherit from vehicle
        /// </summary>
        /// <param ></param>
        /// <param ></param>
        public Motorcyckle(string licensePlate, bool broBizzDiscount = false) : base(licensePlate,broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            Price = 100;
            
        }
    }
}
