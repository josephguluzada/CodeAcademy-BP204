using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Desc { get; set; }
        public double Costprice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPrice { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }

        public string Code { get; set; }

        public Author? Author { get; set; }
        public Category? Category { get; set; }


        public List<BookImage>? BookImages { get; set; }


        [NotMapped]
        public IFormFile? PosterImageFile { get; set; }
        [NotMapped]
        public IFormFile? HoverImageFile { get; set; }
        [NotMapped]
        public List<IFormFile>? ImageFiles { get; set; }
        [NotMapped]
        public List<int> BookImageIds { get; set; }
    }
}
