using Apbd_kolos2.Models;
using ApbdT.Dto;
using ApbdT.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApbdT.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterController:ControllerBase
{
    private readonly CharacterService _service;
    public CharacterController(CharacterService service)
    {
        _service = service;
    }

    [HttpGet("characters/{id}")]
    public async Task<IActionResult> GetCharacters(int id)
    {
        var character = await _service.GetCharacter(id);

        var characterDto = new GetCharacterDto
        {
            FirstName = character.FirstName,
            LastName = character.LastName,
            CurrentWeight = character.CurrentWeight,
            MaxWeight = character.MaxWeight,
            Backpacks = character.Backpacks.Select(b => new GetBackpackDto
            {
                Name = b.Item.Name,
                Weight = b.Item.Weight,
                amount = b.Amount
            }).ToList()
        };
        return Ok(characterDto);
    }

    [HttpGet("characters/{id}/{backpacks}")]
    public async Task<IActionResult> AddItem(int id, BackPackDto backpacks)
    {
        for (int i = 0; i < backpacks.idItem.Count; i++)
        {
            if (!await _service.DoesItemExist(backpacks.idItem[i]))
                return NotFound($"Item with given ID - {backpacks.idItem[i]} doesn't exist");
        }

        var character = await _service.GetCharacter(id);

            var characterDto = new GetCharacterDto
            {
                FirstName = character.FirstName,
                LastName = character.LastName,
                CurrentWeight = character.CurrentWeight,
                MaxWeight = character.MaxWeight,
                Backpacks = character.Backpacks.Select(b => new GetBackpackDto
                {
                    Name = b.Item.Name,
                    Weight = b.Item.Weight,
                    amount = b.Amount
                }).ToList()
            };
            characterDto.Backpacks.Add(new GetBackpackDto(characterDto.id,1,2));
        }

    
}