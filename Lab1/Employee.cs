using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Salary { get; set; }
        public string GetFullName()
        {
            return String.Join(' ', FirstName, LastName);
        }
        public bool IsActive()
        {
            return (StartDate != null && (EndDate == null || EndDate < DateTime.Now));
        }
        public abstract string Salutation();
    }
}
