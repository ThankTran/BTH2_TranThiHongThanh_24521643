using System;

using namespace Bai02
{
    static void Main()
    {
        string path;
        while (true)
        {
            Console.Write("Nhập đường dẫn thư mục: ");
            path = Console.ReadLine();

            if (Directory.Exists(path))
                break;
            else
                Console.WriteLine("Đường dẫn không tồn tại. Vui lòng nhập lại!\n");
        }

        Console.WriteLine($"\nNội dung trong thư mục: {path}");
        Console.WriteLine(new string('-', 60));

        try
        {
            string[] directories = Directory.GetDirectories(path);
            Console.WriteLine("\nDanh sách thư mục con:");
            if (directories.Length == 0)
                Console.WriteLine("(Không có thư mục con)");
            else
                foreach (string dir in directories)
                    Console.WriteLine("   [Folder] " + Path.GetFileName(dir));

            string[] files = Directory.GetFiles(path);
            Console.WriteLine("\nDanh sách tập tin:");
            if (files.Length == 0)
                Console.WriteLine("(Không có tập tin)");
            else
                foreach (string file in files)
                    Console.WriteLine("   [File]   " + Path.GetFileName(file));
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Bạn không có quyền truy cập vào thư mục này.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }

        Console.WriteLine("\nHoàn tất liệt kê!");
    }
}