using System.ComponentModel.DataAnnotations;

namespace _29122022.Models
{
    public class Service
    {
        public int Id { get; set; }
        [StringLength(maximumLength:20)]
        public string Title { get; set; }
        [StringLength(maximumLength: 200)]
        public string Desc { get; set; }
        public string Icon { get; set; }
    }
}
