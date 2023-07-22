using System;
using HomeMenu;

namespace EditorHtml{
    class Program{
        public static void Main(string[] args){
            Home initialPage = new Home("v0.0.1", 30, 40);
            initialPage.Start();
        }
    }
}