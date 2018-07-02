namespace Adapter_pattern
{
    public interface IMessageService
    {
        void AddMessage(string _to, string _subject, string _text);
        void SendMessages();
    }
}