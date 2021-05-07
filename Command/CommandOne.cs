using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override void Cancel()
        {
            
        }

        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }
    }
}
