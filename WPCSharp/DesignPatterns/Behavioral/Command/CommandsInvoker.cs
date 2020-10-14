using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class CommandsInvoker
    {
        private ICommand _command;
        private static readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public CommandsInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }

        public static void Undo()
        {
            _commands.Pop()?.Undo();
        }
    }
}
