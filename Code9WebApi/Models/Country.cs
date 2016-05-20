using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code9WebApi.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z \-']+$", ErrorMessage = "Country name can contain only letters, space, minus or apostrophe.")]
        public string Name { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "International code for a country name has two characters.")]
        public string ShortName { get; set; }

        public string Currency { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Country can't have a negative area.")]
        public double Area { get; set; }
    }
}