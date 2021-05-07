namespace YouTubePractice
{
    using YoutubeExplode;
    using System.Threading.Tasks;
    using System.Linq;
    using YoutubeExplode.Videos.Streams;

    /// <summary>
    /// receiver
    /// </summary>
    public class YouTubeOperations
    {
        private YoutubeClient youtube;
        private YoutubeExplode.Videos.Video video;
        private YoutubeExplode.Videos.Streams.StreamManifest manifest;
        private YoutubeExplode.Videos.Streams.VideoOnlyStreamInfo streamInfo;

        public YouTubeOperations()
        {
            youtube = new YoutubeClient();
        }

        public async Task GetStreamInfoAsync(string videoUrl)
        {
            await GetVideoAsync(videoUrl);
            await GetManifestAsync();
            streamInfo = (VideoOnlyStreamInfo)manifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == YoutubeExplode.Videos.Streams.Container.Mp4)
                .GetWithHighestVideoQuality();
        }

        public async Task GetVideoAsync(string videoUrl)
        {
            video = await youtube.Videos.GetAsync(videoUrl);
        }

        public async Task GetManifestAsync()
        {
            manifest = await youtube.Videos.Streams.GetManifestAsync("u_yIGGhubZs");
        }

        public async Task DownloadVideoAsync()
        {
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }

        public async Task PrintVideoInfo()
        {
            var title = video.Title;
            var author = video.Author;
            var duration = video.Duration;

            System.Console.WriteLine($"Our video has a name {title} made by {author} with duration {duration}");
        }
    }
}
