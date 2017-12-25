using System;
using System.Windows.Input;

namespace StatePatternWPF.ViewModel.Commands
{
    public class ReturnCoinCommand : ICommand
    {
        private VendingMachineViewModel vm;
        public ReturnCoinCommand(VendingMachineViewModel _vm)
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
            vm.ReturnCoin();
        }
    }
}
