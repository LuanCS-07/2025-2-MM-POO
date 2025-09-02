public class Televisao{

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public Televisao (float tamanho) {
        Tamanho = tamanho;
    }

public void AumentarVolume()
{
    if (Volume < 100)
        Volume = Volume + 1;
    else
        Console.WriteLine(" TV ja esta no max."); 
}

public void DiminuirVolume()
{
    if (Volume > 0)
    Volume = Volume - 1;
    else 
        Console.WriteLine("TV ja esta no min.");
}

public void AumentarCanal()
{
     Canal = Canal + 1;
}

public void DiminuirCanal()
{
     Canal = Canal - 1;
}
}