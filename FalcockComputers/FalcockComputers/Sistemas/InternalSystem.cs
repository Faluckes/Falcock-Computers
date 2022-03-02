using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FalcockComputers.Funcionarios;

namespace FalcockComputers.Sistemas
{
    public class InternalSystem
    {
        // Aqui é aonde o Sistema trabalha em autenticar, deixando obrigatorio ter o nome e a senha na hora de logar.
        public bool Logar(Authenticable funcionario, string password)
        {
            // Condições caso esteja Correto ou Incorreto a senha.
            bool authUser = funcionario.Auth(password);

            if(authUser)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;            
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }



    }
}
