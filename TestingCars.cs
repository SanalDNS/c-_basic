
using System;
using cars;

namespace carTesting
{
    public class testing
    {
        public static void Calll()
        {

            // Use the correct class name: Carss
            Carss newCar = new Carss();
            newCar.brand = "benz";
            newCar.SStart();  // Call instance method
        }



    }
}