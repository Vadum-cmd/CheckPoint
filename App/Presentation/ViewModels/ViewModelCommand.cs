namespace Presentation.ViewModels
{
    using System;
    using System.Windows.Input;

    public class ViewModelCommand : ICommand
    {
        // Fields
        private readonly Action<object> _executeAction;
        private readonly Predicate<object>? _canExecuteAction;

        // Constructors
        public ViewModelCommand(Action<object> executeAction)
        {
            this._executeAction = executeAction;
            this._canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            this._executeAction = executeAction;
            this._canExecuteAction = canExecuteAction;
        }

        // Events

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Methods

        /// <inheritdoc/>
        public bool CanExecute(object parameter)
        {
            return this._canExecuteAction == null || this._canExecuteAction(parameter);
        }

        /// <inheritdoc/>
        public void Execute(object parameter)
        {
            this._executeAction(parameter);
        }
    }
}