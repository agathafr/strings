using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBank.Models.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        protected internal override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
