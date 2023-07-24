using System;
using FileManager;
using ConfigMenu;

namespace HomeMenu{  
    public class Home: ConfigMenu.CriarMenu{
        private string version{get;}
        public Home(string menuVersion) : base(30, 45, "MenuGB "+menuVersion, ConsoleColor.Blue, ConsoleColor.Black){
            this.version = menuVersion;
        }
        public void Start(){
            Show();
            WriteOptions(30, 40);
            FileManager.FilesManager fileManager = new FilesManager();

            var option = short.Parse(Console.ReadLine()!);

            switch(option){
                case 0:
                    Environment.Exit(1);
                    break;
                case 1:
                    fileManager.NewFile("gb.txt", version);
                    break;
                case 2:
                    // Editar arquivo
                    break;
                default:
                    Show();
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
            Console.WriteLine("2 - Editar");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
    }
}