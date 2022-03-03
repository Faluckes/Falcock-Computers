using FalcockComputers.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers.Funcionarios
{
    // Essa classe abstrata, recebe os aumentar salarios e Bonificação, temos separado a autenticação dos funcionarios, para deixar mais facil as modificações mais para frente.
    public abstract class AuthFuncionarios : Funcionario, IAuthenticable
    {
        public string Password { get; set; }
        public AuthFuncionarios(double salary, string cpf)
            : base(salary, cpf)
        { }
        public bool Auth(string password)
        {
            return Password == password;
        }
    }
}
