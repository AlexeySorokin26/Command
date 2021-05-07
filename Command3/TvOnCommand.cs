namespace Command3
{
    public class TvOnCommand : ICommand
    {

        private TV tv;

        public TvOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Excecute()
        {
            if (tv != null)
                tv.On();
        }

        public void Undo()
        {
            if (tv != null)
                tv.Off();
        }
    }
}
