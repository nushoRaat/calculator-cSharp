using System;
namespace Hishab
{

    
    class Add : calculate
    {


        public override T calc<T>(T num1, T num2)
        {
            dynamic number1 = num1;
            dynamic number2 = num2;

            Console.WriteLine("Addition");

            return number1 + number2;
        }

    }
}
