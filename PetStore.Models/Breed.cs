namespace PetStore.Data.Models
{
    using System.Collections.Generic;
    public class Breed
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();

    }
}
