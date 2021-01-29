﻿using System;
using System.Text;
using System.Globalization;

namespace Aula202InterfaceIComparable.Entitities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }

        public int CompareTo(object other)
        {
            if (!(other is Employee))
            {
                throw new ArgumentException("Wrong object type");
            }
            Employee newOther = other as Employee;
            return Name.CompareTo(newOther.Name);
        }

        public override string ToString()
        {
            return Name + ", $ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
