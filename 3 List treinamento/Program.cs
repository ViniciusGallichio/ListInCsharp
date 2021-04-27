using System;
using System.Globalization;
using System.Collections.Generic;

namespace _3_List_treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados você quer registrar? ");
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());

            List<Dados> list = new List<Dados>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("EMPREGADO#" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Dados(name, id, salary));
                Console.WriteLine();
            }

            Console.Write("Entre com o Id do funcionario que você aumentar o salario: ");
            int searchId = int.Parse(Console.ReadLine());

            Dados empreg = list.Find(x => x.Id == searchId);
            if (empreg != null)
            {
                Console.Write("Coloque a porcentagem: ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empreg.acres(porcentage);
            }
            else
            {
                Console.WriteLine("Esse empregado não existe: ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada");
            foreach (Dados obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
