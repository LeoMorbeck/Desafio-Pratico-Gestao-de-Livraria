namespace DesafioPraticoRocket_2.Communication.Requests;

public class RequestUpdateBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Amount { get; set; }
}
