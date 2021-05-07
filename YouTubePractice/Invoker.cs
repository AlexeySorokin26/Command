namespace YouTubePractice
{
    using System.Threading.Tasks;

    public class Invoker
    {
        private IYouTubeCommand command;

        public void SetCommand(IYouTubeCommand c)
        {
            command = c;
        }

        public async Task Download()
        {
            await command.DownloadVideo();
        }

        public async Task PrintInfo()
        {
            await command.PrintVideoInfo();
        }
    }
}
