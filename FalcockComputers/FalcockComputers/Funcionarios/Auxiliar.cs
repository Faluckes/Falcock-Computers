using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public class Auxiliar : Funcionario
        // Os ":" é para Herdar a classe Funcionarios, assim podendo ultilizar os métodos de la sem ter que escrever novamente em cada classe.
    {
        public Auxiliar(string cpf) : base(2000 , cpf) { }
        // Adicionei override, pq eeu estou pegando um metoddo de outra classe, assim ela nao da um stackoverflow.
        public override void IncreaseSalary()
        {
            Salary *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salary * 0.2;
        }
    }
}
