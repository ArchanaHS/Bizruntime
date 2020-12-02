using System;

namespace CalculatorApplication
{

    class NumberManipulator
    {

        public int FindMax(int num1, int num2)//method declaration
        /*<Access Specifier> <Return Type> <Method Name>(Parameter List) {
                Method Body
            }*/
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator(); // object declaration

            //calling the FindMax method
            ret = n.FindMax(a, b);// method calling.
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}