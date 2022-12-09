

namespace Module18
{
    class CommandSender
    {
        ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public async Task Execute()
        {
            await _command.Execute();
        }
    }
}
