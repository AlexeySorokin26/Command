namespace Command2
{
    using System;

    public class Receiver
    {
        public void StartOperation()
        {
            Console.WriteLine("do some operation");
        }

        public void StopOperation()
        {
            Console.WriteLine("undo some operation");
        }
    }
}
