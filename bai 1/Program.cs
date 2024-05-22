using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

internal class Program
{
    static void readwrite()
    {
        string path = "data.txt";
        using(FileStream fs =new FileStream(path, FileMode.Create))
        {
            using(StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Username: myUsername");
                sw.WriteLine("password: mypassword");
            }
        }

        using(FileStream fs =new FileStream(path,FileMode.Open))
        {
            using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                while((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        readwrite();
    }
}
