using System;
using System.Text;
using EditorHtml;

namespace FileManager{
    public class FilesManager{
        
        // Uma pasta chamada "Output" será criada no diretório atual, dentor da pasta será criado um arquivo txt.
        public void NewFile(string newFileName){
            string path = Directory.GetCurrentDirectory();
            string newFolder = "Output";
            string outputPath = path+$"/{newFolder}/";
            string filePath = outputPath+newFileName;

            System.IO.Directory.CreateDirectory(outputPath);

            FileStream createNewFile = File.Create(filePath);
            createNewFile.Close();
            
            // Caso o arquivo tenha sido criado, abrirá o editor de texto.
            if(File.Exists(filePath)){

                EditorMenu.Editor editorMenu = new EditorMenu.Editor();
                editorMenu.Start();
                string text = editorMenu.SaveText();

                Console.WriteLine($"Texto escrito: '{text}'");

                using (StreamWriter openedNewFile = new StreamWriter(filePath)){
                    byte[] bytes = Encoding.Default.GetBytes(text);
                    text = Encoding.UTF8.GetString(bytes);
                    openedNewFile.Write(text);
                }

                /*using (StreamReader readNewFile = new StreamReader(filePath)){
                    if(readNewFile.ReadToEnd() == ""){
                        Console.WriteLine("Algo deu errado o arquivo está vazio!");
                        Environment.Exit(1);
                    }
                    Console.WriteLine(@"Arquivo salvo com sucesso! =D");
                }*/

            } else{ // Caso tenha dado algum erro ao criar o arquivo, o programa finalizará.
                Console.WriteLine("Algo deu errado ao criar o arquivo!");
                Environment.Exit(1);
            }

        }
    }
}