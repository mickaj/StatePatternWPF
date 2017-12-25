using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternWPF.ViewModel.States
{
    public class NoCoinState : AVendingMachineState
    {
        public NoCoinState(VendingMachine _machine)
            :base(_machine)
        {
        }

        public override string InsertCoin()
        {
            machine.CurrentState = machine.CoinInsertedState;
            return "Coin inserted";
        }

        public override string ReturnCoin()
        {
            return "No coin inserted! Cannot return!";
        }

        public override string Vend()
        {
            return "No coin inserted! You can't get anything for free!";
        }
    }
}
