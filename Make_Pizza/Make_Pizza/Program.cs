using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Pizza
{
    //мука
    class Flour
    {
        // какого сорта мука
        public string Sort { get; set; }
    }
    // соль
    class Salt
    {
        public int Amount { get; set; }
    }

    class Sauce
    {
        public string Type { get; set; }
    }
    // пищевые добавки
    class Additives
    {
        public string Name { get; set; }
    }

    class Vegetables
    {
        public string Tomatoe { get; set; }
        public string Onion { get; set; }
    }

    class Cheese
    {
        public string Cheese_Name { get; set; }
    }

    class Pizza
    {
        public Flour Flour { get; set; }

        public Salt Salt { get; set; }

        public Additives Additives { get; set; }

        public Vegetables Vegetables { get; set; }

        public Cheese Cheese { get; set; }

        public Sauce Sauce { get; set; }        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");
            if (Salt != null)
                sb.Append(Salt.Amount + " gr\n");
            if (Additives != null)
                sb.Append(Additives.Name + "\n");
            if (Vegetables != null)
                sb.Append(Vegetables.Tomatoe + " " + Vegetables.Onion + "\n");
            if (Cheese != null)
                sb.Append(Cheese.Cheese_Name + "\n");
            if (Sauce != null)
                sb.Append(Sauce.Type + "\n");
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // содаем объект пекаря
            PizzaMaker pizzaMaker = new PizzaMaker();
            // создаем пекаря для маргариты
            PizzaBuilder pBuilder = new Margarita();
            // выпекаем
            Pizza margarita = pizzaMaker.Make(pBuilder);
            Console.WriteLine(margarita.ToString());
            // cоздаем пекаря для 4 сезона
            pBuilder = new ForSeasons();
            Pizza forSeasons = pizzaMaker.Make(pBuilder);
            Console.WriteLine(forSeasons.ToString());

            Console.Read();
        }
    }
    // абстрактный класс пекаря
    abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }
        public void CreatePizza()
        {
            Pizza = new Pizza();
        }
        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
        public abstract void SetVegetavles();
        public abstract void SetCheese(); 
        public abstract void SetSauce();
    }
    // пекарь
    class PizzaMaker
    {
        public Pizza Make(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.CreatePizza();
            pizzaBuilder.SetFlour();
            pizzaBuilder.SetSalt();
            pizzaBuilder.SetAdditives();
            pizzaBuilder.SetSauce();
            pizzaBuilder.SetVegetavles();
            pizzaBuilder.SetCheese();
            return pizzaBuilder.Pizza;
        }
    }
    // пекарь для пиццы Маргарита
    class Margarita : PizzaBuilder
    {
        public override void SetFlour()
        {
            this.Pizza.Flour = new Flour { Sort = "Мука 1 сорта" };
        }

        public override void SetSalt()
        {
            this.Pizza.Salt = new Salt { Amount = 5 };
        }

        public override void SetVegetavles()
        {
            this.Pizza.Vegetables = new Vegetables { Tomatoe = "Красный большой помидор" , Onion = ""};
        }

        public override void SetCheese()
        {
            this.Pizza.Cheese = new Cheese { Cheese_Name = "Твердый" };
        }

        public override void SetSauce()
        {
            
        }

        public override void SetAdditives()
        {
            // не используется
        }
    }
    // пекарь для пиццы 4 сезона
    class ForSeasons : PizzaBuilder
    {
        public override void SetFlour()
        {
            this.Pizza.Flour = new Flour { Sort = "Мука 2 сорта" };
        }

        public override void SetSalt()
        {
            this.Pizza.Salt = new Salt { Amount = 10 };
        }

        public override void SetAdditives()
        {
            this.Pizza.Additives = new Additives { Name = "Разрыхлитель теста" };
        }

        public override void SetVegetavles()
        {
            this.Pizza.Vegetables = new Vegetables { Tomatoe = "Средний помидор", Onion = "Репчатый" };
        }

        public override void SetCheese()
        {
            this.Pizza.Cheese = new Cheese { Cheese_Name = "Маскарпоне" };
        }

        public override void SetSauce()
        {
            this.Pizza.Sauce = new Sauce { Type = "Ананасоывый" };
        }

    }
}
