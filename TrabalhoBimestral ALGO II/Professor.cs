namespace TrabalhoBimestral_ALGO_II
{
    public class Professor
    {
        public int Chapa;

        public string Titulacao;

        public string Nome;

        public int CPF;

        public string Sexo;

        public Endereco Endereco = new();

        public int Telefone;

        public string Email;

        public void CadastrarProfessor()
        {
            Console.Write("Digite sua chapa: ");
            Chapa = Convert.ToInt32(Console.ReadLine());
           
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Escolha sua titulação: ");
                Console.WriteLine("1-Graduado");
                Console.WriteLine("2-Especialista");
                Console.WriteLine("3-Mestre");
                Console.WriteLine("4-Doutor");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Titulacao = "Graduado";

                        loop = false;
                        break;

                    case 2:
                        Titulacao = "Especialista";

                        loop = false;
                        break;

                    case 3:
                        Titulacao = "Mestre";

                        loop = false;
                        break;

                    case 4:
                        Titulacao = "Doutor";
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");
            CPF = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu sexo: ");
            Sexo = Console.ReadLine();

            Console.Write("Digite sua rua: ");
            Endereco.Rua = Console.ReadLine();

            Console.Write("Digite seu bairro: ");
            Endereco.Bairro = Console.ReadLine();

            Console.Write("Digite seu CEP: ");
            Endereco.CEP = Console.ReadLine();

            Console.Write("Digite o número da sua residência: ");
            Endereco.Numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o complemento da sua residência: ");
            Endereco.Complemento = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            Telefone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu email: ");
            Email = Console.ReadLine();

            Console.WriteLine("");
        }
    }
}
