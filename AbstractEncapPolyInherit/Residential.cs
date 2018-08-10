using System;
namespace AbstractEncapPolyInherit
{
    public class Residential : Property 

    {
        //Inheritance here
        public int NumberOfFirePlaces { get; set; }

        private int getPropertyValue(int yearbuilt)
        {
            return yearbuilt * 80;
        }

        public int PropertyValue()
        {
            return getPropertyValue(YearBuilt);
        }

    }
}
