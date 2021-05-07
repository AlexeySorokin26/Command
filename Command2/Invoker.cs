namespace Command2
{
    public class Invoker
    {
        Command command;

        public void SetCommand(Command c)
        {
            command = c;
        }

        public void Run()
        {
            if (command != null)
                command.Exectute();
        }

        public void Cancel()
        {
            if (command != null)
                command.Undo();
        }

    }
}
