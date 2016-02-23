using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8._1
{
    class Program
    {
        static void Main(string[] args)
        {



            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("another post");
            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
