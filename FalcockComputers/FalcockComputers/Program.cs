using FalcockComputers.Funcionarios;
using System;


namespace FalcockComputers
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcBonificacao();

            Console.ReadLine();
        }
        public static void CalcBonificacao()
        {
            ManagerBonificacao manager = new ManagerBonificacao();

            // Aqui eu Adiciono os nomes e cpf dos funcionarios.
            Diretor faluckes = new Diretor("136.682.899-21");
            faluckes.Name = "Faluckes";
            Coordenator yuki = new Coordenator("321.312.312-32");
            yuki.Name = "Yuki";
            Supervisor nyx = new Supervisor("654.654.654-46");
            nyx.Name = "Nyx";
            Designer gabo = new Designer("699.966.696-69");
            gabo.Name = "Gabo";
            Auxiliar carlos = new Auxiliar("321.543.765-69");
            carlos.Name = "Carlos";
            Developer lolo = new Developer("543.543.543-96");

            // Estou Registrando os Funcionarios para receberem o Salario e contar como membros da empresa.
            manager.Register(faluckes);
            manager.Register(yuki);
            manager.Register(nyx);
            manager.Register(gabo);
            manager.Register(carlos);
            manager.Register(lolo);
            // Sabeer o Total de Bonificação que temos na empreesa.
            Console.WriteLine("Total de Bonificação do mês: R$" + manager.GetTotalBonificacao());
        }
    }
}