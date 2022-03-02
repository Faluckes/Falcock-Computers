using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FalcockComputers.Funcionarios;

namespace FalcockComputers.Sistemas
{
    public abstract class Authenticable : Funcionario
    {
        // Aqui onde fica a classe para definir as classes Autenticaveis.
        // Tive que por o Salarioe o CPF no construtor "Authenticable" pois estamos herdando a classe "Funcionario", la na classe "Funcionario" temos Metodos Abstract.
        public Authenticable(double salary, string cpf)
            : base(salary, cpf)
        {
        }
        // Confirmar se a senha esta correta ou incorreta, estou setando que precisamos de uma senha.
        public string Password { get; set; }
        public bool Auth(string password)
        {
            return Password == password;
        }
    }
}
