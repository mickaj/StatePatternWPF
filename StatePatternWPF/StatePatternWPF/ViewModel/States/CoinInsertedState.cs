using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternWPF.ViewModel.States
{
    public class CoinInsertedState : AVendingMachineState
    {
        public CoinInsertedState(VendingMachine _machine)
            : base(_machine)
        {
        }

        public override string InsertCoin()
        {
            return "Cannot insert more than one coin!";
        }

        public override string ReturnCoin()
        {
            machine.CurrentState = machine.NoCoinState;
            return "Coin returned.";
        }

        public override string Vend()
        {
            if(machine.ItemCount>0)
            {
                machine.ItemCount--;
                machine.CurrentState = machine.NoCoinState;
                return "An item has been vended.";
            } else
            {
                return "No more items in the machine. Please refill!";
            }
        }
    }
}
