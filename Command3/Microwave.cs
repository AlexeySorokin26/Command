namespace Command3
{
    using System.Threading.Tasks;

    public class Microwave
    {
        public void StartCooking(int time)
        {
            System.Console.WriteLine("cook our food (it takes some time)");
            Task.Delay(time).GetAwaiter().GetResult();
        }
    
        public void StopCooking()
        {
            System.Console.WriteLine("stop cooking, food is warm now");
        }
    }
}
