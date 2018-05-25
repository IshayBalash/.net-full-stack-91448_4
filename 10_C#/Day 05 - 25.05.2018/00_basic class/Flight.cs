/*
  ctor + tab tab        --> auto generates constructor

  prop + tab tab        --> auto generates public property

  propfull + tab tab    --> auto generates public+private property

  control + k + s       --> to add region
 */

using System;


namespace _00_basic_class
{
    class Flight
    {
        //---------------------constructors--------------------
        public Flight(){}

        public Flight(int price)
        {
            FlightPrice = price;
        }

        //---------------------functions--------------------
        #region bool CheckFlightPrice(int flightPrice)
        public bool CheckFlightPrice(int flightPrice)
        {
            return this.flightPrice == flightPrice;
        } 
        #endregion



        //---------------------properties--------------------
        #region FlightNumber prop
        public int FlightNumber { get; set; } 
        #endregion

        #region FlightPrice propfull
        private int flightPrice;

        public int FlightPrice
        {
            get { return flightPrice; }
            set
            {

                flightPrice = Math.Abs(value);
            }
        } 
        #endregion


    }
}
