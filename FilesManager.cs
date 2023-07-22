using System;

namespace FileManager{
    static class FilesManager{
        public static void NewFile(string newFileName){
            string path = Directory.GetCurrentDirectory();
            string newFolder = "Output";
            string outputPath = path+$"/{newFolder}/";

            System.IO.Directory.CreateDirectory(outputPath);

            FileStream user_newfile = File.Create(outputPath+newFileName);

            if(File.Exists(outputPath+newFileName)){
                string filePath = outputPath+newFileName;
                string text = FileEditorMenu.Editor.SaveText();
                StreamWriter arquivoCriado = new StreamWriter(outputPath+newFileName);
            }

            EditorHtml.Menu.Show(); // Retornando para o menu principal
        }
    }
}