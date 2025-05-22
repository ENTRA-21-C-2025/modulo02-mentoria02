using System;

namespace console.mentoria2;

/// <summary>
/// Classe que demonstra operações com números decimais em C#.
/// O tipo decimal é usado para representar números com precisão decimal, sendo ideal para cálculos financeiros
/// e outros cenários que requerem alta precisão.
/// </summary>
public class ExemploDecimal
{
    /// <summary>
    /// Método que demonstra operações básicas com números decimais e funções de arredondamento.
    /// O método realiza as seguintes operações:
    /// - Solicita dois números decimais ao usuário
    /// - Realiza as quatro operações básicas (soma, subtração, multiplicação e divisão)
    /// - Demonstra diferentes tipos de arredondamento usando métodos da classe Math:
    ///   * Ceiling: arredonda para cima
    ///   * Floor: arredonda para baixo
    ///   * Round: arredonda para o número inteiro mais próximo
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("\n=== Exemplo com Números Decimais ===");
        
        Console.Write("Digite o primeiro número decimal: ");
        decimal numero1 = decimal.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo número decimal: ");
        decimal numero2 = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"\nSoma: {numero1 + numero2}");
        Console.WriteLine($"Subtração: {numero1 - numero2}");
        Console.WriteLine($"Multiplicação: {numero1 * numero2}");
        Console.WriteLine($"Divisão: {numero1 / numero2}");
        
        // Arredondamento
        Console.WriteLine($"\nArredondamento para cima: {Math.Ceiling(numero1)}");
        Console.WriteLine($"Arredondamento para baixo: {Math.Floor(numero1)}");
        Console.WriteLine($"Arredondamento para o mais próximo: {Math.Round(numero1)}");
    }
} 