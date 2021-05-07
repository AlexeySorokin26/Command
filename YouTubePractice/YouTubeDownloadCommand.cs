namespace YouTubePractice
{
    using System.Threading.Tasks;

    public class YouTubeDownloadCommand : IYouTubeCommand
    {
        private YouTubeOperations youtubeoperations;

        public YouTubeDownloadCommand(YouTubeOperations yo)
        {
            youtubeoperations = yo;
        }

        public async Task DownloadVideo()
        {
            System.Console.WriteLine("start downloading video");
            await youtubeoperations.DownloadVideoAsync();
        }

        public async Task PrintVideoInfo()
        {
            await youtubeoperations.PrintVideoInfo();
        }
    }
}
