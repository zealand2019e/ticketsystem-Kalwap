using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC : Vehicle
    {

        /// <summary>
        /// constructor for MC inherit from base
        /// </summary>
        /// <param /param>
        public MC(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            Price = 125;
            





        }
    }
}
