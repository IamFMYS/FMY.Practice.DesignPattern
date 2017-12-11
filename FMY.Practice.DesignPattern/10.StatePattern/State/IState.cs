using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Practice.DesignPattern.StatePattern
{
    public interface IState
    {
        /// <summary>
        /// 投币
        /// </summary>
        void InsertQuarter();

        /// <summary>
        /// 退币
        /// </summary>
        void EjectQuater();

        /// <summary>
        /// 转动糖果机
        /// </summary>
        void TurnCrank();

        /// <summary>
        /// 糖果机糖果减少
        /// </summary>
        void Dispense();

        string Print();
    }
}
