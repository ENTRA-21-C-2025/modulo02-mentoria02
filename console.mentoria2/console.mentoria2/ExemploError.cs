using System;

namespace console.mentoria2;

/// <summary>
/// Classe que demonstra exemplos de tratamento de exceções em C#
/// </summary>
public class ExemploError
{
    /// <summary>
    /// Método que demonstra o tratamento de diferentes tipos de exceções.
    /// O modificador 'static' permite que este método seja chamado sem a necessidade de criar uma instância da classe.
    /// Isso significa que podemos chamar o método diretamente usando ExemploError.Executar().
    /// </summary>
    public static void Executar()
    {
        Console.WriteLine("\n=== Exemplo de Tratamento de Erro ===");
        
        // Exemplo 1: Erro de formato
        try
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);
            
            Console.WriteLine($"Você digitou: {numero}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: Por favor, digite um número válido! {ex}");
        }
        finally
        {
            Console.WriteLine("Este bloco sempre será executado!");
        }

        // Exemplo 2: Divisão por zero
        try
        {
            Console.Write("\nDigite o numerador: ");
            int numerador = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o denominador: ");
            int denominador = int.Parse(Console.ReadLine());
            
            int resultado = numerador / denominador;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: Não é possível dividir por zero! {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Este bloco sempre será executado!");
        }
    }
} 