namespace BridgePattern
{
    public class SimpleExpection:Sender
    {
        public SimpleExpection(ISendAs sendAs):base(sendAs)
        {
            
        }
        public string Message { get; set; }
        public string Source { get; set; }
        public string ToAddress { get; set; }
        readonly EmailException _emailException=new EmailException();
        public override string Send()
        {
           return SendAs.Send(ToAddress,Message, Source, _emailException);
        }
    }
}