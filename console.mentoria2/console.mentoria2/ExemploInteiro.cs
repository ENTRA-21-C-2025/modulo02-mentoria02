using System;

namespace console.mentoria2;

/// <summary>
/// Classe que demonstra operações com números inteiros em C#.
/// O tipo int (inteiro) é usado para representar números inteiros sem casas decimais,
/// sendo um dos tipos numéricos mais comuns em programação.
/// </summary>
public class ExemploInteiro
{
    /// <summary>
    /// Método que demonstra operações básicas com números inteiros.
    /// O método realiza as seguintes operações:
    /// - Solicita dois números inteiros ao usuário
    /// - Realiza as quatro operações básicas da matemática:
    ///   * Soma (+)
    ///   * Subtração (-)
    ///   * Multiplicação (*)
    ///   * Divisão (/)
    /// - Demonstra o operador de módulo (%) que retorna o resto da divisão
    /// 
    /// Importante: A divisão entre inteiros sempre retorna um resultado inteiro,
    /// descartando a parte decimal.
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("\n=== Exemplo com Números Inteiros ===");

        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nValor inicial do número1: {numero1}");

        // Soma usando operador de atribuição
        int resultado = numero1;
        resultado += numero2;
        Console.WriteLine($"Soma usando 'resultado += numero2' -> {resultado}");

        // Subtração usando operador de atribuição
        resultado = numero1;
        resultado -= numero2;
        Console.WriteLine($"Subtração usando 'resultado -= numero2' -> {resultado}");

        // Multiplicação usando operador de atribuição
        resultado = numero1;
        resultado *= numero2;
        Console.WriteLine($"Multiplicação usando 'resultado *= numero2' -> {resultado}");

        // Divisão usando operador de atribuição
        resultado = numero1;
        resultado /= numero2;
        Console.WriteLine($"Divisão usando 'resultado /= numero2' -> {resultado}");

        // Resto da divisão usando operador de atribuição
        resultado = numero1;
        resultado %= numero2;
        Console.WriteLine($"Resto da divisão usando 'resultado %= numero2' -> {resultado}");
    }
}