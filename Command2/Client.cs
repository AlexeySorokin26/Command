namespace Command2
{
    using System;

    class Client
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.Run();
            invoker.Cancel();
        }
    }
}
