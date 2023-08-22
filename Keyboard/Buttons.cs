using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace InfoBank_Bot.Keyboard
{
    internal class Buttons
    {
        public static IReplyMarkup? GetButtons()
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { "/start", "/getbank"}
            })
            {
                ResizeKeyboard = true
            };

            return replyKeyboardMarkup;
        }
    }
}
