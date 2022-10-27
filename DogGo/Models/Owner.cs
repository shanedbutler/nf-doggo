using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(35)]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}
