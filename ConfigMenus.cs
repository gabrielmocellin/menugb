using System;
using System.Text;

namespace ConfigMenu{
    public class CriarMenu{
        public int height{get;}
        public int width{get;}
        public string title{get;set;}
        private System.ConsoleColor wordColor{get;set;}
        private System.ConsoleColor backgroundColor{get;set;}

        public CriarMenu(int menuHeight, int menuWidth, string menuTitle, System.ConsoleColor menuBackgroundColor, System.ConsoleColor menuWordColor){
            height = menuHeight;
            width = menuWidth;
            title = menuTitle;
            wordColor = menuWordColor;
            backgroundColor = menuBackgroundColor;
        }

        public void Show(){

                ConfigConsole(backgroundColor, wordColor, height, width, title);
                Console.Clear();
                DrawScreen(height, width);

            }

            public void ConfigConsole(System.ConsoleColor backgroundColor, System.ConsoleColor wordColor, int menuHeight, int menuWidth, string menuTitle){
                if(OperatingSystem.IsWindows()){
                    Console.SetWindowSize(menuWidth+5, menuHeight+6);
                }
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = wordColor;
                Console.Title = menuTitle;
            }

            public void DrawScreen(int alt, int larg){
                DrawEdge(larg);
                DrawBody(alt, larg);
                DrawEdge(larg);
            }

            public void DrawEdge(int width){
                Console.Write("+");
                for(int i=0; i<=width; i++){
                    Console.Write("-");
                }
                Console.Write("+\n");
            }

            public void DrawBody(int height, int width){
                for(int j=0; j<=height; j++){
                    Console.Write("|");

                    for(int i=0; i<=width; i++){
                        Console.Write(" ");
                    }

                    Console.Write("|\n");
                }
            }

    }
}