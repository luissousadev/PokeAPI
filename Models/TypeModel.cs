﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clone_PokeAPI.Models
{
    [Table("Types")]
    public class TypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<PokemonModel> Pokemons { get; set; }

        public string? URL { get; set; }
        
    }
}
