using FalcockComputers.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public class Developer : AuthFuncionarios
    {
        public Developer(string cpf) : base(7000, cpf) { }
        public override double GetBonificacao()
        {
            return Salary * 0.1;
        }
        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }
    }
}
