using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visitor(Hp hp);
        void Visitor(Sony sony);
        void Visitor(Toshiba toshiba);
    }

    public interface IMachine
    {
        void Accept(IVisitor visitor);
    }

    public class Billing : IVisitor
    {
        public int totalPrice = 0;
        public void Visitor(Hp hp)
        {
            totalPrice += hp.Price;
        }

        public void Visitor(Sony sony)
        {
            totalPrice += (sony.Price-sony.Discount);
        }

        public void Visitor(Toshiba toshiba)
        {
            totalPrice += (toshiba.Price);
        }
    }

    public class Printer:IMachine
    {
        public List<IMachine> PrinterList = new List<IMachine>();


        public void Accept(IVisitor visitor)
        {
            foreach (var machine in PrinterList)
            {
                machine.Accept(visitor);
            }
        }
    }

    public class Hp:IMachine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Price     { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }

    public class Sony:IMachine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }

    public class Toshiba:IMachine
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Colorful { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }
}
