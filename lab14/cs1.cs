using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class cs1
    {
        public static void task_1()
        {
            string path = "C:\\Users\\gdima\\source\\repos\\lab14\\lab14\\test.txt";
            int a;
            do
            {
                Console.Write("Enter what you want to do:1 - show text in file, 2 - write in file, 3 - load from file, 4 - clear file 0 - Exit: ");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        if (File.Exists(path))
                        {
                            try
                            {

                                string rez = File.ReadAllText(path); // зчитати весь текст з файлу
                                Console.WriteLine("Rezult: " + rez);
                            }
                            catch (IOException)
                            {
                                // Файл зайнятий іншим процесом, спробуйте ще раз через деякий час
                                // або виконайте необхідні дії для звільнення файлу від іншого процесу.
                            }
                            catch (Exception ex)
                            {
                                // Обробка інших винятків
                                Console.WriteLine("Виникла помилка: " + ex.Message);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;

                    case 2:
                        using (var fs = new FileStream(path, FileMode.Append))
                        {
                            using (var sw = new StreamWriter(fs))
                            {
                                Console.WriteLine("Enter 10 string or numbers:");
                                StringBuilder input;
                                for (int i = 0; i < 10; i++)
                                {
                                    input = new StringBuilder(Console.ReadLine());
                                    sw.WriteLine(input);
                                }
                            }
                        }
                        break;

                    case 3:
                        if (File.Exists(path))
                        {
                            StringBuilder sb = new StringBuilder();
                            using (StreamReader sr = new StreamReader(path))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sb.AppendLine(line);
                                }
                            }

                            Console.WriteLine("Strings loaded from file:");
                            Console.WriteLine(sb.ToString());
                        }
                        else
                        {
                            Console.WriteLine("File not found.");
                        }
                        break;
                    case 4:
                        File.WriteAllText(path, string.Empty);
                        break;
                }
            } while (a != 0);
        }


    }
    
}
