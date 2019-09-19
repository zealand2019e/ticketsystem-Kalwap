using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC : Car 
    {
       

        /// <summary>
        /// class values with ovverided methods
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 125;
        }
        
        public override string VehicleType()
        {
            return "MC";
        }

        
        
            
        
    }
}
