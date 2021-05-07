namespace Command2
{
    public class ConcreteCommand : Command
    {
        private Receiver receiver;

        public ConcreteCommand (Receiver r)
        {
            receiver = r;
        }

        public override void Exectute()
        {
            receiver.StartOperation();
        }

        public override void Undo()
        {
            receiver.StopOperation();
        }
    }
}
