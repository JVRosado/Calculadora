using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            //MENU DE TIPO DE OPERAÇÃO
            while (true)
            {
                /*var calculator = new Calculator();
                var calculaBinario = new CalculaBinario();*/

                Console.WriteLine("=== ESCOLHA O TIPO DE OPERAÇÃO ===");
                Console.WriteLine("1 Operação Simples");
                Console.WriteLine("2 Função: ");
                Console.WriteLine("3 Binario");
                Console.WriteLine("4 Coeficiente de variação");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        OperacaoSimples(); // Chamada apenas para exibir o menu
                        break;
                    case 2:
                        CalcFuncao();
                        break;
                    case 3:
                        Binario();
                        break;
                    case 4:
                        Estatistica();
                        break;

                }
            }
        }

        static void OperacaoSimples()
        {
            //menu para escoler o tipo de operação simples
            Console.Write("Escolha uma opção de operação simples: : ");
            Console.WriteLine("=== ESCOLHA UM TIPO DE OPERAÇÃO");
            Console.WriteLine("1 Adição: ");
            Console.WriteLine("2 Subtração: ");
            Console.WriteLine("3 Multiplicação: ");
            Console.WriteLine("3 Divisão: ");
            Console.Write("Escolha uma das opçoes: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Adicao(); // Chamada apenas para exibir soma
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
            }

            void Adicao()
            {
                Console.Write("Infome o Primeiro valor que Deseja somar: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Infome o Segundo valor que Deseja somar: ");
                int num2 = int.Parse(Console.ReadLine());
                int soma = num1 + num2;
                Console.WriteLine($"A soma de {num1} + {num2} = {soma}");
            }

            void Subtracao()
            {
                Console.Write("Infome o Primeiro valor que Deseja Subtrair: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Infome o Segundo valor que Deseja Subtrair: ");
                int num2 = int.Parse(Console.ReadLine());
                int subitracao = num1 - num2;
                Console.WriteLine($"A multiplicação de {num1} - {num2} = {subitracao}");
            }

            void Multiplicacao()
            {
                Console.Write("Infome o Primeiro valor que Deseja Multiplicar: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Infome o Segundo valor que Deseja Multiplicar: ");
                int num2 = int.Parse(Console.ReadLine());
                int multiplica = num1 * num2;
                Console.WriteLine($"A multiplicação de {num1} * {num2} = {multiplica}");
            }

            void Divisao()
            {
                Console.Write("Infome o Primeiro valor que Deseja Dividir: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Infome o Segundo valor que Deseja Dividir: ");
                int num2 = int.Parse(Console.ReadLine());
                int divisao = num1 * num2;
                Console.WriteLine($"A multiplicação de {num1} / {num2} = {divisao}");
            }
        }

        static void CalcFuncao()
        {
            Console.WriteLine("=== ESCOLHA UM TIPO DE FUNCAO");
            Console.WriteLine("1 Função de Primeiro grau: ");
            Console.WriteLine("2 Função de segundo grau: ");
            Console.Write("Escolha uma das opçoes: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    PrimeiroGrau();
                    break;
                case 2:
                    SegundoGrau();
                    break;
            }

            void PrimeiroGrau()
            {
                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Digite os coeficientes da função de primeiro grau ax + b = 0");
                    Console.Write("a: ");
                    double coeficienteA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b: ");
                    double coeficienteB = Convert.ToDouble(Console.ReadLine());

                    if (coeficienteA == 0)
                    {
                        Console.WriteLine("O coeficiente A não pode ser igual a 0");
                    }
                    else
                    {
                        double raiz = -coeficienteB / coeficienteA;
                        Console.WriteLine($"A raiz da funcação é {raiz}");
                        loop = false;

                    }
                }
            }

            void SegundoGrau()
            {
                string repetir = "";
                bool continuar = true;
                while (continuar)
                {

                    Console.WriteLine("Digite o coeficente da função quadratica b^2 - 4 * a * c: ");
                    Console.Write("Informe o valor de A: ");
                    double coeficienteA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe o valor de B: ");
                    double coeficienteB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe o valor de C: ");
                    double coeficienteC = Convert.ToDouble(Console.ReadLine());
                    double discriminante = coeficienteB * coeficienteB - 4 * coeficienteA * coeficienteC;

                    if (discriminante > 0)
                    {
                        double raiz1 = (-coeficienteB + Math.Sqrt(discriminante)) / (2 * coeficienteA);
                        double raiz2 = (-coeficienteB - Math.Sqrt(discriminante)) / (2 * coeficienteA);
                        Console.WriteLine($"Raiz 1 = {raiz1}");
                        Console.WriteLine($"Raiz 2 = {raiz2}");

                    }
                    else if (discriminante == 0)
                    {
                        double raizUnica = -coeficienteB / (2 * coeficienteA);
                        Console.WriteLine($"Raiz única: {raizUnica}");
                    }
                    else
                    {
                        Console.WriteLine("A equação não possui raízes reais.");

                    }

                    Console.WriteLine("Deseja repetir a operação? digite sim para repetir e não para voltar ao menu ");
                    repetir = Console.ReadLine();

                    if (repetir != "sim")
                    {
                        continuar = false;
                    }
                }
            }
        }

        static void Binario()
        {
            string repetir = "";
            bool continuar = true;
            while (continuar)
            {
                Console.Write("Digite o primeiro número binário: ");
                string binary1 = Console.ReadLine();

                Console.Write("Digite o segundo número binário: ");
                string binary2 = Console.ReadLine();

                // Convert binary strings to integers
                int num1 = Convert.ToInt32(binary1, 2);
                int num2 = Convert.ToInt32(binary2, 2);

                // Perform binary operations
                int sum = num1 + num2;
                int difference = num1 - num2;
                int product = num1 * num2;

                // Display results
                Console.WriteLine($"Soma: {Convert.ToString(sum, 2)}");
                Console.WriteLine($"Diferença: {Convert.ToString(difference, 2)}");
                Console.WriteLine($"Produto: {Convert.ToString(product, 2)}");
                Console.Write("Deseja continuar? digite sim ");
                repetir = Console.ReadLine();
                if (repetir != "sim")
                {
                    continuar = false;
                }
            }
        }

        static void Estatistica()
        {
            List<double> valores = new List<double>();
            string entrada;

           

            while (true)
            {
                Console.Write("Insira os valores (separados por espaço) ou digite \"fim\" para encerrar:");
                entrada = Console.ReadLine();

                if (entrada.ToLower() == "fim")
                {
                    break;  
                }
                
                string[] partes = entrada.Split(' '); // Divide a entrada em partes

                foreach (var parte in partes) //percorremos cada elemeto da coleção partes
                {
                    if (double.TryParse(parte, out double valor)) // verificando se o valor da variável parte pode ser convertido em um número de ponto flutuante (double)
                        valores.Add(valor);
                    else
                        Console.WriteLine($"Valor inválido: {parte}. Insira um número válido ou \"fim\" para encerrar.");
                }
            }

            if (valores.Count == 0)
            {
                Console.WriteLine("Nenhum valor válido inserido. O programa será encerrado.");
                return;
            }

            // Cálculo da média, desvio padrão e coeficiente de variação
            double media = CalculaMedia(valores);
            double desvioPadrao = CalculaDesvioPadrao(valores, media);
            double coeficienteVariacao = (desvioPadrao / media) * 100;
            
            // Exibe todos os valores inseridos
            Console.WriteLine("Valores inseridos:");
            foreach (var val in valores)
            {
                Console.Write($"[ {val} ] ");
            }
            Console.WriteLine($"Coeficiente de Variação: {coeficienteVariacao:F2}%");
            Console.WriteLine($"Media {media:F2}");
            
        }
        
        //calculo da media 
        static double CalculaMedia(List<double> valores)
        {
            double soma = 0;
            foreach (var val in valores)
                soma += val;
            return soma / valores.Count;
        }

        static double CalculaDesvioPadrao(List<double> valores, double media)
        {
            double somaDiferencasQuadradas = 0;
            foreach (var val in valores)
                somaDiferencasQuadradas += Math.Pow(val - media, 2);
            return Math.Sqrt(somaDiferencasQuadradas / valores.Count);
        }

    }
}