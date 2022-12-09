namespace Module18
{
    class CommandDowndloadVideo : ICommand
    {
        Youtube youtube;
        public CommandDowndloadVideo(Youtube _youtube)
        {
            youtube = _youtube;

        }
        public async Task Execute()
        {
            await youtube.DownloadVideo();
        }
    }
}
