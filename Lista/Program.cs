using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entar com quantidade de funcionario? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            Console.Write("Digite o Id do funcionario a ser alterado: ");
            int idFunc = int.Parse(Console.ReadLine());

            Funcionario pequisaId = funcionarios.Find(x => x.Id == idFunc);
            if(pequisaId != null)
            {
                Console.Write("Valor da porcentagem: ");
                double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pequisaId.IncrementarSalario(pct);
            }
            else
            {
                Console.WriteLine("Esse Id e invalido! ");
            }

            foreach(Funcionario obj in funcionarios)
            {
                
                Console.WriteLine(obj.Id +","+ obj.Nome +","+ obj.Salario);
            }
        }
    }
}
