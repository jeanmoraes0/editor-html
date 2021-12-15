using System;
using System.Text;
using System.IO;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("---------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("---------------------");
            Console.Write(" Deseja salvar o arquivo? (s - SIM/ n - NÂO): ");
            char op = char.Parse(Console.ReadLine());

            if (op.ToString().ToLower() == "s")
            {
                Console.WriteLine("Local do arquivo");
                string path = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(file);
                }
            }
            Menu.Show();
        }
    }
}
