namespace API.Entity;

public class DepositAmount
{
    public int DepositId { get; set; }
    public Rule Rule { get; set; }
    public int RuleId { get; set; }
    public Account AccountSign { get; set; }
    public int AccountSignId { get; set; }
    public RealEstate RealEstate { get; set; }
    public int ReasId { get; set; }
    public string Amount { get; set; }
    public DateTime DateSign { get; set; }
    public int Status { get; set; }
}