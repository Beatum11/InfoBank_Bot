using InfoBank_Bot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace InfoBank_Bot.Commands
{
    internal class InfoCommand : Command
    {
        internal override string Name => "/getbank";
        private UserAssist UserAssist = new();

        public async override Task ExecuteAsync(ITelegramBotClient botClient, Message message, CancellationToken token)
        {
            var text =
           $"Введите название банка: ";

            await UserAssist.SendMessage(botClient, message, text, token);
        }
    }
}
