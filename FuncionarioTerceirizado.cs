using System;

namespace Empresa
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horasTrabalhadas, double valorHora, double despesaAdicional)
            : base(nome, horasTrabalhadas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double CalcularPagamento()
        {
            return base.CalcularPagamento() + 1.1 * DespesaAdicional;
        }
    }
}
