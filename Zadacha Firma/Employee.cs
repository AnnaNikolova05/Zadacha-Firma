using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Firma
{
    internal abstract class Employee
    {
        public string Age { get; set; }
        
        public int BasicSalary { get; set; }
        
        public Employee(string age,  int basicSalary)
        {
            this.Age = age;
            this.BasicSalary = basicSalary;

        }

        //public override string ToString()
        //{
        //    return $"Number:{Number}, Name:{Name}, Age:{Age},BasicSalary:{BasicSalary}";
        //}

        public virtual string Print()
        {
            return $"{this.Age}  {this.BasicSalary}";
        }
    }
}
