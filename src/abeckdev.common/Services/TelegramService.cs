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
        void Send(TelegramMessage telegramMessage, int TelegramChatId);
    }
    public class TelegramService : ITelegramService
    {
        internal readonly ITelegramConfiguration _telegramConfiguration;
        public TelegramService(ITelegramConfiguration telegramConfiguration)
        {
            _telegramConfiguration = telegramConfiguration;
        }

        public async void Send(TelegramMessage telegramMessage, int TelegramChatId)
        {
            var botClient = new TelegramBotClient(_telegramConfiguration.AccessToken);
            Message message = await botClient.SendTextMessageAsync(new ChatId(TelegramChatId), telegramMessage.Content);
        }

        public async void Send(string MessageContent, int TelegramChatId)
        {
            var botClient = new TelegramBotClient(_telegramConfiguration.AccessToken);
            TelegramMessage telegramMessage = new TelegramMessage();
            telegramMessage.Content = MessageContent;
            Message message = await botClient.SendTextMessageAsync(new ChatId(TelegramChatId), telegramMessage.Content);
        }
    }
}
