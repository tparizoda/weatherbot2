using Telegram.Bot;
using Telegram.Bot.Types;

public partial class UpdateHandler
{
    public Task HandleUpdateMessageAsync(ITelegramBotClient botClient,Message message, CancellationToken cancellationToken = default)
    {
        logger.LogInformation(
            "Recieved message from {user.Id}. Text:  {Text}",
             message.Chat.Id,
             message.Text);

        return Task.CompletedTask;
    }
}