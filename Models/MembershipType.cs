namespace Vidly.Models;

public class MembershipType
{
    public byte Id { get; set; }
    public short SignupFee { get; set; }
    public string Name { get; set; }
    public byte DurationInMonths { get; set; }
    public byte DiscountRate { get; set; }
}