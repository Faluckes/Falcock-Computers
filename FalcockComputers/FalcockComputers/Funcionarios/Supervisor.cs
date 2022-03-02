using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string cpf) : base(4000, cpf) { }
        public override void IncreaseSalary()
        {
            Salary *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salary * 0.4;
        }


    }
}
