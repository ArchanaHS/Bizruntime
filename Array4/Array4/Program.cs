using System;

namespace Array4
{
    class Foreach
    {

        private void arraymethod()
        {
            Char[] Gender = { 'm', 'f', 'm', 'f', 'f', 'm', 'm', 'm', 'f', 'f', 'm' };
            int male = 0, female = 0;
            foreach (char G in Gender)
            {
                if (G == 'm')
                    male++;
                else if (G == 'f')
                    female++;


            }
            Console.WriteLine("number of male= {0}", male);
            Console.WriteLine("number of female= {0}", female);

        }

        static void Main(string[] args)
        {

            Foreach a = new Foreach();
            
            a.arraymethod();
          

        }
    }
}

