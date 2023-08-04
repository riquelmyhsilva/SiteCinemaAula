using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteCinema.Models
{
    [Table ("Usuarios")]

    public class Usuario
    {
        public int id { get; set; }
            [Required]
            [MaxLength(100)]
        public string Nome { get; set; }
            [Required]
            [MaxLength(50)]
        public string Login { get; set; }
            [Required]
            [MaxLength(100)]
        public string senha { get; set; }
    }

    [Table ("Filmes")]
    public class Filmes
    {
        [Key]
        public int id { get; set; }
            [Required]
            [MaxLength(100)]
        public int Nome { get; set; }
            [Required]
            [MaxLength(100)]
        public int Genero { get; set; }
            [Required]
            [MaxLength(100)]
        public int Duracao { get; set; }
            [Required]
            [MaxLength(100)]
        public int Classificacao { get; set; }
            [Required]
            [MaxLength(100)]
        public int AnoLancamento { get; set; }
            [Required]
            [MaxLength(100)]
        public int Streaming { get; set; }
            [Required]
            [MaxLength(100)]
        public int Sinopse { get; set; }
            [Required]
            [MaxLength(500)]
        public int ImagemDados { get; set; }

    }
}