using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentaageOperation
{
    class PercentaageOperation
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int ans = 0;
            Console.Write("Enter value of x: ", x);
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ", y);
            y = Convert.ToInt32(Console.ReadLine());
            ans = x % y;
            Console.WriteLine("The Answer is: " + ans.ToString());
            Console.ReadLine();
        }
    }
}
