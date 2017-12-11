using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.ProxyPattern
{
    public class SoldOutState : IState
    {
        GumballMachine _machine;

        public SoldOutState()
        {

        }

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("There is not quarter, please don't insert quarter!");
        }
       
        public void EjectQuater()
        {
            Console.WriteLine("You can't eject quarter!");
        }
       
        public void TurnCrank()
        {
            Console.WriteLine("You can't turn crank!");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed!");
        }

        public override string ToString()
        {
            return "SoldOut";
        }

        public string Print()
        {
            string output = string.Format("Machine State:{0},Inventory:{1}", this.ToString(), _machine.GetCount());

            return output;
        }

    }
}
