using System;
using System.Collections.Generic;
using MoreEverything.Console.Fun;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            InteractiveMenu menuManager = new InteractiveMenu();

            menuManager.AddMenu(new MenuItem("Show a list of books", () => { System.Console.WriteLine("HAHA"); }, new List<IMenuItem>() { new MenuItem("YEET TEST", null)}));
            menuManager.AddMenu(new MenuItem("YEET2", null));
            menuManager.AddMenu(new MenuItem("YEET3", null));
            menuManager.AddMenu(new MenuItem("YEET4", null));
            menuManager.AddMenu(new MenuItem("YEET5", null));

            while (!menuManager.Exit)
            {
                menuManager.Draw();
                menuManager.ProcessInput();
                menuManager.Update();
            }
        }
    }
}
