using System;

namespace Command3
{
    class Client
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();

            TV tv = new TV();
            Microwave microwave = new Microwave();

            pult.SetCommand(new TvOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            const int time = 3;
            pult.SetCommand(new MicrowaveCommand(microwave, time));
            pult.PressButton();
            pult.PressUndo();

        }
    }
}
