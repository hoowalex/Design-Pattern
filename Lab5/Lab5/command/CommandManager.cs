namespace command
{
    public class CommandManager
    {
        private Stack<ICommand> commandStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandStack.Push(command);
        }

        public void Cancel()
        {
            if (commandStack.Count > 0)
            {
                ICommand lastCommand = commandStack.Pop();
                lastCommand.Cancel();
            }
        }
    }
}