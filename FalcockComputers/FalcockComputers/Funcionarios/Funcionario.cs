using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    public abstract class Funcionario
    {
        // Aqui estarei setando métodos dentro da classe para adicionar funções.
        // Em Abstract, pq essa classe é uma base para outras, por exemplo, o Developer, Diretor...
        public static int TotalDeFuncionarios { get; private set; }
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; }
        public string Password { get; set; }
        public Funcionario(double salary, string cpf)
        {
            Console.WriteLine("Criando Funcionario ");
            CPF = cpf;
            Salary = salary;
            TotalDeFuncionarios++;
        }
        // Coloqueei Abstract nos métodos, pq preciso que seja obrigatorio adicionar as funções de aumentar o salario e obter Bonificação. -> va para Auxiliar.
        public abstract void IncreaseSalary();

        public abstract double GetBonificacao();

    }
}
