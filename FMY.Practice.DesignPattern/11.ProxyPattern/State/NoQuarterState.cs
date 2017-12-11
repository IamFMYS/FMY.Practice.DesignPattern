using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.ProxyPattern
{
    public class NoQuarterState : IState
    {
        GumballMachine _machine;
        public NoQuarterState()
        {

        }

        public NoQuarterState(GumballMachine machine)
        {
            this._machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert Quarter Success");
            _machine.SetState(_machine.GetHasQuarterState());
        }

        public void EjectQuater()
        {
            Console.WriteLine("no quarter can't eject");
        }

        public void TurnCrank()
        {
            Console.WriteLine("no quarter can't turn crank");
        }

        public void Dispense()
        {
            Console.WriteLine("no quarter can't dispense");
        }

        public override string ToString()
        {
            return "NoQuarter";
        }

        public string Print()
        {
            string output = string.Format("Machine State:{0},Inventory:{1}", this.ToString(), _machine.GetCount());

            return output;
        }

    }
}
