using System;
namespace AbstractEncapPolyInherit
{
    public class Commercial : Property
    {
        //Inheritance here Also Polymorphism
        private int PropertyValue(int yearbuilt, int yearbuildinglastupdated, int numberOfStories)
        {
            if (yearbuildinglastupdated > 2010 && numberOfStories > 2)
            {
                return yearbuildinglastupdated * 700; 
            }
            else if (yearbuildinglastupdated < 2010 && yearbuildinglastupdated > 1990  && numberOfStories > 2)
            {
                return yearbuilt * 500; 
            }
            else if (yearbuildinglastupdated < 1990 && yearbuildinglastupdated > 1980)
            {
                return yearbuildinglastupdated * 400;
            }

            return 100000;
        }
    }
}
