using System;

namespace Program1
{
    class BasicProgram
    {
       static void Loop()
        {
            for(int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                   
                }
                Console.WriteLine(i);
            }
        }
        static void statement()
        {
        ineligible:
            Console.WriteLine("You are not eligible to vote...");


            Console.WriteLine("Enter your Age..");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                goto ineligible;
            else
            {
                Console.WriteLine("you are eligible to vote..");
            }
        }
       static void Arraymethod(int[] arr)
        {
            Console.WriteLine("printing array element");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //Jagged arry
        public void Jaggedarray()
        {
            int[][] Arr = new int[2][];
            Arr[0] =new int[] { 12,34,55,9,77,09};
            Arr[1] = new int[] { 3, 4, 67, 54, 78, 98 };

            for(int i=0;i<Arr.Length;i++)
            {
                for(int j = 0; j < Arr[i].Length; j++)
                {
                    Console.WriteLine(Arr[i][j] + "");
                }
                Console.ReadLine();
            }
        }
        //Param keyword 
        static void show(params int[] val)
        {
            for(int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Loop();
            statement();

            //array
            int[] arr1 = { 20, 23, 34, 12, 34 };
            int[] arr2 = { 34, 55, 60, 13, 34, 23 };
            Arraymethod(arr1);
            Arraymethod(arr2);

            BasicProgram bp = new BasicProgram();
            bp.Jaggedarray();

            //params
            //why params keyword is ->when we don't know the number of arguments is is prior.
            show(2, 3, 4, 6, 8, 5);

            //inheritance 
            //inheriting fields.
            Programmer p1 = new Programmer();
            Console.WriteLine("Salary :" +p1.salary);
            Console.WriteLine("Bonus :" + p1.bonus);


            //Has a relationship
            Address a1 = new Address("G-13, sec-3","Noida", "UP");
            Employee1 e1 = new Employee1(123, "abhay", a1);
            e1.Display();

            Console.WriteLine("...................");
            //delegates

            


        }
    }
}
