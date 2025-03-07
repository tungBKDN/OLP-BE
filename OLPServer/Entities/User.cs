using System;
using System.ComponentModel.DataAnnotations;

namespace OLPServer.Entities;

public class User
{
   [Key]
   public int Id { get; set;}

   [Required]
   public string FullName { get; set;}

   [Required]
   public string Code { get; set;}
}
