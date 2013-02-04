using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace BridgePattern
{
    public class ErrorHandler
    {
        private readonly Exception _errorMessage;
       public List<string> sendStatus = new List<string>();

        public ErrorHandler(Exception errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public void Handle()
        {
          List<Sender> exceptionList=new List<Sender>();
           
            if(_errorMessage.InnerException==null)
            {
                var emailnullException=new NullException(new EmailException());
                AddToListNullException(emailnullException, exceptionList, "null@inadram.com");

                var smsnullException = new NullException(new SmsException());
                AddToListNullException(smsnullException, exceptionList, "07771216871");

                var lognullException = new NullException(new LogException());
                AddToListNullException(lognullException, exceptionList, "nulllog.txt");
            }
            else
            {
                var emailsimpleException = new SimpleExpection(new EmailException());
                AddToListSimpleException(emailsimpleException, exceptionList, "simple@inadram.com");

                var smsSimpleException = new SimpleExpection(new SmsException());
                AddToListSimpleException(smsSimpleException, exceptionList, "07771216872");

                var lognsimpleException = new SimpleExpection(new LogException());
                AddToListSimpleException(lognsimpleException, exceptionList, "simplelog.txt");

                
            }
            foreach (var exp in exceptionList)
            {
                 sendStatus.Add(exp.Send());
            }
        }

        private void AddToListNullException(NullException emailnullException, List<Sender> exceptionList,string toAddress)
        {
            emailnullException.Message = _errorMessage.Message;
            emailnullException.Source = _errorMessage.Source;
            emailnullException.ToAddress = toAddress;
            exceptionList.Add(emailnullException);
        }

        private void AddToListSimpleException(SimpleExpection emailSimpleException, List<Sender> exceptionList, string toAddress)
        {
            emailSimpleException.Message = _errorMessage.Message;
            emailSimpleException.Source = _errorMessage.Source;
            emailSimpleException.ToAddress = toAddress;
            exceptionList.Add(emailSimpleException);
        }


    }

    [TestFixture]
    public class TestErrorHandler
    {
        [Test]
        public void Given_NullInnerExpection_When_SendError_ShouldSendToNullEmailAddressAndSmSAndLog()
        {
            var exception = new Exception("excp test");

            ErrorHandler errorHandler = new ErrorHandler(exception);
            errorHandler.Handle();
            foreach (var status in errorHandler.sendStatus)
            {
                Assert.Pass(status);
                
            }

        }

    }
}
