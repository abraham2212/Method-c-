using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    public class Calculator
    {

       
        
            public string Calculation(int num1, int num2, string operation)
            {
                double result;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        return result.ToString();


                    case "-":
                        result = num2 - num1;
                        return result.ToString();


                    case "*":
                        result = num1 * num2;
                        return result.ToString();


                    case "/":
                        result = num2 / num1;
                        return result.ToString();

                    default:

                        return " please add correct operation";

                }




            }













        }
    }




