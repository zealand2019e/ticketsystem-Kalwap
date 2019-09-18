using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{/// <summary>
/// Abstract class givin access for another classes
/// </summary>
    public abstract class Car
    {
        /// <summary>
        /// Car class attribiutes
        /// </summary>

        private string LicensePlate;


        public string licensePlate
        {
            
            
        }
        public DateTime Date { get; set; }


        
        /// <summary>
        /// abstract class methods ready to use for another classes with other values
        /// </summary>
        /// <returns></returns>
        public abstract double Price();





        public abstract string VehicleType();
        
            
        
            
        
        

        
        

        
    }
}
