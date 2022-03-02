using FalcockComputers.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalcockComputers
{
    public class ManagerBonificacao
    {
        private double _totalBonificacao;

        public void Register(Funcionario funcionario)
        {
        _totalBonificacao += funcionario.GetBonificacao();
        }
         public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
