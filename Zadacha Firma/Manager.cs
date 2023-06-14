using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Firma
{
    internal class Manager : Employee,IPrint, IComparable<Employee>
    {
        public int BasicSalary { get; set; }

        public int Age { get; set; }
        public Manager(int age, string name, int basicSalary) : base(name, age)
        {
            basicSalary = basicSalary;
        }
        public override string  Print()
        {
            base.Print();   
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Name: {Name}, Age:{Age}, BasicSalary:{BasicSalary}");
            return sb.ToString();
        }
        public int CompareTo(Employee info )
        {
            return BasicSalary.CompareTo( info.BasicSalary );   
        }

    }
}