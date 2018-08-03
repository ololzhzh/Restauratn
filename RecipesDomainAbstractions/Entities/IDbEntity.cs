using System;
using System.ComponentModel.DataAnnotations;

namespace RecipesDomainAbstractions.Entities
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
