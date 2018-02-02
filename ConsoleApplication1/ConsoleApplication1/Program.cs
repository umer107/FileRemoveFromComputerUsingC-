using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = @"C:\Users\Umar\Pictures\Pic";
            var list = Directory.GetFiles(path);
            var FileCounts = list.Count();
            if (list.Length > 0)
            {

                foreach (var item in list)
                {
                   
                    if (File.Exists(item))
                    {
                        File.Delete(item);
                    }
                    else
                    {
                        Console.WriteLine("File Not Exists");
                    }
                }
            
            }

        }
    }
}
