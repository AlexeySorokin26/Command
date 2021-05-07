namespace YouTubePractice
{
    using System.Threading.Tasks;

    public interface IYouTubeCommand
    {
        public Task DownloadVideo();

        public Task PrintVideoInfo();
    }
}
