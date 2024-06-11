using Apbd_kolos2.Models;
using ApbdT.Models;

namespace ApbdT.Data;

using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
    public MyContext()
    {
    }
    
    public MyContext(DbContextOptions<MyContext> options) 
        : base(options)
    {
    }

    
    

    public DbSet<Item> Items { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Backpacks> Backpacks { get; set; }
    public DbSet<Titles> Titles { get; set; }
    public DbSet<CharacterTitels> CharacterTitels { get; set; }
   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
            {
                new Backpacks
                {
                    CharacterId = 1,
                    ItemId = 1,
                    Amount = 11
                },
                new Backpacks
                {
                    CharacterId = 2,
                    ItemId = 2,
                    Amount = 8
                }
            });

            modelBuilder.Entity<Item>().HasData(new List<Item>
            {
                new Item()
                {
                    id = 1,
                    Name = "Chokolate",
                    Weight = 2
                },
                new Item()
                {
                    id = 2,
                    Name = "Water",
                    Weight = 1
                }
            });
            modelBuilder.Entity<Titles>().HasData(new List<Titles>
            {
                new Titles
                {
                    id = 1,
                    Name = "Title-1"
                },
                new Titles
                {
                    id= 2,
                    Name = "Title-2"
                }
            });
            modelBuilder.Entity<Character>().HasData(new List<Character>
            {
                new Character()
                {
                    id = 1,
                    FirstName = "Dmytro",
                    LastName = "Armianishyn",
                    CurrentWeight = 12,
                    MaxWeight = 60
                },
                new Character()
                {
                    id = 2,
                    FirstName = "Nikita",
                    LastName = "Bogdan",
                    CurrentWeight = 11,
                    MaxWeight = 59
                }
            });
            modelBuilder.Entity<CharacterTitels>().HasData(new List<CharacterTitels>
            {
                new CharacterTitels
                {
                    CharacterId = 1,
                    TitelsId = 1,
                    AcquiredAt = DateTime.Parse("2021-08-27")
                },
                new CharacterTitels
                {
                    CharacterId = 2,
                    TitelsId = 2,
                    AcquiredAt = DateTime.Parse("2023-12-29")
                }
            });
        }
    }
