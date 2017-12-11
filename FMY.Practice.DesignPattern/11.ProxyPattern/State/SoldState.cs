using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.ProxyPattern
{
    public class SoldState : IState
    {
        GumballMachine _machine;

        public SoldState()
        {

        }

        public SoldState(GumballMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Please wait , we're already giving you a gumball");
        }

        public void EjectQuater()
        {
            Console.WriteLine("Sorry , you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Turning twicw doesn't get you another gumball!");
        }

        public void TurnCrank()
        {
            _machine.ReleaseBall();
            if (_machine.GetCount() > 0)
            {
                _machine.SetState(_machine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _machine.SetState(_machine.GetSoldOutState());
            }
        }

        public override string ToString()
        {
            return "Sold";
        }

        public string Print()
        {
            string output = string.Format("Machine State:{0},Inventory:{1}", this.ToString(), _machine.GetCount());

            return output;
        }
    }
}
