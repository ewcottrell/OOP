using System;

namespace AbstractEncapPolyInherit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Abstraction below. Check the property class to see encapsulation
            string typeOfProperty = "house";
            int yearBuilt = 1930;
            string location = "EastLake";
            int propertyValue = yearBuilt * 80;


            Residential house1 = new Residential();
            house1.Type = "SFH";
            house1.YearBuilt = 1945;
            house1.Location = "Avondale";
            house1.NumberOfFirePlaces = 3;

            Console.WriteLine(house1.PropertyValue());

            Console.ReadLine();







        }
    }
}
