using System;
using System.Collections.Generic;
using CoordinateCalculation;

namespace CoordinateCalculationConsole
{
     static class Program
    {
        private static void Main()
        {
            var coordinateCalculation = new List<IMotion>();

//var u1 = new Uniform(20, 5, 6);
        
           // var a1 = new Accelerated(8, 9, 11, 15);

           // var e3 = new Vibrating(6, 2, 3, 4, 7);

          //  coordinateCalculation.Add(u1);
           // coordinateCalculation.Add(a1);
          //  coordinateCalculation.Add(e3);

            foreach (var test in coordinateCalculation)
            {
                Console.WriteLine("Координата = "+ test.CalculateCoordinate);
            }
            Console.ReadLine();
        }
    }
}
