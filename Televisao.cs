public class Televisao{

    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public Televisao (float tamanho) {
        Tamanho = tamanho;
    }

public void AumentarVolume()
{
    if (Volume < VOL_MAX)
        Volume = Volume + 1;
    else
        Console.WriteLine(" TV ja esta no max."); 
}

public void DiminuirVolume()
{
    if (Volume > VOL_MIN)
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