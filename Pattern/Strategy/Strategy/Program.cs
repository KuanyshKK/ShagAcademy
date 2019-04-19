using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder("Джон", "2 раздряд", new PaintWalls());
            builder.Build();
            builder.BuildHome = new RepairFloor();
            builder.Build();

            Console.ReadLine();


        }
    }

    interface IBuild
    {
        void Build();
    }

    class PaintWalls : IBuild
    {
        public void Build()
        {
            Console.WriteLine("Красит стены");
        }
    }

    class RepairFloor : IBuild
    {
        public void Build()
        {
            Console.WriteLine("Укладывает ламинат");
        }
    }

    class Builder
    {
        protected string Name;

        protected string Qualification;

        public Builder(string FirstName, string Quality, IBuild buildSomething)
        {
            this.Name = FirstName;
            this.Qualification = Quality;
            BuildHome = buildSomething;
        }

        public IBuild BuildHome { private get; set; }

        public void Build()
        {
            BuildHome.Build();
        }

    }
}
