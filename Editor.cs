using System;
using System.Text;

namespace FileEditorMenu{
    static class Editor{
        public static string SaveText(){
            Show();

            StringBuilder textoCompleto = new StringBuilder();

            string textoEscrito = "";

            while(textoEscrito != "-1"){
                textoEscrito = Console.ReadLine()!;
                textoCompleto.Append(" "+textoEscrito);
            };

            return textoCompleto.ToString();
        }
        public static void Show(){
                int altura = 40;
                int largura = 60;

                Console.Clear();
                ConfigConsole(ConsoleColor.Green, ConsoleColor.White, altura, largura);
                DrawScreen(altura, largura);
                WriteText(altura, largura);
            }

            public static void ConfigConsole(System.ConsoleColor backgroundColor, System.ConsoleColor wordColor, int height, int width){
                Console.SetWindowSize(width+3, height+4);
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = wordColor;
                Console.Title = "EditorGB v.0.0.1";
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

            public static void WriteText(int alt, int larg){
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("=========");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("Editor");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("=========");
                Console.SetCursorPosition(3, 6);
                Console.Write("Escreva o texto : ");
            }
    }
}