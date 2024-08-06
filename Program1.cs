using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um exercício para executar e descrubra o resultado:");
        Console.WriteLine("1 - Mensagem de boas-vindas personalizada");
        Console.WriteLine("2 - Concatenação de nome e sobrenome");
        Console.WriteLine("3 - Operações com dois valores double");
        Console.WriteLine("4 - Contagem de caracteres de uma palavra");
        Console.WriteLine("5 - Verificação de placa de veículo");
        Console.WriteLine("6 - Exibição da data atual em diferentes formatos");
        Console.Write("Digite o número do exercício: ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                MensagemBoasVindas();
                break;
            case 2:
                ConcatenaNomeSobrenome();
                break;
            case 3:
                OperacoesDouble();
                break;
            case 4:
                ContagemCaracteres();
                break;
            case 5:
                VerificacaoPlaca();
                break;
            case 6:
                ExibeDataAtual();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static void MensagemBoasVindas()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicita ao usuário que digite uma mensagem de boas-vindas
        Console.Write("Digite uma mensagem de boas-vindas: ");
        string mensagem = Console.ReadLine();

        // Exibe a mensagem de boas-vindas personalizada com o nome do usuário
        string mensagemPersonalizada = $"Olá, {nome}! {mensagem}";
        Console.WriteLine(mensagemPersonalizada);
    }

    static void ConcatenaNomeSobrenome()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine($"Nome completo: {nomeCompleto}");
    }

    static void OperacoesDouble()
    {
        Console.Write("Digite o primeiro valor (double): ");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo valor (double): ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        double soma = valor1 + valor2;
        double subtracao = valor1 - valor2;
        double multiplicacao = valor1 * valor2;
        double divisao = (valor2 != 0) ? valor1 / valor2 : double.NaN; // Verificação para divisão por zero
        double media = (valor1 + valor2) / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {(valor2 != 0 ? divisao.ToString() : "Divisão por zero não permitida")}");
        Console.WriteLine($"Média: {media}");
    }

    static void ContagemCaracteres()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        int quantidadeCaracteres = palavra.Length;
        Console.WriteLine($"A palavra digitada possui: {quantidadeCaracteres} caracteres.");
    }

    static void VerificacaoPlaca()
    {
        Console.Write("Digite a placa de um veículo: ");
        string placa = Console.ReadLine();

        bool placaValida = Regex.IsMatch(placa, @"^[A-Z]{3}\d{4}$", RegexOptions.IgnoreCase);
        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }

    static void ExibeDataAtual()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
        Console.WriteLine("Data no formato 'dd/MM/yyyy': " + dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine("Hora no formato 24 horas: " + dataAtual.ToString("HH:mm"));
        Console.WriteLine("Data com o mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}
