using Module18;
class Program
{
    public static async Task Main()
    {
        Youtube my_youtube = new();

        CommandDowndloadVideo download = new(my_youtube);
        CommandVideoInfo info = new(my_youtube);

        CommandSender my_sender = new();
        my_sender.SetCommand(info);
        await my_sender.Execute();

        my_sender.SetCommand(download);
        await my_sender.Execute();

    }
}