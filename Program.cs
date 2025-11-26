using System;

class Program
{
    static void Main(string[] args)
    {
        var localizacao = new Localizacao { Latitude = 0m, Longitude = 0m };

        Console.WriteLine("=== Sistema de Navegação ===");
        Console.WriteLine($"Localização inicial: {localizacao}");
        Console.WriteLine("\nComandos disponíveis:");
        Console.WriteLine("  norte <distancia>  - Mover para norte");
        Console.WriteLine("  sul <distancia>    - Mover para sul");
        Console.WriteLine("  leste <distancia>  - Mover para leste");
        Console.WriteLine("  oeste <distancia>  - Mover para oeste");
        Console.WriteLine("  sair               - Sair do programa");
        Console.WriteLine();

        while (true)
        {
            Console.Write("> ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
                continue;

            localizacao = ProcessarComando(entrada, localizacao);
        }
    }

    static Localizacao ProcessarComando(string entrada, Localizacao atual)
    {
        var partes = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (partes.Length < 1)
            return atual;

        string comando = partes[0].ToLower();
        decimal distancia = 0;

        if (comando == "sair")
        {
            Console.WriteLine("Até logo!");
            Environment.Exit(0);
        }

        if (partes.Length > 1 && !decimal.TryParse(partes[1], out distancia))
        {
            Console.WriteLine("Distância inválida. Use um número decimal.");
            return atual;
        }

        Localizacao nova;

        switch (comando)
        {
            case "norte":
                nova = Movimentos.MoverNorte(atual, distancia);
                break;
            case "sul":
                nova = Movimentos.MoverSul(atual, distancia);
                break;
            case "leste":
                nova = Movimentos.MoverLeste(atual, distancia);
                break;
            case "oeste":
                nova = Movimentos.MoverOeste(atual, distancia);
                break;
            default:
                Console.WriteLine("Comando desconhecido.");
                return atual;
        }

        Console.WriteLine($"Localização: {nova}");
        return nova;
    }
}

