using Apbd_kolos2.Models;

namespace ApbdT.Dto;

public class GetCharacterDto
{
    
    public int id { get; set; }
    public string FirstName { get; set; }= string.Empty;
    public string LastName { get; set; }= string.Empty;
    public int MaxWeight { get; set; }
    public int CurrentWeight { get; set; }
    public ICollection<GetBackpackDto> Backpacks { get; set; } = new HashSet<GetBackpackDto>();
}
public class GetBackpackDto
{
    public string Name { get; set; } = null!;
    public decimal Weight { get; set; }
    public int amount { get; set; }
}