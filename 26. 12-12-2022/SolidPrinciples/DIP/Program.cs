namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            //email.Send();
            SMS sms = new SMS();
            //sms.Send();

            List<IMessageSender> senderList = new List<IMessageSender>();
            senderList.Add(sms);
            senderList.Add(email);
            //senderList.Add(new Facebook());
            senderList.Add(new Whatsapp());

            //MessageSender messageSender = new MessageSender(email, sms,new Facebook());
            MessageSender messageSender = new MessageSender(senderList);

            messageSender.Send();
        }
    }
}