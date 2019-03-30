using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyClothes buyClothes = new BuyClothes();
            BuyBooks buyBooks = new BuyBooks();
            
            buyClothes.Buying();

            Console.WriteLine("\n");

            buyBooks.Buying();

            Console.WriteLine("\n");



        }

        abstract class GoShoping
        {
            public void Buying()
            {
                Find();
                Chose();
                Pay();
                Take();
                Enjoy();
            }

            public abstract void Find();
            public abstract void Chose();

            public virtual void Pay()
            {
                Console.WriteLine("Оплатили");
            }
            public abstract void Take();

            public virtual void Enjoy()
            {
                Console.WriteLine("Наслаждайтесь покупкой!!!");
            }

        }

        class BuyClothes : GoShoping
        {
            public override void Find()
            {
                Console.WriteLine("Нашли магазин");
            }

            public override void Chose()
            {
                Console.WriteLine("Выбрали одежду");
            }

            public override void Take()
            {
                Console.WriteLine("Надеваем одежду");
            }

        }

        class BuyBooks : GoShoping
        {
            public override void Find()
            {
                Console.WriteLine("Нашли книжный магазин");
            }

            public override void Chose()
            {
                Console.WriteLine("Выбрали книгу");
            }

            public override void Take()
            {
                Console.WriteLine("Читаем книгу");
            }

        }
    }
}
