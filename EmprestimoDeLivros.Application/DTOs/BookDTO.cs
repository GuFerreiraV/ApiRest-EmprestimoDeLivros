using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.Application.DTOs
{
    public class BookDTO
    {
        public int Id { get; set;}
      
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string NameBook { get; set; }

        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string NameAutor { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string NamePublisher { get; set; }

        [Required]
        public DateTime YearPublication { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string NameEdition { get; set; }


    }
}
