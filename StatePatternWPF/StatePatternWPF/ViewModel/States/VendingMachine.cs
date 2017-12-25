using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternWPF.ViewModel.States
{
    public class VendingMachine
    {
        public int ItemCount { get; set; }

        public AVendingMachineState NoCoinState { get; private set; }
        public AVendingMachineState CoinInsertedState { get; private set; }
        public AVendingMachineState CurrentState { get; set; }

        public VendingMachine()
        {
            NoCoinState = new NoCoinState(this);
            CoinInsertedState = new CoinInsertedState(this);
            CurrentState = NoCoinState;
        }

        public string InsertCoin()
        {
            return CurrentState.InsertCoin();
        }

        public string ReturnCoin()
        {
            return CurrentState.ReturnCoin();
        }

        public string Vend()
        {
            return CurrentState.Vend();
        }

        public string Refill(int _qty)
        {
            ItemCount += _qty;
            return String.Format("Items in the machine: {0}", ItemCount.ToString());
        }
    }
}
