using System;
using System.Collections.Generic;
using System.Globalization;

namespace _3_List_treinamento
{
    class Dados
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }

        public Dados(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void acres(double porcentage)
        {
            Salary += Salary * porcentage / 100.0;
        }

        public override string ToString()
        {
            return Name + ", " + Id + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
