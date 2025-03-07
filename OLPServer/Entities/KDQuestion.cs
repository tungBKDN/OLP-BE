using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OLPServer.Entities;

public class KDQuestion
{
   [Key]
   public int Id { get; set; }

   [Required]
   public string Question { get; set; }

   [Required]
   public string Answer { get; set; }

   [Required]
   public string Field { get; set; }

   public string? MediaLink { get; set; } = null;

   public bool IsAnswered { get; set; } = false;
}
