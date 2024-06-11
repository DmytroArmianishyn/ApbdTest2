using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApbdT.Models;
[Table("titles")]
public class Titles
{
    [Key] 
    public int id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }= string.Empty;
    
    public ICollection<CharacterTitels> Backpacks { get; set; } = new HashSet<CharacterTitels>();
    
}