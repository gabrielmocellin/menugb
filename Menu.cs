using System;
using FileManager;

namespace EditorHtml{
    static class Menu{
        public static void Show(){
            int altura = 30;
            int largura = 40;

            Console.Clear();
            ConfigConsole(ConsoleColor.Blue, ConsoleColor.Black, altura, largura);
            DrawScreen(altura, largura);
            WriteOptions(altura, largura);

            var option = short.Parse(Console.ReadLine()!);
            switch(option){
                case 0:
                    Environment.Exit(1);
                    break;
                case 1:
                    FilesManager.NewFile("gb.txt");
                    break;
                case 2:
                    break;
                default:
                    Show();
                    break;
            }
        }

        public static void ConfigConsole(System.ConsoleColor backgroundColor, System.ConsoleColor wordColor, int height, int width){
            Console.SetWindowSize(width+3, height+4);
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = wordColor;
            Console.Title = "MenuGB v.0.0.1";
        }

        public static void DrawScreen(int alt, int larg){
            DesenharExtremidade(larg);
            DesenharCorpo(alt, larg);
            DesenharExtremidade(larg);
        }

        public static void DesenharExtremidade(int largura){
            Console.Write("+");
            for(int i=0; i<=largura; i++){
                Console.Write("-");
            }
            Console.Write("+\n");
        }

        public static void DesenharCorpo(int altura, int largura){
            for(int j=0; j<=altura; j++){
                Console.Write("|");

                for(int i=0; i<=largura; i++){
                    Console.Write(" ");
                }

                Console.Write("|\n");
            }
        }

        public static void WriteOptions(int alt, int larg){
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
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