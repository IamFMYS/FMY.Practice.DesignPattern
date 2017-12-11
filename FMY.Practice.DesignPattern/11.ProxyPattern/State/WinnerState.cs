using FMY.Practice.DesignPattern.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.ProxyPattern
{
    public class WinnerState : IState
    {
        GumballMachine _machine;
        public WinnerState()
        {

        }

        public WinnerState(GumballMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("You are a winner! You get two gumballs for your quarter");
            _machine.ReleaseBall();
            if (_machine.GetCount() == 0)
                _machine.SetState(_machine.GetSoldOutState());
            else
            {
                _machine.ReleaseBall();
                if (_machine.GetCount() > 0)
                    _machine.SetState(_machine.GetNoQuarterState());
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _machine.SetState(_machine.GetSoldOutState());
                }
            }
        }

        public void EjectQuater()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Winner";
        }

        public string Print()
        {
            string output = string.Format("Machine State:{0},Inventory:{1}", this.ToString(), _machine.GetCount());

            return output;
        }

    }
}
