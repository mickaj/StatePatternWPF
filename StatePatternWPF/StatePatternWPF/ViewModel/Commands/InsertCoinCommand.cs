using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StatePatternWPF.ViewModel.Commands
{
    public class InsertCoinCommand :ICommand
    {
        private VendingMachineViewModel vm;
        public InsertCoinCommand(VendingMachineViewModel _vm)
        {
            vm = _vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.InsertCoin();
        }
    }
}
