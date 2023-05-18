using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<String> chapter = new List<string>();
            Console.WriteLine("Enter the no of chapter ");
            int totalChapter = int.Parse(Console.ReadLine());
            for(int i = 0; i < totalChapter; i++)
            {
                Console.WriteLine("Enter paragph for " + i + 1);
                chapter.Add(Console.ReadLine());   
            }
            Book b1 = new Book("kazim",10, chapter,3,123);
            Console.Write(b1.getChapter(2));
            Console.WriteLine(b1.getBoolMArk());
            b1.setBookMarkNumber(2);

        }
    }
}
