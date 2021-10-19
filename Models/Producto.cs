using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC3_TEO.Models
{
    [Table("t_producto")]
    public class Producto
    { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
         public int Id{
            get;
            set;
        }

        [Required(ErrorMessage="Debe escribir el nombre del producto")]
        [Column("name")]
         public string Nombre{
            get;
            set;
        }

        [Required]
        [Column("foto")]
        public string Foto{
            get;
            set;
        }

        [Column("fecha")]
        public DateTime Fecha { 
            get; 
            set; }

        [Required]
        [Column("descripcion")]
        public string Descripcion{
            get;
            set;
        }

        [Column("precio")]
        [Required]
        public decimal Precio{
            get;
            set;
        }

        [Column("celular")]
        [Required]
        public string Celular{
            get;
            set;
        }

        [Column("lugar")]
        [Required]
        public string LugarCompra{
            get;
            set;
        }

        [Column("comprador")]
        public string NombreComprador{
            get;
            set;
        }

         public Usuario Usuario{
            get;
            set;
        }

         public int? UsuarioId { 
            get; 
            set;
        }

        public Categoria Categoria{
            get;
            set;
        }

        public int CategoriaId { 
            get; 
            set;
        }




    }


}
    