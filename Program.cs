using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar instância de um Nokia
        Nokia nokia = new Nokia("123456", "Nokia 3310", "123-456-789", 16);

        // Exibir informações do Nokia utilizando métodos públicos
        Console.WriteLine($"Nokia - Número: {nokia.numero()}");

        // Chamar métodos do Nokia
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("JogoNokia");

        Console.WriteLine();

        // Criar instância de um iPhone
        Iphone iphone = new Iphone("987654", "iPhone 12", "987-654-321", 128);

        // Exibir informações do iPhone utilizando métodos públicos
        Console.WriteLine($"iPhone - Número: {iphone.numero()}");

        // Chamar métodos do iPhone
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("JogoiPhone");
    }
}
