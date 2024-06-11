using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Apbd_kolos2.Models;

namespace ApbdT.Models;
[Table("items")]
public class Item
{

    [Key] 
    public int id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }= string.Empty;
    public int Weight { get; set; }
    public ICollection<Backpacks> Backpacks { get; set; } = new HashSet<Backpacks>();
    


}