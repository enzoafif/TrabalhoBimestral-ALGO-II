using TrabalhoBimestral_ALGO_II;

List<Aluno> listaAlunos = new();
List<Professor> listaProfessores = new();
List<Disciplina> listaDisciplinas = new();
List<DisciplinaAluno> listaDisciplinaAluno = new();

bool loop = true;

while (loop)
{
    try
    {
        Aluno aluno = new();
        Professor professor = new();
        Disciplina disciplina = new();
        DisciplinaAluno disciplinaAluno = new();

        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1-Cadastrar um aluno");
        Console.WriteLine("2-Listar todos os alunos");
        Console.WriteLine("3-Cadastrar um professor");
        Console.WriteLine("4-Listar todos os professores");
        Console.WriteLine("5-Cadastrar uma disciplina");
        Console.WriteLine("6-Listar todas as disciplinas");
        Console.WriteLine("7-Associar aluno a disciplina");
        Console.WriteLine("8-Listar todas as associações de alunos e disciplinas");
        Console.WriteLine("9-Verificar aprovação dos alunos");
        Console.WriteLine("10-Sair");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                aluno.CadastrarAluno();
                listaAlunos.Add(aluno);

                break;

            case 2:
                foreach (Aluno a in listaAlunos)
                {
                    Console.WriteLine($"Matrícula: {a.Matricula}");
                    Console.WriteLine($"Nome: {a.Nome}");
                    Console.WriteLine($"CPF: {a.CPF}");
                    Console.WriteLine($"Sexo: {a.Sexo}");
                    Console.WriteLine($"Rua: {a.Endereco.Rua}");
                    Console.WriteLine($"Bairro: {a.Endereco.Bairro}");
                    Console.WriteLine($"CEP: {a.Endereco.CEP}");
                    Console.WriteLine($"Número: {a.Endereco.Numero}");
                    Console.WriteLine($"Complemento: {a.Endereco.Complemento}");
                    Console.WriteLine($"Telefone: {a.Telefone}");
                    Console.WriteLine($"Email: {a.Email}");

                    Console.WriteLine("");
                }

                break;

            case 3:
                professor.CadastrarProfessor();
                listaProfessores.Add(professor);

                break;

            case 4:
                foreach (Professor p in listaProfessores)
                {
                    Console.WriteLine($"Chapa: {p.Chapa}");
                    Console.WriteLine($"Titulação: {p.Titulacao}");
                    Console.WriteLine($"Nome: {p.Nome}");
                    Console.WriteLine($"CPF: {p.CPF}");
                    Console.WriteLine($"Sexo: {p.Sexo}");
                    Console.WriteLine($"Rua: {p.Endereco.Rua}");
                    Console.WriteLine($"Bairro: {p.Endereco.Bairro}");
                    Console.WriteLine($"CEP: {p.Endereco.CEP}");
                    Console.WriteLine($"Número: {p.Endereco.Numero}");
                    Console.WriteLine($"Complemento: {p.Endereco.Complemento}");
                    Console.WriteLine($"Telefone: {p.Telefone}");
                    Console.WriteLine($"Email: {p.Email}");

                    Console.WriteLine("");
                }
                break;

            case 5:
                if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Não há professores cadastrados");
                    break;
                }

                disciplina.CadastrarDisciplina();

                for (int i = 0; i < listaProfessores.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaProfessores.ElementAt(i).Nome}");
                }

                Console.Write("Escolha um professor para a disciplina: ");

                int escolhaProfessor = Convert.ToInt32(Console.ReadLine()) - 1;


                if (escolhaProfessor < 0 || escolhaProfessor >= listaProfessores.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                disciplina.Professor = listaProfessores[escolhaProfessor];

                if (disciplina.CargaHoraria > 40 && disciplina.Professor.Titulacao == "Graduado" || disciplina.Professor.Titulacao == "Especialista")
                {
                    Console.WriteLine("Disciplinas para professores graduados ou especialistas não podem ter mais de 40 horas de carga horária\n");
                    break;
                }

                listaDisciplinas.Add(disciplina);

                Console.WriteLine($"Disciplina {disciplina.Nome} cadastrada com o professor {disciplina.Professor.Nome}\n");

                break;

            case 6:
                foreach (Disciplina d in listaDisciplinas)
                {
                    Console.WriteLine($"Código: {d.Codigo}");
                    Console.WriteLine($"Nome: {d.Nome}");
                    Console.WriteLine($"Nome do professor: {d.Professor.Nome}");
                    Console.WriteLine($"Chapa do professor: {d.Professor.Chapa}");
                    Console.WriteLine($"Titulação do professor: {d.Professor.Titulacao}");
                    Console.WriteLine($"Telefone do professor: {d.Professor.Telefone}");
                    Console.WriteLine($"Carga horária: {d.CargaHoraria}");

                    Console.WriteLine("");
                }

                break;

            case 7:
                if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Não há disciplinas cadastradas\n");
                    break;
                }

                if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados\n");
                    break;
                }

                Console.WriteLine("Selecione o aluno para fazer a associação");

                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    Console.Write(i + 1 + $"-{listaAlunos.ElementAt(i).Nome}");
                    Console.WriteLine($"/{listaAlunos.ElementAt(i).Matricula}");
                }

                int escolhaAluno = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAluno < 0 || escolhaAluno >= listaAlunos.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                disciplinaAluno.CPFAluno = listaAlunos[escolhaAluno].CPF;

                Console.WriteLine("Selecione a disciplina para fazer a associação");

                for (int i = 0; i < listaDisciplinas.Count; i++)
                {
                    Console.Write(i + 1 + $"-{listaDisciplinas.ElementAt(i).Nome}");
                    Console.WriteLine($"/{listaDisciplinas.ElementAt(i).Codigo}");
                }

                int escolhaDisciplinaAluno = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaDisciplinaAluno < 0 || escolhaDisciplinaAluno >= listaDisciplinas.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                disciplinaAluno.CodigoDisciplina = listaDisciplinas[escolhaDisciplinaAluno].Codigo;

                Console.Write("Digite a nota final do aluno: ");
                disciplinaAluno.NotaFinal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a porcentagem de faltas do aluno: ");
                disciplinaAluno.QuantidadeDeFaltas = Convert.ToDouble(Console.ReadLine());

                listaDisciplinaAluno.Add(disciplinaAluno);

                Console.WriteLine($"Disciplina de código {disciplinaAluno.CodigoDisciplina} associada com o aluno de CPF: {disciplinaAluno.CPFAluno}\n");

                break;

            case 8:
                foreach (DisciplinaAluno da in listaDisciplinaAluno)
                {
                    Console.WriteLine($"CPF do aluno: {da.CPFAluno}");
                    Console.WriteLine($"Código da disciplina: {da.CodigoDisciplina}");
                    Console.WriteLine($"Nota final do aluno: {da.NotaFinal}");
                    Console.WriteLine($"Porcentagem de faltas do aluno: {da.QuantidadeDeFaltas}%");

                    Console.WriteLine("");
                }

                break;

            case 9:
                if (listaDisciplinaAluno.Count == 0)
                {
                    Console.WriteLine("Não há nenhuma associação de disciplinas e alunos\n");
                    break;
                }

                foreach (DisciplinaAluno da in listaDisciplinaAluno)
                {
                    string statusAluno = "Reprovado";

                    if (da.QuantidadeDeFaltas < 25 && da.NotaFinal >= 6)
                        statusAluno = "Aprovado";

                    Console.WriteLine($"CPF do aluno: {da.CPFAluno}");
                    Console.WriteLine($"Código da disciplina: {da.CodigoDisciplina}");
                    Console.WriteLine($"Nota Final: {da.NotaFinal}");
                    Console.WriteLine($"Porcentagem de faltas: {da.QuantidadeDeFaltas}");
                    Console.WriteLine($"Situação do aluno: {statusAluno}");

                    Console.WriteLine("");
                }

                break;

            case 10:
                loop = false;
                break;

            default:
                Console.WriteLine("Opção inválida\n");
                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
