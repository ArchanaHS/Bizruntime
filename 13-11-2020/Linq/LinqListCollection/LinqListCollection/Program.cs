
using System;
using System.Text;

using System.Linq;
using LinqListCollection;

//linq->language integrated query.
namespace ConsoleApp1
{
    class Programer
    {
        static void Main(string[] args)
        {

            SimpleLinq Sq = new SimpleLinq();
            Sq.Method();

            SimpleLinqq LM = new SimpleLinqq();
            LM.LinQM();

            MixedLinq MLQ = new MixedLinq();
            MLQ.Method1();

        }
    }
}