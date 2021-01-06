using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    public class Rate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FilmId { get; set; }

        [Range(1, 10)]
        [Required(ErrorMessage = "Please enter a rate for film")]
        [Display(Name = "Rate:")]
        public int RateValue { get; set; }
    }
}
