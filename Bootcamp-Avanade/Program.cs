using System;

class Programa
{
    static void Main()
    {
        // Solicita a entrada de dados do usuário 
        Console.WriteLine("Digite o tipo de serviço desejado (basico, intermediario, avancado ou premium): ");
        string entrada = Console.ReadLine().ToUpper();

        // Validação da entrada logo após o input
        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Serviço inválido");
            return; // Encerra o programa
        }
    }
}