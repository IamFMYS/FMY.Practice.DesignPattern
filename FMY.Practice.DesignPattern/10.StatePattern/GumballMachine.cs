using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.StatePattern
{
    public class GumballMachine
    {
        IState _state;
        IState _noQuarterState;
        IState _hasQuarterState;
        IState _soldOutState;
        IState _soldState;
        IState _winnerState;
        int _count = 0;


        public GumballMachine(int count)
        {
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldOutState = new SoldOutState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            _state = _noQuarterState;
            _count = count;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuater();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public  void SetState(IState state)
        {
            this._state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("a Gumball comes rolling out the slot...");
            if (_count != 0)
                _count--;
        }

        #region [GetMachineState          ]
        public IState GetNoQuarterState()
        {
            return this._noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return this._hasQuarterState;
        }

        public IState GetSoldOutState()
        {
            return this._soldOutState;
        }

        public IState GetWinnerState()
        {
            return this._winnerState;
        }

        public IState GetSoldState()
        {
            return this._soldState;
        } 
        #endregion

        public int GetCount()
        {
            return _count;
        }

        public override string ToString()
        {
            return this._state.Print();
        }

    }
}
