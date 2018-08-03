using RecipesDomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResipesEntities.Code
{
    [Table("Countes")]
    public class Counter : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public int counts { get; set; }

        public virtual List<Recipe> recipes { get; set; }

    }
}
