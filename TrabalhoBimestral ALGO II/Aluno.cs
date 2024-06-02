namespace TrabalhoBimestral_ALGO_II
{
    public class Aluno
    {

        public int Matricula;

        public string Nome;

        public string CPF;

        public string Sexo;

        public Endereco Endereco = new();

        public int Telefone;

        public string Email;

        public void CadastrarAluno()
        {
            Console.Write("Digite sua matrícula: ");
            Matricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            CPF = Console.ReadLine();

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
