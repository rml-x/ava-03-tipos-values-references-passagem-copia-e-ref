// See https://aka.ms/new-console-template for more information

public record struct Localizacao 
{ 
    public decimal Latitude;
    public decimal Longitude;
    

}

public static class Movimentos
{
    public static void MoverNorte(ref Localizacao atual, decimal distancia)
    {
        
        atual.Latitude = atual.Latitude + distancia;

        if (atual.Latitude > 90)
        {
            atual.Latitude = atual.Latitude - 180;
        }
        if (atual.Latitude < -90)
        {
            atual.Latitude = atual.Latitude + 180;
        }
 
    }

    public static void MoverSul(ref Localizacao atual, decimal distancia)
    {
        
        atual.Latitude = atual.Latitude - distancia;

        if (atual.Latitude > 90)
        {
            atual.Latitude = atual.Latitude - 180;
        }
        if (atual.Latitude < -90)
        {
            atual.Latitude = atual.Latitude + 180;
        }

    }

     public static void MoverLeste(ref Localizacao atual, decimal distancia)
    {
       
        atual.Longitude = atual.Longitude + distancia;

        if (atual.Longitude > 180)
        {
            atual.Longitude = atual.Longitude - 360;
        }
        if (atual.Longitude < -180)
        {
            atual.Longitude = atual.Longitude + 360;
        }
    
    }

     public static void MoverOeste(ref Localizacao atual, decimal distancia)
    {
        
        atual.Longitude = atual.Longitude - distancia;

        
        if (atual.Longitude > 180)
        {
            atual.Longitude = atual.Longitude - 360;
        }
        if (atual.Longitude < -180)
        {
            atual.Longitude = atual.Longitude + 360;
        }

    }
}

// Uma Localização tem Latitude e Longitude armazenadas em decimal
// A Latitude deve estar entre -90 e 90
// A Longitude deve estar entre -180 e 180

// Criar métodos/funções que movem uma Localização para Norte, Sul, Leste e Oeste
// Cada movimento deve receber um parâmetro decimal que indica a distância a ser movida
// Ex: Mover Norte 10.5 aumenta a Latitude em 10.5
// Se a Latitude ou Longitude ultrapassar os limites, deve girar para o lado oposto
// Ex: Se a Latitude for 95, deve ser ajustada para -85

// Implementar várias versões dessas funções, considerando o uso de classe (ou record class), uso de struct (ou record struct), com e sem return, passando por cópia e por referência.