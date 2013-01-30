using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace VisitorPattern
{
    public class Payment
    {
        public int CalculateTheBill()
        {
            Printer printer=new Printer();
            printer.PrinterList.Add(new Hp {Name = "HP100",Price = 100,Year = 1999});
            printer.PrinterList.Add(new Hp { Name = "HP200", Price = 200, Year = 2010 });
            printer.PrinterList.Add(new Sony { Name = "SonyPX1", Price = 220, Year = 2010, Discount = 70 });
            printer.PrinterList.Add(new Toshiba { Name = "Toshiba600", Price = 800, Colorful = true });
           
            Billing billing=new Billing();
            printer.Accept(billing);
            return billing.totalPrice;
        }
       
    }

    [TestFixture]
    public class TestPayment
    {
        [Test]
        public void CalculateTheBill()
        {
            Payment payment=new Payment();
            int calculateTheBill = payment.CalculateTheBill();
            Assert.Pass(calculateTheBill.ToString());
        }
    }
}
