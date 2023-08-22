using InfoBank_Bot.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace InfoBank_Bot.Utils
{
    //Class for sending information to the user
    internal class UserAssist
    {
        internal async Task SendMessage(ITelegramBotClient botClient, Message message, string textToSend, CancellationToken token)
        {
            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: textToSend,
                parseMode: ParseMode.Html,
                replyMarkup: Buttons.GetButtons(),
                cancellationToken: token);
        }
    }
}
