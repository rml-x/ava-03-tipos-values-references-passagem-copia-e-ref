// See https://aka.ms/new-console-template for more information

public struct Localizacao 
{ 
    public decimal Latitude;
    public decimal Longitude;
    
    public override string ToString()
    {
        return $"Lat: {Latitude}, Lon: {Longitude}";
    }
}

public static class Movimentos
{
    public static Localizacao MoverNorte(Localizacao atual, decimal distancia)
    {
        Localizacao nova = new Localizacao();

        nova.Latitude = atual.Latitude + distancia;
        nova.Longitude = atual.Longitude;

        if (nova.Latitude > 90)
        {
            nova.Latitude = nova.Latitude - 180;
        }
        if (nova.Latitude < -90)
        {
            nova.Latitude = nova.Latitude + 180;
        }
 
        return nova;
    }

    public static Localizacao MoverSul(Localizacao atual, decimal distancia)
    {
        Localizacao nova = new Localizacao();

        nova.Latitude = atual.Latitude - distancia;
        nova.Longitude = atual.Longitude;

        if (nova.Latitude > 90)
        {
            nova.Latitude = nova.Latitude - 180;
        }
        if (nova.Latitude < -90)
        {
            nova.Latitude = nova.Latitude + 180;
        }

        return nova;
    }

     public static Localizacao MoverLeste(Localizacao atual, decimal distancia)
    {
        Localizacao nova = new Localizacao();

        nova.Latitude = atual.Latitude;
        nova.Longitude = atual.Longitude + distancia;

        if (nova.Longitude > 180)
        {
            nova.Longitude = nova.Longitude - 360;
        }
        if (nova.Longitude < -180)
        {
            nova.Longitude = nova.Longitude + 360;
        }
        

        return nova;
    }

     public static Localizacao MoverOeste(Localizacao atual, decimal distancia)
    {
        Localizacao nova = new Localizacao();

        nova.Latitude = atual.Latitude;
        nova.Longitude = atual.Longitude - distancia;

        
        if (nova.Longitude > 180)
        {
            nova.Longitude = nova.Longitude - 360;
        }
        if (nova.Longitude < -180)
        {
            nova.Longitude = nova.Longitude + 360;
        }

        return nova;
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