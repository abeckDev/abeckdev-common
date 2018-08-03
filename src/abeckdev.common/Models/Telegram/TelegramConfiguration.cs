using System;
using System.Collections.Generic;
using System.Text;

namespace abeckdev.common.Models.Telegram
{
    public interface ITelegramConfiguration
    {
        string AccessToken { get; }
    }

    public class TelegramConfiguration : ITelegramConfiguration
    {
        public string AccessToken { get; set; }
    }
}
