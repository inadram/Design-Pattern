namespace BridgePattern
{
    public abstract class Sender
    {
        protected readonly ISendAs SendAs;

        protected Sender(ISendAs sendAs)
        {
            SendAs = sendAs;
        }

        
        public abstract  string Send();
    }

    public interface ISendAs
    {
        string Send(string toAddress, string message, string source, EmailException emailException);
    }
}