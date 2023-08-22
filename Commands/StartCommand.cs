using InfoBank_Bot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace InfoBank_Bot.Commands
{
    //Command that will execute after /start
    internal class StartCommand : Command
    {
        internal override string Name => "/start";
        private UserAssist UserAssist = new();

        public async override Task ExecuteAsync(ITelegramBotClient botClient, Message message, CancellationToken token)
        {
            var text =
            $"<b>Привет!</b> Я Бот, который поможет найти информацию об интересующем тебя <i>банке</i>🏦🏦🏦" +
            $"\n\nЧем я могу помочь:";

            await UserAssist.SendMessage(botClient, message, text, token);
        }

    }
}
