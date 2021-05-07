namespace Command
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду
            var commandOne = new CommandOne(receiver);

            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Run();
        }
    }
}
