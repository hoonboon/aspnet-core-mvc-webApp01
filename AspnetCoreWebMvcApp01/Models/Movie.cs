using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetCoreWebMvcApp01.Models
{
	public class Movie
	{
		public int Id { get; set; }
		
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Title { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		[RegularExpression(
			@"^[A-Z]+[a-zA-Z""'\s-]*$", 
			ErrorMessage = "Invalid format. Must only use letters. The first letter is required to be uppercase." 
				+ " White space, numbers, and special characters are not allowed.")]
		[Required]
		[StringLength(30)]
		public string Genre { get; set; }
		
		[Column(TypeName = "decimal(18,2)" )]
		[DataType(DataType.Currency)]
		[Range(1, 100)]
		public decimal Price { get; set; }

		[RegularExpression(
			@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", 
			ErrorMessage = "Invalid format. The first character is required to be an uppercase letter." 
				+ " Allows special characters and numbers in subsequent spaces.")]
		[StringLength(5)]
		[Required]
		public string Rating { get; set; }

	}
}
