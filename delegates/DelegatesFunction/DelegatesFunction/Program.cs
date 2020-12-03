using System;

delegate int NumberChanger(int n);
namespace DelegatesFunction
{
    class Program
    {
        static int num = 1;
        public static int AddNum(int P)
        {
            num += P;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create instance of delegate.
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            //nc1(24);
            //Console.WriteLine("Value of num: {0}", getNum());
            nc2(50);
            Console.WriteLine("Value of num :{0}", getNum());

            nc = nc1;
            nc += nc2;
            //multicast delegate.
            nc(5);
            Console.WriteLine("Value of num :{0}", getNum());
            Console.ReadLine();


        }
    }
}
