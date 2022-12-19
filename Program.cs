using System;
using System.Collections.Generic;
using System.Linq;

namespace Hishab
{

    class program
    {

        static void Main(string[] args)
        {
            //string g = "sub";

            dynamic num1, num2, sign;
            double n1, n2;

            // string additionKey = "+";
            // string subtractionKey = "-";
            // string multiplicationKey = "*";
            // string divisionKey = "/";

            num1 = Console.ReadLine();
            sign = Console.ReadLine();
            num2 = Console.ReadLine();

            n1 = Double.Parse(num1);
            n2 = Double.Parse(num2);

            //         Add addition = new Add();
            //         Sub subtraction = new Sub();
            //         Div division = new Div();
            //         Mul multiplication = new Mul();

            //         Dictionary<string, calculate> My_dict =
            //   new Dictionary<string, calculate>(){
            //                               {additionKey, addition},
            //                               {subtractionKey, subtraction},
            //                               {multiplicationKey, multiplication},
            //                               {divisionKey, division} };

            // for (int x = 0; x < My_dict.Count; x++)
            // {
            //     Console.WriteLine("{0} and {1}", My_dict.Keys.ElementAt(x),
            //                          My_dict[ g ]);
            // }


            list mathOperator = new list();
            calculate solve = mathOperator.hasSign(sign);
               // Console.WriteLine(solve);
            

            double result = solve.calc(n1, n2);
             Console.WriteLine("{0}",result);

            //  double r = My_dict[sign].calc(n1,n2);
            //  Console.WriteLine("{0}",r);

        }


    }

}
