using System;
using System.Text;
using EditorHtml;

namespace EditorMenu{
    public class Editor : ConfigMenu.CriarMenu{

        public Editor(string menuVersion) : base(45, 60, "EditorGb "+menuVersion, ConsoleColor.Green, ConsoleColor.DarkGray){
        }

        public void Start(){
            Console.Clear();
            Show();
            WriteText(height, width);
        }

        public string SaveText(){
            string textoEscrito = "";
            while(true){        
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                int positionLeft = Console.GetCursorPosition().Left;
                int positionTop = Console.GetCursorPosition().Top;
                if(keyPressed.Key == ConsoleKey.Escape){
                    break;
                }
                if(keyPressed.Key == ConsoleKey.Enter){
                    Console.SetCursorPosition(2, positionTop+1);
                    textoEscrito += Environment.NewLine;
                    continue;
                }
                if(positionLeft == 59){ // Caso chegue na borda direita do menu, será passado para a próxima linha.
                    Console.SetCursorPosition(2, positionTop+1);
                }
                if(keyPressed.Key == ConsoleKey.Backspace){
                    textoEscrito = textoEscrito.Remove(textoEscrito.Length-1);
                    if(positionLeft <= 2){ // Corrigir o bug padrão do console passar por cima da borda esquerda.
                        Console.SetCursorPosition(2, positionTop);
                    }
                    continue;
                }
                textoEscrito += keyPressed.KeyChar;
            };
            return textoEscrito;
        }

        public void WriteText(int alt, int larg){
            Console.SetCursorPosition(2, 1);
            Console.Write("[ESC] Para sair do editor");
            Console.SetCursorPosition(2, 2);
            Console.Write("Escreva o texto : ");
            Console.SetCursorPosition(2, 3);
        }
    }
}