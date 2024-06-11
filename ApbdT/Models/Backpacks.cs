using System.ComponentModel.DataAnnotations.Schema;
using ApbdT.Models;
using Microsoft.EntityFrameworkCore;

namespace Apbd_kolos2.Models;

[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
[Table("backpacks")]
public class Backpacks
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }
    
    [ForeignKey(nameof(CharacterId))]
    public Character Character { get; set; } = null!;
    
    [ForeignKey(nameof(ItemId))]
    public Item Item { get; set; } = null!;
}