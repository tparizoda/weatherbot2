using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

public partial class UpdateHandler
{
    public Task HandleEditedMessageAsync(ITelegramBotClient botClient,Message editedmessage, CancellationToken cancellationToken = default)
    {
        logger.LogInformation(
            "Recieved edited message from {user.Id} New Text {new.Text}",
             editedmessage.Chat.Id,
             editedmessage.Text);

        return Task.CompletedTask;
    }

}