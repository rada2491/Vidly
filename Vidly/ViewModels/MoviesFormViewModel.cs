using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }
        
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        public MoviesFormViewModel()
        {
            Id = 0;
        }

        public MoviesFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
        }
    }
}