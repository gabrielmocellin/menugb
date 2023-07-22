using System;
using FileManager;
using ConfigMenu;

namespace HomeMenu{  
    class Home{
        private string version{get;set;}
        private int height{get;set;}
        private int width{get;set;}
        public Home(string menuVersion, int menuHeight, int menuWidth){
            version = menuVersion;
            height = menuHeight;
            width = menuWidth;
        }
        public void Start(){

            ConfigMenu.CriarMenu menu = new ConfigMenu.CriarMenu(30, 45, "MenuGB"+version, ConsoleColor.Blue, ConsoleColor.Black);
            menu.Show();
            WriteOptions(30, 40);
            FileManager.FilesManager fileManager = new FilesManager();

            var option = short.Parse(Console.ReadLine()!);

            switch(option){
                case 0:
                    Environment.Exit(1);
                    break;
                case 1:
                    fileManager.NewFile("gb.txt");
                    break;
                case 2:
                    break;
                default:
                    menu.Show();
                    break;
            }
        }

        public void WriteOptions(int alt, int larg){
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Menu Principal");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
    }
}