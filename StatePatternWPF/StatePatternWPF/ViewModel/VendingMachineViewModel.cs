using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StatePatternWPF.ViewModel
{
    public class VendingMachineViewModel : INotifyPropertyChanged
    {
        private States.VendingMachine machine;

        private string console;
        public string Console
        {
            get { return console; }
            set
            {
                console = value;
                OnPropertyChanged(nameof(Console));
            }
        }

        public int ItemCount
        {
            get { return machine.ItemCount; }
        }

        public VendingMachineViewModel()
        {
            machine = new States.VendingMachine();
            machine.ItemCount = 10;
            Console += machine.ToString();
        }

        public void Refill()
        {
            Console +="\n"+machine.Refill(10);
            OnPropertyChanged(nameof(ItemCount));
        }

        public void InsertCoin()
        {
            Console += "\n" + machine.InsertCoin();
        }

        public void ReturnCoin()
        {
            Console += "\n" + machine.ReturnCoin();
        }

        public void Vend()
        {
            Console += "\n" + machine.Vend();
            OnPropertyChanged(nameof(ItemCount));
        }
        
        private ICommand refillCommand;
        public ICommand RefillCommand
        {
            get
            {
                if(refillCommand == null) { refillCommand = new Commands.RefillCommand(this); }
                return refillCommand;
            }
        }

        private ICommand insertCoinCommand;
        public ICommand InsertCoinCommand
        {
            get
            {
                if (insertCoinCommand == null) { insertCoinCommand = new Commands.InsertCoinCommand(this); }
                return insertCoinCommand;
            }
        }

        private ICommand returnCoinCommand;
        public ICommand ReturnCoinCommand
        {
            get
            {
                if (returnCoinCommand == null) { returnCoinCommand = new Commands.ReturnCoinCommand(this); }
                return returnCoinCommand;
            }
        }

        private ICommand vendCommand;
        public ICommand VendCommand
        {
            get
            {
                if (vendCommand == null) { vendCommand = new Commands.VendCommand(this); }
                return vendCommand;
            }
        }

        #region INotifyProperyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(params string[] propertiesChanged)
        {
            if (PropertyChanged != null)
            {
                foreach (string property in propertiesChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
        #endregion
    }
}
