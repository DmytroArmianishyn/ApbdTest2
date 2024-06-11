namespace ApbdT.Dto;

public class DtoAddBackPack
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }

    public DtoAddBackPack(int characterId, int itemId, int amount)
    {
        CharacterId = characterId;
        ItemId = itemId;
        Amount = amount;
    }
}