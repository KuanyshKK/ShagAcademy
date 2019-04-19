using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // закончился материк
            Plane plane = new Plane();
            // используем адаптер
            ITransport planeTransport = new PlaneToTransportAdapter(plane);
            // продолжаем лететь на самолете
            driver.Travel(planeTransport);

            Console.Read();
        }
    }
    interface ITransport
    {
        void Drive();
    }
    // класс машины
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    class Plane
    {
        public void Fly()
        {
            Console.WriteLine("Самолет летит по воздуху");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    class PlaneToTransportAdapter : ITransport
    {
        Plane plane;

        public PlaneToTransportAdapter(Plane p)
        {
            plane = p;
        }

        public void Drive()
        {
            plane.Fly();
        }
           
    } 
}
