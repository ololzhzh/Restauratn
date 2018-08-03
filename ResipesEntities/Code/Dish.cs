using RecipesDomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResipesEntities.Code
{
    [Table("Dishes")]
    public class Dish : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
