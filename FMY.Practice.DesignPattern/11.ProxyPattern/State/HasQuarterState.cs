using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.ProxyPattern
{
    public class HasQuarterState : IState
    {
        GumballMachine _machine;
        Random randomWinner = new Random();

        public HasQuarterState()
        {

        }

        public HasQuarterState(GumballMachine machine)
        {
            this._machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuater()
        {
            Console.WriteLine("quarter return");
            this._machine.SetState(_machine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(1, 11);
            if (winner < 6 && _machine.GetCount() > 1)
            {
                _machine.SetState(_machine.GetWinnerState());
            }
            else
            {
                this._machine.SetState(_machine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispended");
        }

        public override string ToString()
        {
            return "HasQuarter";
        }

        public string Print()
        {
            string output = string.Format("Machine State:{0},Inventory:{1}", this.ToString(), _machine.GetCount());

            return output;
        }
    }
}
