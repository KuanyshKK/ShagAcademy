using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {        

            Application winApp = new Application(new WinFactory());
            winApp.Push();
            winApp.Check();

            Application macApp = new Application(new MacFactory());
            macApp.Push();
            macApp.Check();

            Console.ReadLine();
        }
    }

    abstract class Button
    {
        public abstract void Push();
    }

    abstract class CheckBox
    {
        public abstract void Check();
    }

    class WinButton : Button
    {
        public override void Push()
        {
            Console.WriteLine("Button for Windows");
        }
    }

    class MacButton : Button
    {
        public override void Push()
        {
            Console.WriteLine("Button for MacOS");
        }
    }

    class WinCheckBox : CheckBox
    {
        public override void Check()
        {
            Console.WriteLine("CheckBox for Windows");
        }
    }

    class MacCheckBox : CheckBox
    {
        public override void Check()
        {
            Console.WriteLine("CheckBox for MacOS");
        }
    }

    abstract class GUIFactory
    {
        public abstract Button CreateButton();
        public abstract CheckBox CreateCheckBox();
    }

    class WinFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new WinButton();
        }

        public override CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }

    class MacFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }

        public override CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }

    class Application
    {
        private Button btn;
        private CheckBox checkBox;

        public Application(GUIFactory factory)
        {
            btn = factory.CreateButton();
            checkBox = factory.CreateCheckBox();
        }

        public void Push()
        {
            btn.Push();
        }

        public void Check()
        {
            checkBox.Check();
        }
    }
        
}
