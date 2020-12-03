using System;

namespace Exercicio_03_12_2020
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;
        public void VerMediaFinal(double media){
            Console.WriteLine($"Amédia do aluno é: {media}");
        }

        public void VerMensalidade (bool bolsista, double mensalidade) {
            if(bolsista == true){
                Console.WriteLine("Esse aluno é bolsista");
                Console.WriteLine($"Mensalidade sem desconto: {mensalidade}");

                Console.WriteLine($"Mensaliadde com desconto:{mensalidade * 0.7}");
            }
            else
            {
                Console.WriteLine("Esse aluno não é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");              
            }
        }
    }
}