using System;

namespace TarefaMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varíavel para guardar o número digitado
            int numx = 0;

            //Usuario digita quantas colunas e linhas quer e armazena
            Console.WriteLine("Digite um valor para a coluna M");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para a linha N");
            int n = int.Parse(Console.ReadLine());

            //Gerando a matriz
            int[,] matriz2 = new int[m, n];
            //Guardando o numero
            for (int i = 0; i < m; i++)
            {
                for (int o = 0; o < n; o++)
                {
                    Console.WriteLine("Diga um número: ");
                    matriz2[i, o] = int.Parse(Console.ReadLine());
                }
            }
            //Pega o número do usuário a ser buscado
            Console.WriteLine("Qual número quer buscar?: ");
            int val = int.Parse(Console.ReadLine());
            //Métodos para analisar os números da matriz
            for (int i = 0; i < m; i++)
            {
                for (int o = 0; o < n; o++)
                {
                    if (val == matriz2[i, o])
                    {
                        Direita(i, o);
                        Esquerda(i, o);
                        Cima(i, o);
                        Baixo(i, o);
                    }
                }
            }
            //Métodos que comparam os números em volta do armazenado       
            void Direita(int i, int o)
            {
                o = o + 1;
                if (o < n && o >= 0)
                {
                    numx = matriz2[i, o];
                    Console.WriteLine("Direita: " + numx);
                }
                else
                {
                    Console.WriteLine("Direita: Sem número ");
                }
            }
            void Esquerda(int i, int o)
            {
                o = o - 1;
                //Métodos checando se o número está em volta
                if (o < n && o >= 0)
                {
                    numx = matriz2[i, o];
                    Console.WriteLine("Esquerda: " + numx);
                }
                else
                {
                    Console.WriteLine("Esquerda: Sem número");
                }
            }
            void Cima(int i, int o)
            {
                i = i - 1;
                if (i < m && i >= 0)
                {
                    numx = matriz2[i, o];
                    Console.WriteLine("Cima: " + numx);
                }
                else
                {
                    Console.WriteLine("Cima: Sem número");
                }
            }
            void Baixo(int i, int o)
            {
                i = i + 1;
                if (i < m && i >= 0)
                {
                    numx = matriz2[i, o];
                    Console.WriteLine("Abaixo: " + numx);
                }
                else
                {
                    Console.WriteLine("Abaixo: Sem número");
                }

            }
        }
    }
}