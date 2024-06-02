namespace TrabalhoBimestral_ALGO_II
{
    public class Disciplina
    {
        public int Codigo;

        public string Nome;

        public Professor Professor;

        public int CargaHoraria;

        public void CadastrarDisciplina()
        {
            Console.Write("Digite o código da disciplina: ");
            Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome da disciplina: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a carga horária da disciplina: ");
            CargaHoraria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
        }
    }
}
