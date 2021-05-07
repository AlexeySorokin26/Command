namespace YouTubePractice
{
    using System.Threading.Tasks;

    class Client
    {
        static async Task Main(string[] args)
        {
            string url = "https://youtube.com/watch?v=u_yIGGhubZs";

            Invoker invoker = new Invoker();
            YouTubeOperations youTubeOperations = new YouTubeOperations();
            await youTubeOperations.GetStreamInfoAsync(url);

            invoker.SetCommand(new YouTubeDownloadCommand(youTubeOperations));
            await invoker.Download();

            await invoker.PrintInfo();
        }
    }
}
