using System;

namespace LoadClass
{
 class LoadParent
    {
        public void show()
        {
            Console.WriteLine("Parent show method is called..");
        }
        public virtual void test()//overridable
        {
            Console.WriteLine("Parent test method is called..");
        }
    }
    class LoadChild : LoadParent 
    { 
        public void show(int i)
        {
            Console.WriteLine("child  show method is called..");
        }

        public override void test()
        {
            base.test();
            {
                Console.WriteLine("child test method is called..");
            }
        }
        static void Main(string[] args)
        {
            LoadChild ld = new LoadChild();
            ld.show();
            ld.show(10);
            ld.test();
            Console.ReadLine();
        }
    }
}

