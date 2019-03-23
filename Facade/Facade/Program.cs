using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Design dsg = new Design();
            Coller clr = new Coller();
            Deliver dlr = new Deliver();

            ManagerFacade mng = new ManagerFacade(dsg, clr, dlr);

            Client client = new Client();
            client.Buy(mng);

            Console.Read();
        }
    }
    // текстовый редактор
    class Design
    {
        public void CreateDesign()
        {
            Console.WriteLine("Исполнение дизайна");
        }

    }
    class Coller
    {
        public void Paint()
        {
            Console.WriteLine("Покраска мебели");
        }
    }
    class Deliver
    {
        public void Delive()
        {
            Console.WriteLine("Доставка заказа");
        }

    }

    class ManagerFacade
    {
        Design furnitureDesigner;
        Coller colorPainter;
        Deliver orderDeliver;
        public ManagerFacade(Design d, Coller cr, Deliver dv)
        {
            this.furnitureDesigner = d;
            this.colorPainter = cr;
            this.orderDeliver = dv;
        }
        public void CreateOrder()
        {
            furnitureDesigner.CreateDesign();
            colorPainter.Paint();
            orderDeliver.Delive();

        }

    }

    class Client
    {
        public void Buy(ManagerFacade facade)
        {
            facade.CreateOrder();
        }
    }
}

