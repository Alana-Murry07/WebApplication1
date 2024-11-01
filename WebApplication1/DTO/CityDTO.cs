using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class CityDTO

    {
       
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Population { get; set; }
        public required string CountryName { get; set; }
    }
}
