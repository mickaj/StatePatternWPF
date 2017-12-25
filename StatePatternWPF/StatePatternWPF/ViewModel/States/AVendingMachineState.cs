using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternWPF.ViewModel.States
{
    public abstract class AVendingMachineState
    {
        protected VendingMachine machine;
     
        public AVendingMachineState(VendingMachine _machine)
        {
            machine = _machine;
        }

        public abstract string InsertCoin();
        public abstract string ReturnCoin();
        public abstract string Vend();
    }
}
