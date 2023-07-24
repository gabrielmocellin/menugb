using System;
using HomeMenu;

namespace EditorHtml{
    class Program{
        public static void Main(string[] args){
            Home initialPage = new Home("v0.1.1");
            initialPage.Start();
        }
    }
}
