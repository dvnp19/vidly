using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Vidly.Models;

public class Customer
{
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; }
    public DateOnly? Birthdate { get; set; }
    public bool IsSubscribedToNewsLetter { get; set; }
    public MembershipType MembershipType { get; set; }  
    public byte MembershipTypeId { get; set; }
    
    
}