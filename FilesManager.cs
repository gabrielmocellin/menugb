using System;
using System.Text;
using EditorHtml;

namespace FileManager{
    public class FilesManager{
        
        // Uma pasta chamada "Output" será criada no diretório atual, dentro desta pasta será criado um arquivo txt.
        public void NewFile(string newFileName, string menuVersion){
            string path = Directory.GetCurrentDirectory();
            string newFolder = "Output";
            string outputPath = path+$"/{newFolder}/";
            string filePath = outputPath+newFileName;

            System.IO.Directory.CreateDirectory(outputPath);

            FileStream createNewFile = File.Create(filePath);
            createNewFile.Close();
            
            // Caso o arquivo tenha sido criado, abrirá o editor de texto.
            if(File.Exists(filePath)){

                EditorMenu.Editor editorMenu = new EditorMenu.Editor(menuVersion);
                editorMenu.Start();
                string text = editorMenu.SaveText();

                using (StreamWriter openedNewFile = new StreamWriter(filePath)){ // Abrindo o arquivo no modo Writer e fechando após os comandos serem executados
                    byte[] bytes = Encoding.Default.GetBytes(text);
                    text = Encoding.UTF8.GetString(bytes);
                    openedNewFile.Write(text);
                }

                using (StreamReader readNewFile = new StreamReader(filePath)){
                    if(readNewFile.ReadToEnd() == ""){
                        Console.WriteLine("Algo deu errado o arquivo está vazio!\n[ENTER] Para continuar");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }
                    Console.WriteLine(@"Arquivo salvo com sucesso! =D");
                    Console.ReadLine();
                }

            } else{ // Caso tenha dado algum erro ao criar o arquivo, o programa finalizará.
                Console.WriteLine("Não foi possível criar o arquivo!");
                Environment.Exit(1);
            }

        }
    }
}