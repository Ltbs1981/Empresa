using System;
using System.Collections.Generic;
using Empresa;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        Console.WriteLine("Digite o número de funcionários:");
        int quantFuncionarios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantFuncionarios; i++)
        {
            Console.WriteLine($"\n{i + 1}ª Funcionário:");
            Console.WriteLine("Se for terceirizado, digite 3. Se for da própria empresa, digite 1.");
            int tipoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());

            if (tipoFuncionario == 3)
            {
                Console.Write("Despesa adicional: ");
                double despesaAdicional = double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new FuncionarioTerceirizado(nome, horasTrabalhadas, valorPorHora, despesaAdicional));
            }
            else
            {
                listaFuncionarios.Add(new Funcionario(nome, horasTrabalhadas, valorPorHora));
            }
        }

        Console.Clear();
        
        Console.WriteLine("\nPagamentos:");
        for (int i = 0; i < listaFuncionarios.Count; i++)
        {
            Funcionario func = listaFuncionarios[i];
            Console.WriteLine($"{func.Nome}: R$ {func.CalcularPagamento():F2}");
        }
    }
}
