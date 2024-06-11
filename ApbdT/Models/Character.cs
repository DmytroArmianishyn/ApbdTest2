using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Apbd_kolos2.Models;

namespace ApbdT.Models;

[Table("characters")]
public class Character
{
    [Key] 
    public int id { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }= string.Empty;
    [MaxLength(100)]
    public string LastName { get; set; }= string.Empty;
    public int MaxWeight { get; set; }
    public int CurrentWeight { get; set; }
    public ICollection<Backpacks> Backpacks { get; set; } = new HashSet<Backpacks>();

}