using InfoBank_Bot.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Microsoft.Extensions.Configuration;

namespace InfoBank_Bot.Utils
{
    internal class CommandExecutor
    {

        private Command[]? Commands = new Command[]
        {
            new StartCommand(),
            new InfoCommand()
        };

        private GetInfo getInfo;

        public CommandExecutor(IConfiguration _configuration)
        {
            getInfo = new(_configuration);
        }

        public async Task ExecuteCommand(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
        {
            
            foreach (var command in Commands)
            {
                if(command.Name == message.Text)
                {
                    await command.ExecuteAsync(botClient, message, cancellationToken);
                    return;
                }  
            }

            await getInfo.BankInformation(botClient, message, cancellationToken);
        }
    }
}
