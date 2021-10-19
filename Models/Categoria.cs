using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace PC3_TEO.Models
{
    [Table("t_categoria")]
    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Column("id")]

        public int Id{
            get;
            set;
        }

        [Column("tipoCategoria")]
        public string TipoCategoria{
            get;
            set;
        }
        
    }
        
    
}