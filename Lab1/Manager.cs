using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Manager: Employee
    {
        public override string Salutation()
        {
            return "Hello manager";
        }
    }
}
