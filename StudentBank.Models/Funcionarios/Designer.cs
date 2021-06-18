using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBank.Models.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        protected internal override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
