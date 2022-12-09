namespace Module18
{
    class CommandVideoInfo : ICommand
    {
        Youtube youtube;
        public CommandVideoInfo(Youtube _youtube)
        {
            youtube = _youtube;

        }
        public async Task Execute()
        {
            await youtube.VideoInfo();
        }
    }
}
