using System;
namespace Hishab
{

    class Sub : calculate
    {


        public override T calc<T>(T num1, T num2)
        {

            dynamic number1 = num1;
            dynamic number2 = num2;

            Console.WriteLine("Subtraction");

            return number1 - number2;
        }



    }
}