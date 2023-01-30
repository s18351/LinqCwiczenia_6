using System;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = LinqTasks.Task4().ToList();
            LinqTasks.Task14().ToList().ForEach(a => Console.WriteLine(a.Dname));

            //Console.WriteLine(LinqTasks.Task13(new int[]{ 1,1,1,1,1,1,10,1,1,1,1}));

        }
    }
}
