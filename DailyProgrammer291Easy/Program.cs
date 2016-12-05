using System;
using System.Collections.Generic;

namespace DailyProgrammer291Easy
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Properties.Resources.InputText.GetType().ToString());

            string input = Properties.Resources.InputText;
            Goldilocks blondie = new Goldilocks(input);
            List <int> places = blondie.FindDinnerPlaces();
            if (places.Count > 0)
            {
                foreach(int i in places)
                {
                    Console.Write("{0} ", i);
                }
            }else
            {
                Console.WriteLine("There are no places good enough!");
            }

            Console.ReadLine();
        }
    }
}
