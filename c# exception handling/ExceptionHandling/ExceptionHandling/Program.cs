using System;
namespace ExceptionHandiling
{
    class Cexception
    {
        public void Display() 
        {

            try //while executing,define a block of code tested for error.
            {
                Console.WriteLine("Enter the 1st number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);

            } 
            catch (DivideByZeroException e) //to define block of code to be executed.
            {
                Console.WriteLine(e.Message);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("EXECUTED");
            }
        }

        public void DisplayThrow(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        static void Main(string[] args)
        {
            Cexception exp = new Cexception();
            exp.Display();
            exp.DisplayThrow(16);

        }

    }
}