using FalcockComputers.Funcionarios;
using FalcockComputers.Sistemas;
using System;


namespace FalcockComputers
{
    class Program
    {
        static void Main(string[] args)
        {

            // CalcBonificacao();

            UseSystem();

            Console.ReadLine();
        }
        public static void UseSystem()
        {
            InternalSystem internalSystem = new InternalSystem();

            Diretor faluckes = new Diretor("136.682.899-21");
            faluckes.Name = "Faluckes";
            faluckes.Password = "fa27102004";

            Developer lolo = new Developer("543.543.543-96");
            lolo.Name = "Lorenzo";
            lolo.Password = "teucu";

            Coordenator yuki = new Coordenator("321.312.312-32");
            yuki.Name = "Yuki";
            yuki.Password = "espetinhodegato";

            Designer gabo = new Designer("699.966.696-69");
            gabo.Name = "Gabo";
            gabo.Password = "superidol";

            // Mesmo estando em CommercialPartner, algumas classes dos cargos, não tem permissão para logar.
            CommercialPartner parceiro = new CommercialPartner();
            parceiro.Password = "jamba";



            // Aqui estou logando alguns funcionarios que dei permissão para acessar o "Sistema".
            // Tire o "gabo" como comentario e leia o erro.
            internalSystem.Logar(yuki, "hentai");
            // internalSystem.Logar(gabo, "superidol");
            internalSystem.Logar(lolo, "teucu");
            internalSystem.Logar(faluckes, "fa27102004");
            internalSystem.Logar(parceiro, "jamba");
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
            lolo.Name = "Lorenzo";

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