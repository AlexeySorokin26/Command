namespace Command3
{
    /// <summary>
    /// invoker
    /// </summary>
    public class Pult
    {
        private ICommand command;

        public void SetCommand(ICommand c)
        {
            command = c;
        }

        public void PressButton()
        {
            command.Excecute();
        }

        public void PressUndo()
        {
            command.Undo();
        }
    }
}
