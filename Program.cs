using System;

namespace Exercicio_03_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno  aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Insira o nome do curso: ");
            aluno.curso = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.Write("Insira o RG do aluno: ");
            aluno.rg = Console.ReadLine();

            Console.Write("O aluno é bolsista? (S/N)");
            string respostaBolsa = Console.ReadLine();

            if(respostaBolsa == "S" || respostaBolsa == "s"){
                aluno.bolsista = true;
            }
            else if(respostaBolsa.ToLower() == "n") {
                aluno.bolsista = false;
            }

            Console.Write("Insira a média do aluno: ");
            aluno.mediaFinal = double.Parse (Console.ReadLine());

            Console.Write("Insira o valor da mensalidade");
            aluno.valorDaMensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno.nome);
            Console.WriteLine(aluno.curso);
            Console.WriteLine(aluno.idade);
            Console.WriteLine(aluno.rg);
            Console.WriteLine(aluno.bolsista);
            Console.WriteLine(aluno.mediaFinal);
            Console.WriteLine(aluno.valorDaMensalidade);

            aluno.VerMediaFinal(aluno.mediaFinal);
            aluno.VerMensalidade(aluno.bolsista,aluno.valorDaMensalidade);
        }
    }
}
