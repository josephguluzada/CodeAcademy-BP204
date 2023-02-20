using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Setting
    {
        //public string HeaderLogo { get; set; }
        //public string FooterLogo { get; set; }
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string Key { get; set; }
        [StringLength(maximumLength:150)]
        public string Value { get; set; }
    }
}
