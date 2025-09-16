
public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }
    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public String Portador { get; set; }
    public String Cvv { get; set; }
    

}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}
