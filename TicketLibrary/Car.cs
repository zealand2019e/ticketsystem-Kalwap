using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{ 
    public class Car : Vehicle

    {
        /// <summary>
        /// constructor from Car inherit Vehicle
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="broBizzDiscount"></param>
        public Car(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            Price = 240;
          
            
            
        }
    }
    
}
