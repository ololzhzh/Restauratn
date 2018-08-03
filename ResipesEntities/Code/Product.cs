using RecipesDomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Products")]
    public class Product : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Dimension { get; set; }

        public virtual List<Recipe> Recipes {get; set;}
    }
}
