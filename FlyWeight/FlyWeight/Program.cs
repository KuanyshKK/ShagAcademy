using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
class Program
    {
        static void Main(string[] args)
        {
            double longitude = 37.61;
            double latitude = 55.74;

            TreeFactory treeFactory = new TreeFactory();
            for (int i = 0; i < 5; i++)
            {
                TreeType bereza = treeFactory.GetTreeType("Bereza");
                if (bereza != null)
                bereza.Grow(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                TreeType elka = treeFactory.GetTreeType("Elka");
                if (elka != null)
                elka.Grow(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            Console.Read();
        }
    }

    abstract class TreeType
    {
        protected  string name; // количество этажей

        protected string color;        
        public abstract void Grow(double longitude, double latitude);
    }

    class Bereza : TreeType
    {
        public Bereza()
        {
            name = "Bereza";

            color = "White";
        }

        public override void Grow(double longitude, double latitude)
        {
            Console.WriteLine("Отрисовано дерево Береза белого цвета; координаты: {0} широты и {1} долготы",
                latitude, longitude);
        }
    }
    class Elka : TreeType
    {
        public Elka()
        {
            name = "Elka";

            color = "Green";
        }

        public override void Grow(double longitude, double latitude)
        {
            Console.WriteLine("Отрисовано дерово Елка зеленого цвета; координаты: {0} широты и {1} долготы",
                latitude, longitude);
        }
    }

    class TreeFactory
    {
        Dictionary<string, TreeType> trees = new Dictionary<string, TreeType>();
        public TreeFactory()
        {
            trees.Add("Bereza", new Bereza());
            trees.Add("Elka", new Elka());
        }

        public TreeType GetTreeType(string key)
        {
            if (trees.ContainsKey(key))
                return trees[key];
            else
                return null;
        }
    }
}
