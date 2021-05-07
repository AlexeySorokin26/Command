namespace Command3
{
    public class MicrowaveCommand : ICommand
    {
        private Microwave microwave;
        int time;

        public MicrowaveCommand(Microwave m, int t)
        {
            microwave = m;
            time = t;
        }

        public void Excecute()
        {
            microwave.StartCooking(time);
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
