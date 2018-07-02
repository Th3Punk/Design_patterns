using System;
using System.Collections.Generic;

namespace Adapter_pattern
{
    public class MessageTestService : IMessageService
    {
        private List<Message> messages = new List<Message>();

        public MessageTestService()
        {
        }

        public void AddMessage(string _to, string _subject, string _text)
        {
            messages.Add(new Message { To = _to, Subject = _subject, Text = _text });
        }

        public void SendMessages()
        {
            foreach (var message in messages)
            {
                Console.WriteLine($@"To = { message.To }, _subject = { message.Subject }, Text = { message.Text }");
            }
        }
    }
}