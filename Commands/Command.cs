using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using InfoBank_Bot.Utils;

namespace InfoBank_Bot.Commands
{
    internal abstract class Command
    {
        internal abstract string? Name { get; }
        private UserAssist UserAssist = new();

        public abstract Task ExecuteAsync(ITelegramBotClient botClient, Message message, CancellationToken token);
    }
}
