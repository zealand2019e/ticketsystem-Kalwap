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
        /// Car class attribiutes/var
        /// </summary>

        private string LicensePlate;
        
        public bool BroBizz;
        public bool broBizz
        {
            get { return BroBizz; }
            set { BroBizz = value; }
        }
       

        public string licensePlate
        {
            get { return LicensePlate; }

            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("sorry but your platenumber is incorrect");
                else
                {
                    LicensePlate = value;
                }
            }
              
          
        }

        public double price
        {
            get {
                if (BroBizz)
                {
                    return price * 0.95;
                }
                else
                {
                    return price;
                }
            }
            set
            {
                value = price;
            }
        }

        public DateTime Date { get; set; }




        /// <summary>
        /// abstract class methods ready to use for another classes with other values
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        
            
          
            

        




        //attribute
        public abstract string VehicleType();
        
            
        
            
        
        

        
        

        
    }
}
