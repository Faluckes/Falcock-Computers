using FalcockComputers.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public class Diretor : AuthFuncionarios
    {
        public Diretor(string cpf) : base(10000, cpf) { }
        public override void IncreaseSalary()
        {
            Salary *= 1.20;
        }
        public override double GetBonificacao()
        {
            return Salary * 0.5;
        }
    }
}
