using System;
using System.IO;

using System.Threading.Tasks;

namespace Taskfactory
{
    class FactoryProgram
    {
        public void FactoryMethod()
        {
            Task[]  tasks= new Task[2];
            String[] files = null;
            String[] dirs = null;
            string DocsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            tasks[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(DocsDirectory));
            tasks[1] = Task.Factory.StartNew(() => dirs = Directory.GetDirectories(DocsDirectory));
          


            Task.Factory.ContinueWhenAll(tasks, completedTasks =>
            {
                Console.WriteLine("{0} contains: ", DocsDirectory);
                Console.WriteLine("{0} subdirectories", dirs.Length);
                Console.WriteLine("{0} files", files.Length);
                
            });
        }
        static void Main(string[] args)
        {
            FactoryProgram fc = new FactoryProgram();
            fc.FactoryMethod();
        }
    }
}
