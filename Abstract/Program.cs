using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass2 c2 = new Myclass2();
            c2.car();
            Console.ReadKey();
        }
    }
    public abstract class Myclass1
    {
        public void car()
        {
            Console.WriteLine("Car Body...");
        }
    }
    public class Myclass2:Myclass1
    {

    }
}
