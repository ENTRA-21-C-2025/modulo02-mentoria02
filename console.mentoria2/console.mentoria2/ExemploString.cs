using System;

namespace console.mentoria2;

/// <summary>
/// Classe que demonstra operações com strings (texto) em C#.
/// Strings são sequências de caracteres que representam texto e são imutáveis,
/// ou seja, quando modificadas, uma nova string é criada.
/// </summary>
public class ExemploString
{
    /// <summary>
    /// Método que demonstra várias operações comuns com strings.
    /// O método realiza as seguintes operações:
    /// - Solicita nome e sobrenome do usuário
    /// - Demonstra diferentes formas de manipulação de strings:
    ///   * Concatenação de strings usando o operador +
    ///   * Conversão para maiúsculas (ToUpper) e minúsculas (ToLower)
    ///   * Obtenção do tamanho da string (Length)
    ///   * Acesso a caracteres específicos usando índice
    ///   * Substituição de caracteres (Replace)
    ///   * Extração de parte da string (Substring)
    /// 
    /// Importante: Em C#, strings são indexadas a partir de 0, ou seja,
    /// o primeiro caractere está na posição 0.
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("\n=== Exemplo com Strings ===");
        
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        
        // Concatenação
        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine($"\nNome completo: {nomeCompleto}");
        
        // Métodos de string
        Console.WriteLine($"\nMaiúsculas: {nomeCompleto.ToUpper()}");
        Console.WriteLine($"Minúsculas: {nomeCompleto.ToLower()}");
        Console.WriteLine($"Tamanho do nome: {nomeCompleto.Length} caracteres");
        Console.WriteLine($"Primeiro caractere: {nomeCompleto[0]}");
        Console.WriteLine($"Último caractere: {nomeCompleto[^1]}");
        
        // Substituição
        Console.WriteLine($"\nSubstituindo espaços por underscores: {nomeCompleto.Replace(" ", "_")}");
        
        // Substring
        Console.WriteLine($"\nPrimeiras 3 letras: {nomeCompleto[..3]}");
    }
} 