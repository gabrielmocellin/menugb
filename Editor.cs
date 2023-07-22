using System;
using System.Text;
using EditorHtml;

namespace EditorMenu{
    public class Editor{
        public void Start(){
            Console.Clear();
            ConfigMenu.CriarMenu menu = new ConfigMenu.CriarMenu(40, 55, "EditorGb v0.0.1", ConsoleColor.Green, ConsoleColor.DarkGray);
            menu.Show();
            WriteText(menu.height, menu.width);
        }

        public string SaveText(){
            
            string textoCompleto = ""; string textoEscrito = "";

                while(textoEscrito != "0"){
                    textoEscrito = Console.ReadLine()!;
                    textoCompleto += " " + textoEscrito;
                };
                return textoCompleto;
    
        }

            public void WriteText(int alt, int larg){
                Console.SetCursorPosition(2, 2);
                Console.Write("Escreva o texto : ");
                Console.SetCursorPosition(2, 3);
            }
    }
}