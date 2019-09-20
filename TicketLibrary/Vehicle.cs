using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Vehicle
    {
        //all the attribiutes/variables
        public string licensePlate;
        public bool broBizz;
        public double price;
        public string vehicleType;
        public DateTime date;


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

        /// <summary>
        /// ALL THE PROPERTIES
        /// </summary>
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

        public double Price
        {
            get
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)

                {
                    if (BroBizz)
                    {
                        return (price * 0.80) * 0.95;
                    }
                    else
                    {
                        return price * 0.95;
                    }
                }



                else
                {
                    if (BroBizz)
                    {
                        return price * 0.95;
                    }
                    else
                    {
                        return price;
                    }
                }
            }
            set
            {
                value = price;
            }
        }

        public DateTime Date { get; set; }


        public string VehicleType
        {
            get { return vehicleType; }
            set { VehicleType = value; }
        }




        //CONSTRUCTOR to create an object

        public Vehicle(string licensePlate, bool broBizzDiscount = false )
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
          
            
        }






















    } 
}


