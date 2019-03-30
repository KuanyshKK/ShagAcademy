using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Add(new Auditor { Name = "John English", PositionRate = 3, HaveCertificate = true });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.Read();
        }
    }

    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
        void VisitAuditorAc(Auditor acc);
    
    }

    // сериализатор в HTML
    class HtmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Company acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
        }

        public void VisitAuditorAc(Auditor acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>PositionRate<td><td>" + acc.PositionRate + "</td></tr>";
            result += "<tr><td>PositionRate<td><td>" + acc.HaveCertificate + "</td></tr></table>";
            Console.WriteLine(result);
        }
    }

    // сериализатор в XML
    class XmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.Name + "</Name>" +
                "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" +
                "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }

        public void VisitAuditorAc(Auditor acc)
        {
            string result = "<Auditor><Name>" + acc.Name + "</Name>" +
                "<PositionRate>" + acc.PositionRate + "</PositionRate" +
                "<HaveCertificate>" + acc.HaveCertificate + "</HaveCertificate>";
            Console.WriteLine(result);
        }
    }

    class Bank
    {
        List<IAccount> accounts = new List<IAccount>();
        public void Add(IAccount acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IAccount acc in accounts)
                acc.Accept(visitor);
        }
    }

    interface IAccount
    {
        void Accept(IVisitor visitor);
    }

    class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }

    class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAc(this);
        }
    }

    class Auditor : IAccount
    {
        public string Name { get; set; }

        public int PositionRate { get; set; }

        public Boolean HaveCertificate { get; set; } 

        public void Accept(IVisitor visitor)
        {
            visitor.VisitAuditorAc(this);
        }
    }
}
