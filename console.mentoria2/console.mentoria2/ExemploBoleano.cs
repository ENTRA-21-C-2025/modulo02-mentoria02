using System;

namespace console.mentoria2;

/// <summary>
/// Classe que demonstra o uso de operadores booleanos e lógicos em C#.
/// Booleanos são tipos de dados que podem ter apenas dois valores: true (verdadeiro) ou false (falso).
/// </summary>
public class ExemploBoleano
{
    /// <summary>
    /// Método que demonstra o uso de operadores booleanos e lógicos através de um exemplo prático de verificação de idade.
    /// O método solicita a idade do usuário e realiza diferentes verificações usando operadores de comparação (>=) e lógicos (&&, ||, !).
    /// Exemplos demonstrados:
    /// - Verificação de maioridade (>= 18)
    /// - Verificação de direito ao voto (>= 16)
    /// - Verificação de habilitação para dirigir (>= 18)
    /// - Uso de operadores lógicos AND (&&), OR (||) e NOT (!)
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("\n=== Exemplo com Booleanos ===");
        
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        bool maiorDeIdade = idade >= 18;
        bool podeVotar = idade >= 16;
        bool podeDirigir = idade >= 18;
        
        Console.WriteLine($"\nMaior de idade: {maiorDeIdade}");
        Console.WriteLine($"Pode votar: {podeVotar}");
        Console.WriteLine($"Pode dirigir: {podeDirigir}");
        
        // Operadores lógicos
        Console.WriteLine($"\nPode votar E dirigir: {podeVotar && podeDirigir}");
        Console.WriteLine($"Pode votar OU dirigir: {podeVotar || podeDirigir}");
        Console.WriteLine($"Não é maior de idade: {!maiorDeIdade}");
    }
} 