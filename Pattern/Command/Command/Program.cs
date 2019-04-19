﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            TV tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            EpsonCinema ec = new EpsonCinema();
            pult.SetCommand(new EpsonCimemaOnCommand(ec));
            pult.PressButton();
            pult.PressUndo();

            Console.Read();
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Получатель
    class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }

    class EpsonCinema
    {
        public void On()
        {
            Console.WriteLine("Проектор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Проектора выключен ...");
        }
    }

    class EpsonCimemaOnCommand : ICommand
    {
        EpsonCinema ec;

        public EpsonCimemaOnCommand(EpsonCinema epsonSet)
        {
            ec = epsonSet;
        }

        public void Execute()
        {
            ec.On();
        }

        public void Undo()
        {
            ec.Off();
        }
    }

    class TVOnCommand : ICommand
    {
        TV tv;
        public TVOnCommand(TV tvSet)
        {
            tv = tvSet;
        }
        public void Execute()
        {
            tv.On();
        }
        public void Undo()
        {
            tv.Off();
        }
    }

    // Invoker - инициатор
    class Pult
    {
        ICommand command;

        public Pult() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}