using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public  class Motorcyckle : Car
    {
        public override double Price()
        {
            return 100;

            
        }

        public override string VehicleType()
        {
            return "MotorCykler";
        }



    }
}
