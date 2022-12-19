using System;
using System.Collections.Generic;
using System.Linq;

namespace Hishab
{
    // public abstract class Dictionary
    // {
                                
    //     public abstract T hasSign<T>(T sign);
    // }

    class list //: Dictionary
    {

        private static string additionKey = "+";
        private static string subtractionKey = "-";
        private static string multiplicationKey = "*";
        private static string divisionKey = "/";
        static Add addition = new Add();
        static Sub subtraction = new Sub();
        static Div division = new Div();
        static Mul multiplication = new Mul();
          Dictionary<string, calculate> My_dict =
      new Dictionary<string, calculate>(){
                                  {additionKey, addition},
                                  {subtractionKey, subtraction},
                                  {multiplicationKey, multiplication},
                                  {divisionKey, division} };


        // public override T hasSign<T>(T sign)
        // {
        //     dynamic operatorSign = sign;
            
        //     return My_dict[operatorSign];
        // }     
        public calculate hasSign(string sign)
        {
            return My_dict[sign];
        }                     


    }

    
}