using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true, false);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            PaymentHandler qiwiPaymentHandler = new QiwiPaymentHandler();

            qiwiPaymentHandler.Successor = bankPaymentHandler;
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;

            qiwiPaymentHandler.Handle(receiver);

            Console.Read();
        }
    }

    class Receiver
    {
        // банковские переводы
        public bool BankTransfer { get; set; }
        // денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; set; }
        // перевод через PayPal
        public bool PayPalTransfer { get; set; }

        public bool QiwiTransfer { get; set; }
        public Receiver(bool bt, bool mt, bool ppt, bool qwt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
            QiwiTransfer = qwt;
        }
    }
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }

    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
            {
                Console.WriteLine("Выполняем банковский перевод");
                Successor.Handle(receiver);
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }

    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через PayPal");
                Successor.Handle(receiver);
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
    // переводы с помощью системы денежных переводов
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
                
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }

    class QiwiPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.QiwiTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через системы qiwi переводов");
                Successor.Handle(receiver);
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
