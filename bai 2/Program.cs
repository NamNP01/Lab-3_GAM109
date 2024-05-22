using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void data()
    {
        string username="nam";
        string password="123";
        string time="12";
        using(StringWriter sw=new StringWriter())
        {
            sw.WriteLine("username: " + username);
            sw.WriteLine("pass word: " + password);
            sw.WriteLine("time: " + time);

            string content= sw.ToString();

            StringReader sr = new StringReader(content);
            string line=sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
        }
    }
    static void Main(string[] args)
    {
        data();
    }
}
