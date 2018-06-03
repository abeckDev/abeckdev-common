using System;
using System.Collections.Generic;
using System.Text;

namespace abeckdev.common.Models.Mail
{
    /// <summary>
    /// Contains the definition of an Email message
    /// </summary>
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAdress>();
            FromAddresses = new List<EmailAdress>();
        }

        public List<EmailAdress> ToAddresses { get; set; }
        public List<EmailAdress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
