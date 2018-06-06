namespace BookTradeA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Livro")]
    public partial class Livro
    {
        public Livro()
        {
            Comentarios = new HashSet<Comentarios>();
            Categorias = new HashSet<Categorias>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Sinopse { get; set; }

        public int AnoLanc { get; set; }

        [Required]
        public string Editora { get; set; }

        [Required]
        public string Idioma { get; set; }

        public int NumeroDePaginas { get; set; }

        [ForeignKey("Autores")]
        public int AutorId { get; set; }

        public virtual Autor Autores { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }

        public virtual ICollection<Categorias> Categorias { get; set; }
    }
}
