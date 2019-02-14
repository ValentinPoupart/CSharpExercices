using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiskManagement.Models
{
    public class Disk
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string Titre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Interprete { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateSortie { get; set; }

        public Disk()
        {

        }

        public Disk(int id, string titre, string interprete, DateTime datesortie)
        {
            this.Id = id;
            this.Titre = titre;
            this.Interprete = interprete;
            this.DateSortie = datesortie;
        }
        
        public Disk(string titre, string interprete, DateTime datesortie)
        {
            this.Titre = titre;
            this.Interprete = interprete;
            this.DateSortie = datesortie;
        }
    }
}