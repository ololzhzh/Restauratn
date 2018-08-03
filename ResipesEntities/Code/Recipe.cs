using RecipesDomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Recipes")]
    public class Recipe : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public string TextRecipe { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Counter> Counts { get; set; }
        
    }
}
