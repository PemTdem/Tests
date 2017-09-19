using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlineShop.Admin.Commands
{
    public class Command : ICommand
    {
        readonly Action<object> _executeMetod;
        readonly Predicate<object> _canExecuteMetod;
        private object executeSort;
        private object canExecuteSort;

        public Command(Action<object> executeMetod, Predicate<object> canExecuteMetod)
        {
            if (executeMetod == null)
                throw new NullReferenceException("execute");

            _executeMetod = executeMetod;
            _canExecuteMetod = canExecuteMetod;
        }

        public Command(Action<object> executeMetod) : this(executeMetod, null)
        {

        }

        public Command(object executeSort, object canExecuteSort)
        {
            this.executeSort = executeSort;
            this.canExecuteSort = canExecuteSort;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteMetod == null ? true : _canExecuteMetod(parameter);
        }

        public void Execute(object parameter)
        {
            _executeMetod.Invoke(parameter);
        }
    }
}
