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

        private string licensePlate;
        public bool broBizz;

        /// <summary>
        /// alaways is good to make a class that include
        /// attribiutes and properties of it if its needed
        /// always the class need constructor for creating an item inside the class
        /// from the attribiutes that You have made
        /// </summary>

        public bool BroBizz
        {
            get { return BroBizz; }
            set { BroBizz = value; }
        }
       

        public string LicensePlate
        {
            get { return licensePlate; }

            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("sorry but your platenumber is incorrect");
                else
                {
                    licensePlate = value;
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
