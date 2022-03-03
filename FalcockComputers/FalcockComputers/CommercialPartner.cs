using FalcockComputers.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers
{
    // essa repetição de código é apenas uma coincidência da forma que CommercialPartner e AuthFuncionario autenticam, considerando que CommercialPartner não participa da hierarquia de Funcionario e não tem relação com a LanHouse FalcockComputers.
    public class CommercialPartner : IAuthenticable
    {
        public string Password  { get; set; }
        public bool Auth(string password)
        {
            return Password == password;
        }
    }
}
