using PetStore.Data.Models;

namespace PetStore.Services.Models.Pets
{
    public class PetDetailsServiceModel
    {
        public int Id { get; set; }

        public string Breed { get; set; }
        public decimal Price { get; set; }
    }
}
