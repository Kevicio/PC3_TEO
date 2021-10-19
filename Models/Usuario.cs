using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC3_TEO.Models
{
    [Table("t_Usuario")]
        
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

         [Column("name")]
        public string Name {get; set;}
        
    }
}