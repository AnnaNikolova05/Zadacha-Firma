using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Firma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int count = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("");
                var danni = Console.ReadLine().Split(' ');
                Employee e1 = new Manager(int.Parse(danni[0]), danni[1], int.Parse(danni[2]));
                employee.Add(e1);
                
            }
            for (int i = 0; i < count; i++)
            {
                if ()
                {

                }
            }
            
            foreach (var item in employee)
            {
                item.Print();
            }

        }
    }
}
