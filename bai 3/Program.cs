using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    
    internal class Program
    {
        static void createData()
        {
            string dataDirectory = @"..\\..\\..\data\\";
            // Tạo thư mục
            Directory.CreateDirectory(dataDirectory);
            // Kết hợp đường dẫn file và thư mục
            string dataFilePath = Path.Combine(dataDirectory, "data.txt");
            //Ghi nội dung vào file với StreamWriter
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                writer.WriteLine("Nguyễn Phương Nam");
                writer.WriteLine("PD10891");
            }
            Console.WriteLine("Đã ghi xong: "+ dataFilePath);
        }
        static void copyData()
        {
            string sourceDirectory = @"..\\..\\..\data\\";
            string targetDirectory = @"..\\..\\..\data2\\";
            // Kiểm tra xem thư mục nguồn tồn tại không
            if (Directory.Exists(sourceDirectory))
            {
                // Tạo thư mục đích nếu nó chưa tồn tại
                Directory.CreateDirectory (targetDirectory);
                // Lấy danh sách các file trong thư mục nguồn
                string[] files = Directory.GetFiles (sourceDirectory);
                // Sao chép từng file sang thư mục đích
                foreach (string file in files )
                {
                    string fileName = Path.GetFileName (file);
                    string targetFile = Path.Combine(targetDirectory, fileName); 
                    File.Copy(file, targetFile, true);
                }
                Console.WriteLine("Sao chép hoàn tất.");
            }
            else
            {
                Console.WriteLine("Thư mục nguồn không tồn tại.");
            }
        }
        static void Main(string[] args)
        {
            createData();
            copyData();
        }
    }
}
