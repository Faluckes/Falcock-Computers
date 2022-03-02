using FalcockComputers.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public class Coordenator : Authenticable
    {
        public override void IncreaseSalary()
        {
            Salary *= 1.20;
        }
        public Coordenator(string cpf) : base(3000 , cpf) { }
        public override double GetBonificacao()
        {
            return Salary * 0.5;  
        }
    }
}
