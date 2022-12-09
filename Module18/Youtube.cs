using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18
{
    public class Youtube
    {
        YoutubeClient youtube = new();
        string path = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley";
        public async Task VideoInfo()
        {
            var video = await youtube.Videos.GetAsync(path);

            var title = video.Title;
            var author = video.Author.ChannelTitle;
            var duration = video.Duration;
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Продолжительность: {0}", duration);
        }
        public async Task DownloadVideo()
        {
            await youtube.Videos.DownloadAsync(path, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео загружено");
        }
    }
}
