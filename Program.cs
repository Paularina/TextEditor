using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que voçê deseja fazer?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }
            
            static void Abrir()
            {
              Console.Clear();
              Console.WriteLine("Onde esta o arquivo?");
              string path = Console.ReadLine();

              using (var file = new StreamReader(path))
              {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
              }

              Console.WriteLine("");
              Console.ReadLine();
            }

            static void Editar()
            {
              Console.Clear();
              Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
              Console.WriteLine("------------------");
              string text = "";

              do 
              {
                 text += Console.ReadLine();
                 text += Environment.NewLine;
              }
              while(Console.ReadKey().Key != ConsoleKey.Escape);

              Console.Write(text);
            }

            static void Salvar(string text)
            {
               Console.Clear();
               Console.WriteLine("Onde deseja salvar o arquivo?");
               var path = Console.ReadLine();

            using (var file = new StreamWrite())
            {
	          file.Write(text);             
            }


            }
    }   
}    