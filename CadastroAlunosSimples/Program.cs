using System;
using CadastroAlunosSimples.structs;
using CadastroAlunosSimples.enums;

namespace CadastroAlunosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var idAluno = 0;
            string opUser = ObterOpUser();

            while (opUser.ToUpper() != "X")
            {
                switch (opUser)
                {
                    case "1":
                        
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[idAluno] = aluno;
                        idAluno++;
                        break;

                    case "2":
                        
                        foreach( var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO:{a.Nome} - NOTA:{a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        conceitoGeral = ConceitoMediaGeral(mediaGeral);

                        Console.WriteLine($"Média geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opUser = ObterOpUser();
            }
        }

        private static Conceito ConceitoMediaGeral(decimal mediaGeral)
        {
            Conceito conceitoGeral;
            if (mediaGeral < 2)
            {
                conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
                conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
                conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
                conceitoGeral = Conceito.B;
            }
            else
            {
                conceitoGeral = Conceito.A;
            }

            return conceitoGeral;
        }

        private static string ObterOpUser()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno;");
            Console.WriteLine("2 - Listar alunos;");
            Console.WriteLine("3 - Calcular media geral;");
            Console.WriteLine("x - Finalizar aplicação.");
            Console.WriteLine();

            string opUser = Console.ReadLine();
            Console.WriteLine();
            return opUser;
        }
    }
}
