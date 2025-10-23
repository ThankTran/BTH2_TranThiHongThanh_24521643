using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string path;

        while (true)
        {
            Console.Write("Nhập đường dẫn thư mục: ");
            path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                break;
            }
            else
            {
                Console.WriteLine("Không tồn tại. Nhập lại!\n");
            }
        }

        Console.WriteLine($"\nNội dung trong thư mục: {path}");

        try
        {
            string[] directories = Directory.GetDirectories(path);
            Console.WriteLine("\nDanh sách thư mục con:");
            if (directories.Length == 0)
                Console.WriteLine("(Không có thư mục con)");
            else
                foreach (string dir in directories)
                {
                    Console.WriteLine($"{Path.GetFileName(dir)}");
                }


            string[] files = Directory.GetFiles(path);
            Console.WriteLine("\nDanh sách tập tin:");
            if (files.Length == 0)
                Console.WriteLine("(Không có tập tin)");
            else
                foreach (string file in files)
                {
                    Console.WriteLine($"{Path.GetFileName(file)}");
                }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Không có quyền truy cập vào thư mục này.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi không xác định: " + ex.Message);
        }
    }
}
