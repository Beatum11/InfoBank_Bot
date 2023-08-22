using InfoBank_Bot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dadata;
using Dadata.Model;
using Telegram.Bot.Types;
using Telegram.Bot;
using Microsoft.Extensions.Configuration;

namespace InfoBank_Bot.Commands
{
    internal class GetInfo
    {
        private UserAssist UserAssist = new();
        private readonly string DadataToken;

        public GetInfo(IConfiguration configuration)
        { 
            DadataToken = configuration["DadataToken"];
        }

        internal async Task BankInformation(ITelegramBotClient botClient, Message message, CancellationToken token)
        {
                var api = new SuggestClientAsync(DadataToken);
                var response = await api.SuggestBank(message.Text);
            try
            {
                var bank1 = response.suggestions[0].data;

                string bankMessage = $"<b>Название</b>: {bank1.name.payment}\n\n" +
                                     $"<b>БИК:</b> {bank1.bic}\n\n" +
                                     $"<b>ИНН:</b> {bank1.inn}\n\n" +
                                     $"<b>КПП:</b> {bank1.kpp}\n\n" +
                                     $"<b>Корреспондентский счет:</b> {bank1.correspondent_account}\n\n" +
                                     $"<b>SWIFT:</b> {bank1.swift}\n\n" +
                                     $"<b>Город:</b> {bank1.address.data.city}\n\n" +
                                     $"<b>Адрес:</b> {bank1.address.value}\n\n";


                await UserAssist.SendMessage(botClient, message, bankMessage, token);
                return;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                string errorMessage = "Банк не найден";
                await UserAssist.SendMessage(botClient, message, errorMessage, token);
            }
        }

    }
}
