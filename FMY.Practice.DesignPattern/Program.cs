using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMY.Practice.DesignPattern.StatePattern;

namespace FMY.Practice.DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine machine = new GumballMachine(5);
            int count = 0;
            while (true)
            {
                count++;
                
                Console.WriteLine(machine.ToString());
                Console.ReadKey();

                Console.WriteLine("-------------------------");

                machine.InsertQuarter();
                machine.TurnCrank();
                Console.WriteLine(machine.ToString());
                Console.ReadKey();

                Console.WriteLine("-------------------------");

                machine.InsertQuarter();
                machine.TurnCrank();
                machine.InsertQuarter();
                machine.TurnCrank();
                Console.WriteLine(machine.ToString());

                Console.ReadKey();
                Console.WriteLine(string.Format("*********{0}*********",count));
            }
        }
    }
}
