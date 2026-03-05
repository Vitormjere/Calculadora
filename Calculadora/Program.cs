using System;

class Program {
    static void Main(string[] args) {
        int opcao = 0;

        while (opcao != 5) {
            Console.Clear();
            Console.WriteLine("------ CALCULADORA ------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4) {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double res = 0; //resultado

                switch (opcao) {
                    case 1:
                        res = num1 + num2;
                        Console.WriteLine($"Resultado: {res}");
                        break;

                    case 2:
                        res = num1 - num2;
                        Console.WriteLine($"Resultado: {res}");
                        break;

                    case 3:
                        res = num1 * num2;
                        Console.WriteLine($"Resultado: {res}");
                        break;

                    case 4:
                        if (num2 != 0) {
                            res = num1 / num2;
                            Console.WriteLine($"Resultado: {res}");
                        }
                        else {
                            Console.WriteLine("Erro: divisão por zero!");
                        }
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}