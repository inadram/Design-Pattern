using System;
using System.Threading;
using NUnit.Framework;

namespace SingeltonPattern
{
    public class SingeltonObject
    {
        private string _thecreationTime;
        private static SingeltonObject _instance;
        public static SingeltonObject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingeltonObject();
                }
                return _instance;
            }
        }

        private SingeltonObject()
        {
            _thecreationTime = DateTime.Now.ToString();
        }

        public string CreationTime { get { return _thecreationTime; } }
    }

    public class Account
    {
        public string creationTime;
        public void GetCreationTime()
        {
            creationTime = SingeltonObject.Instance.CreationTime;
        }
    }
  

    [TestFixture]
    public class TestSingelton
    {
        [Test]
        public void CallSingeltonObject_ShouldReturnOneInstance()
        {
            var account = new Account();
            account.GetCreationTime();
            string creationTime = account.creationTime;
            Thread.Sleep(1000);
            
            account.GetCreationTime();
            string creationTime2 = account.creationTime;
            Assert.That(creationTime, Is.EqualTo(creationTime2));
        }

        [Test]
        public void CallMultiThreadSingeltonObject_ShouldReturnOneInstance()
        {
            
            var account = new Account();
            Thread tid1 = new Thread(new ThreadStart(account.GetCreationTime) );

           
            var account2 = new Account();
            Thread tid2 = new Thread(new ThreadStart(account2.GetCreationTime));
            

           tid1.Start();
           tid2.Start();
           


            Assert.That(account.creationTime, Is.EqualTo(account2.creationTime));
        }

    }
}
