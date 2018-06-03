using abeckdev.common.Models.Telegram;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace abeckdev.common.Services
{
    public interface ITelegramService
    {
        void Send(TelegramMessage telegramMessage);
    }
    public class TelegramService : ITelegramService
    {
        internal readonly ITelegramConfiguration _telegramConfiguration;
        public TelegramService(ITelegramConfiguration telegramConfiguration)
        {
            _telegramConfiguration = telegramConfiguration;
        }

        public async void Send(TelegramMessage telegramMessage)
        {
            var botClient = new TelegramBotClient(_telegramConfiguration.AccessToken);
            Message message = await botClient.SendTextMessageAsync(new ChatId(_telegramConfiguration.ChatID), telegramMessage.Content);
        }
    }
}
