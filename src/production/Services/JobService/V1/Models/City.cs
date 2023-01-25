using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobService.V1.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public CityCode CityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(CountryCode))]
        public CountryCode CountryCode { get; set; }

    }
}
