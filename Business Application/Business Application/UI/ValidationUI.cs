using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class ValidationUI
    {
     public static bool IsValidOption(string value)
      {
        foreach (char c in value)
        {
            if (!Char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
      }

    public static int EnterOption(int limit)
    {
        string opt = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(opt)||!IsValidOption(opt) || Convert.ToInt32(opt) < 0 || Convert.ToInt32(opt) > limit)
        {
            Console.WriteLine("Invalid input");
            Console.WriteLine("Enter your option again: ");
            opt = Console.ReadLine();
        }
        return Convert.ToInt32(opt);
    }

}
}
