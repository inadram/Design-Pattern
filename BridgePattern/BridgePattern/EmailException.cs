namespace BridgePattern
{
    public class EmailException:ISendAs
    {
        public string Status = string.Empty;

       public string Send(string toAddress, string message, string source, EmailException emailException)
        {
            //TODO :send it as email
           return Status = "send successfully as email";
        }
    }

    public class SmsException : ISendAs
    {
        public string Status = string.Empty;
        public string Send(string toAddress, string message, string source, EmailException emailException)
        {
            //TODO :send it as sms
           return Status = "send successfully as sms";
        }
    }

    public class LogException : ISendAs
    {
        public string Status = string.Empty;
        public string Send(string toAddress, string message, string source, EmailException emailException)
        {
            //TODO :send it as log
           return Status = "send successfully as log";
        }
    }
}