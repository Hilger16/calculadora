/*Objetivo: usando uma aplicação do tipo console do dotnet, 
criar uma calculadora simples que terá as operações de 
soma, subtração, multiplicação e divisão.

O menu deve ter as opções:
1 - Somar
2 - Subtrair
3 - Multiplicar
4 - Dividir
0 - Sair
Desafios
Crie uma nova opção na calculadora (opção número 5 do menu) 
que retorne o resto da divisão.
Crie uma nova opção na calculadora (opção número 6 do menu) 
que retorne o resultado da potenciação de uma determinada base 
pelo seu expoente. Exemplo 2³ = 8.

 */

internal class Program
{
    
    static void Main(string[] args)
    {
        Menu();
    }
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair");

        string opcao = Console.ReadLine();

        switch(opcao)
        {
            case "1":
                Somar();
                break;
            case "2":
                Subtrair();
                break;
            case "3":
                Multiplicar();
                break;
            case "4":
                Dividir();
                break;
            case "5":
                RestodaDivisao();
                break;
            case "6":
                Potenciacao();
                break;
            case "0":
                break;
            default:
                Menu();
                break;
            
        }
        static void Somar()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            Console.ReadLine();
            Menu();
        }
        static void Subtrair()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
            Console.ReadLine();
            Menu();
        }
        static void Multiplicar()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
            Console.ReadLine();
            Menu();
        }
        static void Dividir()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            if(valor2 != 0)
            {
                Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
            }else
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            Console.ReadLine();
            Menu();
        }
        static void RestodaDivisao()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            if(valor2 != 0)
            {
                Console.WriteLine($"Resto entre {valor1} e {valor2} = {valor1 % valor2}");
            }else
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            Console.ReadLine();
            Menu();
        }
        static void Potenciacao()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} elevado a {valor2} = {Math.Pow(valor1, valor2)}");
            Console.ReadLine();
            Menu();
        }
    }
}