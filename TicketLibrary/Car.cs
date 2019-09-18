using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    class Car
    {
        /// <summary>
        /// Car class attribiutes
        /// </summary>
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Car class methods contains fixed values
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }
        
        public string VehicleType()
        {
            return "Car";
        }

        
        

        
    }
}
